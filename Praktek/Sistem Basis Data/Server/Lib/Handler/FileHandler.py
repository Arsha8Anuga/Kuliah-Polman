from datetime import datetime
from os import path, makedirs, remove
from werkzeug.datastructures import FileStorage

server_origin = '.\\Assets'

def directory_init(file_path: str):
    dir_path = path.join(server_origin, file_path)  # Combine server origin with the given file path
    print(f"Trying to create directory: {dir_path}")  # Debugging statement
    if not path.exists(dir_path):  # Check if the directory exists
        try:
            makedirs(dir_path)  # Create the directory if it doesn't exist
            print(f"Directory created: {dir_path}")  # Debugging statement
            return True
        except Exception as e:
            print(f"Error creating directory {dir_path}: {e}")  # Improved error logging
            return False
    else:
        print(f"Directory already exists: {dir_path}")  # Debugging statement
    return True  # Return True if the directory already exists


def file_name_maker(list_name, ext):
    now = datetime.now()
    return f"{'_'.join(list_name)}_{now.strftime('%d%m%Y%H%M%S')}.{ext}"

def create_file(file_path: str, list_endpoint_name: dict, file: FileStorage):
    if directory_init(file_path):
        file_name = file_name_maker(list_endpoint_name.values(), file.filename.split(".")[-1])
        full_path = path.join(server_origin, file_path, file_name)
        try:
            with open(full_path, "wb") as f:
                f.write(file.read())
            return full_path
        except Exception as e:
            print(f"Failed to create file: {e}")
    print(f"Failed to create file: {file}")
    return None

def delete_file(file_path: str):
    try:
        if path.isfile(file_path):
            remove(file_path)
            print(f"File {file_path} deleted successfully.")
            return True
        print(f"File {file_path} not found.")
    except Exception as e:
        print(f"Error deleting file {file_path}: {str(e)}")
    return False