from datetime import datetime
from sqlalchemy import and_
from sqlalchemy.orm.exc import NoResultFound, MultipleResultsFound
from sqlalchemy.exc import SQLAlchemyError

def user_credentials(session, base, username, password):
    user_table = base.classes.t_user
    try:
        user_data = session.query(user_table).filter(
            and_(user_table.username == username, user_table.password == password)
        ).one()
        
        id_role = str(user_data.id_role)
        detail_table = base.classes["t_mahasiswa" if id_role == "2" else "t_admin"]
        detail_data = session.query(detail_table).filter(detail_table.id_user == user_data.id).one()

        return {**{column.name: getattr(detail_data, column.name) for column in detail_table.__table__.columns},
                **{column.name: getattr(user_data, column.name) for column in user_table.__table__.columns if column.name != "id"}}
    except (NoResultFound, MultipleResultsFound):
        print("No user found or multiple users found with the given credentials.")
        return None
    except Exception as e:
        print(f"An error occurred: {e}")
        return None

def insert_warn_letter(session, base, obj):
    warn_letter_table = base.classes.t_surat_peringatan
    try:
        warn_obj = warn_letter_table(
            kd_peringatan_depan='sp',
            nim=obj.get('nim'),
            kode_etik=obj.get('kode_etik'),
            laporan=obj.get('laporan'),
            jenis_peringatan=obj.get('jenis_peringatan'),
            waktu_peringatan=obj.get('waktu_peringatan')
        )
        session.add(warn_obj)
        session.commit()
        return True
    except SQLAlchemyError as e:
        session.rollback()
        print(f"SQLAlchemy error: {e}")
    except Exception as e:
        print(f"Error during insertion: {e}")
    return False

def search_by_warn_code(session, base, warn_code):
    warn_letter_table = base.classes.t_surat_peringatan
    wc_substring = warn_code.split("-")
    try:
        wl_data = session.query(warn_letter_table).filter(
            and_(warn_letter_table.kd_peringatan_depan == wc_substring[0], warn_letter_table.kd_peringatan_belakang == wc_substring[1])
        ).one()

        return {key: item.replace(" ", "-").replace("_", "-") for key, item in {
            "kd_peringatan": warn_code,
            "nim": wl_data.nim,
            "kode_etik": wl_data.kode_etik or "",
            "jenis_peringatan": wl_data.jenis_peringatan
        }.items()}
    except NoResultFound:
        print("No warn data found.")
    except Exception as e:
        print(f"Unexpected error: {e}")
    return None

def update_warn_letter_path(session, base, full_path, warn_code):
    warn_letter_table = base.classes.t_surat_peringatan
    wc_substring = warn_code.split("-")
    if len(wc_substring) != 2:
        print("Invalid warn_code format.")
        return False

    try:
        warn_row = session.query(warn_letter_table).filter(
            and_(warn_letter_table.kd_peringatan_depan == wc_substring[0], warn_letter_table.kd_peringatan_belakang == wc_substring[1])
        ).first()

        if warn_row:
            warn_row.link_surat = full_path
            session.commit()
            return True
        print("Row not found.")
    except SQLAlchemyError as e:
        session.rollback()
        print(f"SQLAlchemy error: {e}")
    except Exception as e:
        session.rollback()
        print(f"Unexpected error: {e}")
    return False

def delete_warn_row(session, base, warn_code):
    warn_letter_table = base.classes.t_surat_peringatan
    wc_substring = warn_code.split("-")
    try:
        warn_row = session.query(warn_letter_table).filter(
            and_(warn_letter_table.kd_peringatan_depan == wc_substring[0], warn_letter_table.kd_peringatan_belakang == wc_substring[1])
        ).first()

        if warn_row:
            session.delete(warn_row)
            session.commit()
            return True
        print(f"No row found for warn_code {warn_code}.")
    except Exception as e:
        print(f"Error deleting row: {e}")
    return False

def clear_link_surat(session, base, warn_code):
    warn_letter_table = base.classes.t_surat_peringatan
    wc_substring = warn_code.split("-")
    try:
        warn_row = session.query(warn_letter_table).filter(
            and_(warn_letter_table.kd_peringatan_depan == wc_substring[0], warn_letter_table.kd_peringatan_belakang == wc_substring[1])
        ).first()

        if warn_row:
            warn_row.link_surat = None
            session.commit()
            return True
        print(f"Warn_code {warn_code} not found.")
    except Exception as e:
        session.rollback()
        print(f"Error clearing link_surat: {e}")
    return False

def get_file_path(session, base, warn_code):
    warn_letter_table = base.classes.t_surat_peringatan
    wc_substring = warn_code.split("-")
    try:
        warn_row = session.query(warn_letter_table).filter(
            and_(warn_letter_table.kd_peringatan_depan == wc_substring[0], warn_letter_table.kd_peringatan_belakang == wc_substring[1])
        ).first()

        if warn_row.link_surat:
            return warn_row.link_surat  # If link_surat exists, return it
        else:
            print(f"link_surat is NULL for warn_code: {warn_code}.")
            return None 
    except Exception as e:
        print(f"Error fetching file path: {e}")
    return None 

def get_warn_details(session, base, nim=None):
    try:
        warn_table = base.classes.t_surat_peringatan
        student_table = base.classes.t_mahasiswa

        query = session.query(warn_table, student_table).join(
            student_table, warn_table.nim == student_table.nim
        )

        if nim:
            query = query.filter(warn_table.nim == nim)

        def format_datetime(value):
            return value.strftime("%Y-%m-%d %H:%M:%S") if isinstance(value, datetime) else value

        print("hai")
        return [
            {
                **{
                    col.name: format_datetime(getattr(warn, col.name))
                    for col in warn_table.__table__.columns
                    if col.name not in ['kd_peringatan_depan', 'kd_peringatan_belakang']
                },
                **{
                    col.name: format_datetime(getattr(student, col.name))
                    for col in student_table.__table__.columns
                },
                'kd_peringatan': f"{warn.kd_peringatan_depan}-{warn.kd_peringatan_belakang}"
            }
            for warn, student in query.all()
        ]
    except Exception as e:
        print(f"Error fetching warning details: {e}")
        return None 
    
def get_student_nim(session, base):
    try:
        student_table = base.classes.t_mahasiswa  # Reference the student table

        query = session.query(student_table)  # Query all rows from the student table

        return [
            {'nim': student.nim}  # Return only the 'nim' from the student table
            for student in query.all()  # Iterating over each student record
        ]
    except Exception as e:
        print(f"Error fetching student details: {e}")
        return None
    
def update_warn_letter_confirm(session, base, confirmation, time, warn_code):
    warn_letter_table = base.classes.t_surat_peringatan
    wc_substring = warn_code.split("-")
    if len(wc_substring) != 2:
        print("Invalid warn_code format.")
        return False

    try:
        warn_row = session.query(warn_letter_table).filter(
            and_(warn_letter_table.kd_peringatan_depan == wc_substring[0], warn_letter_table.kd_peringatan_belakang == wc_substring[1])
        ).first()

        if warn_row:
            warn_row.diterima = bool(confirmation)
            warn_row.waktu_diterima = time if bool(confirmation) else None
            session.commit()
            return True
        print("Row not found.")
    except SQLAlchemyError as e:
        session.rollback()
        print(f"SQLAlchemy error: {e}")
    except Exception as e:
        session.rollback()
        print(f"Unexpected error: {e}")
    return False