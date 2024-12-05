import mimetypes
import os
from flask import Flask, Response, request, jsonify, send_file
from datetime import datetime
from requests_toolbelt import MultipartEncoder
from Lib.Handler.EnvHandler import getEnv
from Lib.Handler.DatabaseConnection import DatabaseConnector
from Lib.Handler.DatabaseProcessing import (
    clear_link_surat, delete_warn_row, get_file_path, get_student_nim, get_warn_details, user_credentials, 
    insert_warn_letter, search_by_warn_code, update_warn_letter_path,update_warn_letter_confirm
)
from Lib.Handler.FileHandler import create_file, delete_file
import json

app = Flask(__name__)
env_tuple = ("USERNAME", "PASSWORD", "HOSTNAME", "PORT", "NAME")
env = getEnv(env_tuple, "DB_")
db = DatabaseConnector(env)
db.connect()
Base, Session = db.get_base(), db.get_session()

UPLOAD_FOLDER = './uploads'
os.makedirs(UPLOAD_FOLDER, exist_ok=True)

@app.route("/test", methods=['PATCH'])
def test_post():
    try:
        if 'data_file' not in request.files:
            return jsonify({"error": "No file part"}), 400
        
        file = request.files['data_file']
        
        if file.filename == '':
            return jsonify({"error": "No selected file"}), 400

        file_path = os.path.join(UPLOAD_FOLDER, file.filename)
        file.save(file_path)

        json_data = request.form.get('data_json') 
        
        if json_data :
           print(json_data)
       
        return jsonify({
            "message": "File uploaded successfully",
            "file_path": file_path
        }), 200

    except Exception as e:
        return jsonify({"error": f"An error occurred: {str(e)}"}), 500


@app.route("/user_account", methods=['POST'])
def user_login():
    data = request.get_json()
    user_data = user_credentials(Session, Base, data.get('username'), data.get('password'))
    if user_data:
        return jsonify({"message": "Login successful", "user": user_data}), 200
    return jsonify({"message": "Invalid credentials"}), 401

@app.route("/sp_insert", methods=['POST'])
def insert_data():
    data = request.get_json()
    warn_letter_obj = {
        "nim": data.get("nim"),
        "kode_etik": data.get("kode_etik"),
        "laporan": data.get("laporan"),
        "jenis_peringatan": data.get("jenis_peringatan"),
        "waktu_peringatan": datetime.now()
    }
    result = insert_warn_letter(Session, Base, warn_letter_obj)
    if result == 1:
        return jsonify({"message": "Insert data successful", "data": result}), 200
    return jsonify({"message": result}), 400
        
@app.route("/upload", methods=['POST'])
def upload_test():
    file = request.files.get('Photo')
    if not file:
        return jsonify({'error': 'No file uploaded under the key "Photo"'}), 400
    dir_name = "./uploads"
    os.makedirs(dir_name, exist_ok=True)
    file.save(os.path.join(dir_name, file.filename))
    return "Data uploaded successfully", 200

@app.route("/upload/sp_photo", methods=['POST'])
def upload_sp_photo():
    try:
        uploaded_file = request.files.get('data_file')
        warn_code = request.form.get('data_json')

        print(f"Uploaded file: {uploaded_file}") 
        print(f"Received warn_code data: {warn_code}")
        
        if not uploaded_file or not warn_code:
            return jsonify({'error': 'No file or "warn_code" specified.'}), 400

        try:
            warn_code_data = json.loads(warn_code)
            warn_code = warn_code_data.get('warn_code')  
            print(f"Parsed warn_code: {warn_code}") 
        except json.JSONDecodeError as e:
            return jsonify({'error': 'Invalid JSON format for "data_json".'}), 400

        wc_data = search_by_warn_code(Session, Base, warn_code)
        if not wc_data:
            return jsonify({'error': 'Warning code not found.'}), 404

        cf_result = create_file(f"Uploads\\{wc_data['nim']}", wc_data, uploaded_file)
        if not cf_result:
            return jsonify({'error': 'Failed to create or update the file.'}), 500

        if not update_warn_letter_path(Session, Base, cf_result, wc_data.get('kd_peringatan')):
            return jsonify({'error': 'Failed to update database.'}), 500

        return jsonify({"message": "Photo uploaded and updated successfully", "data": wc_data}), 200

    except Exception as e:
        print(f"Error occurred: {str(e)}") 
        return jsonify({'error': f'An unexpected error occurred: {str(e)}'}), 500   
 
@app.route("/update/sp_photo", methods=['PATCH'])
def update_sp_photo():
    try:
        uploaded_file = request.files.get('data_file')
        warn_code = request.form.get("data_json")

        print(f"Uploaded file: {uploaded_file}")
        print(f"Received warn_code data: {warn_code}") 
        try:
            warn_code_data = json.loads(warn_code)
            warn_code = warn_code_data.get('warn_code')  
            print(f"Parsed warn_code: {warn_code}") 
        except json.JSONDecodeError as e:
            return jsonify({'error': 'Invalid JSON format for "data_json".'}), 400
        
        if not uploaded_file or not warn_code:
            return jsonify({'error': 'No file or "warn_code" specified.'}), 400

        wc_data = search_by_warn_code(Session, Base, warn_code)
        if not wc_data:
            return jsonify({'error': 'Warning code not found.'}), 404

        file_path = get_file_path(Session, Base, warn_code)
        if file_path:

            if not clear_link_surat(Session, Base, warn_code):
                return jsonify({'error': 'Failed to clear old file link in the database.'}), 500

            if os.path.isfile(file_path) and not delete_file(file_path):
                return jsonify({'error': 'Failed to delete the old file.'}), 500

        new_file_path = create_file(f"Uploads\\{wc_data['nim']}", wc_data, uploaded_file)
        if not new_file_path:
            return jsonify({'error': 'Failed to create or update the file.'}), 500

        if not update_warn_letter_path(Session, Base, new_file_path, wc_data.get('kd_peringatan')):
            return jsonify({'error': 'Failed to update database with the new file path.'}), 500

        return jsonify({"message": "Photo updated successfully", "data": wc_data}), 200

    except Exception as e:
        print(f"Error occurred: {str(e)}")
        return jsonify({'error': f'An unexpected error occurred: {str(e)}'}), 500
    
@app.route("/sp_delete", methods=['DELETE'])
def delete_warn_letter():
    try:
        warn_code = request.args.get('warn_code')

        if not warn_code:
            return jsonify({'error': 'No "warn_code" specified.'}), 400
        
        wc_data = search_by_warn_code(Session, Base, warn_code)
        if not wc_data:
            return jsonify({'error': 'Warning code not found.'}), 404

        file_path = get_file_path(Session, Base, warn_code)
        
        if file_path:

            if os.path.isfile(file_path) and not delete_file(file_path):
                return jsonify({'error': 'Failed to delete the old file.'}), 500
            
        delete_warn_row(Session, Base, warn_code)
        
        return jsonify({"message": "SP deleted successfully", "data": wc_data}), 200

    except Exception as e:
        return jsonify({'error': f'An unexpected error occurred: {str(e)}'}), 500

@app.route("/get_warn", methods=['GET'])
def get_student_warn():
    try:
        nim = request.args.get("nim")
        results = get_warn_details(Session, Base, nim)
        filtered_results = results

        if nim:
            specific_columns = ['kd_peringatan','kode_etik', 'laporan', 'jenis_peringatan', 'waktu_peringatan','link_surat', 'diterima']

            filtered_results = [
                {key: record.get(key, None) for key in specific_columns}
                for record in results
            ]

        return jsonify({"value": filtered_results}), 200

    except Exception as e:
        return jsonify({"error": str(e)}), 500

    
@app.route("/get_warn_image", methods=['GET'])
def get_warn_image():
    
    warn_code = request.args.get('warn_code')
    
    try:
      
        file_path = get_file_path(Session, Base, warn_code)

        if not file_path:
            return jsonify({'error': 'Warning file path not found.'}), 404
        
        mime_type, _ = mimetypes.guess_type(file_path)  
        if not mime_type:
            mime_type = 'application/octet-stream'  
    
        data = {"kd_peringatan": warn_code}
        
        file = open(file_path, 'rb')
        m = MultipartEncoder(
            fields={
                'value': str(data),  
                'files': (
                    os.path.basename(file_path),  
                    file, 
                    mime_type 
                )
            }
        )
            
        def chunked_reader(f, chunksize=2 ** 20): 
            while True:
                chunk = f.read(chunksize)
                if not chunk:
                    return
                yield chunk

        return Response(chunked_reader(m), content_type=m.content_type)

    except Exception as e:
        return jsonify({"error": str(e)}), 500
    
@app.route("/get_student", methods=['GET'])
def get_student():
    try:
        results = get_student_nim(Session, Base)
        filtered_results = results

        for record in filtered_results:
             print(record)
        return jsonify({"value": filtered_results}), 200

    except Exception as e:
        return jsonify({"error": str(e)}), 500
    
@app.route("/update_warn_status", methods=["PATCH"])
def update_warn_status():
    data = request.json  # Parse JSON payload
    warn_code = data.get("warn_code")
    diterima = data.get("diterima")
    time = datetime.now()

    if not warn_code or diterima is None:
        return jsonify({"error": "Invalid input. 'warn_code' and 'diterima' are required."}), 400

    try:
        # Call the update function
        success = update_warn_letter_confirm(Session, Base, diterima, time, warn_code,)
        if success:
            return jsonify({"message": "Warn status updated successfully."}), 200
        else:
            return jsonify({"error": "Failed to update warn status."}), 400
    except Exception as e:
        return jsonify({"error": f"Unexpected error: {str(e)}"}), 500


if __name__ == "__main__" : 
    app.run(debug=True, host='0.0.0.0', port=7012)






