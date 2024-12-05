from sqlalchemy.ext.automap import automap_base
from sqlalchemy.orm import sessionmaker
from sqlalchemy import create_engine

class DatabaseConnector :
    
    
    def __init__(self,db_data : list) -> None : 
        self.db_data = db_data
        self.engine = None
        self.Base = None
        
    def connect(self) -> None:
        username, password, host, port, database = self.db_data
        
        connection_url = f'mysql+pymysql://{username}:{password}@{host}:{port}/{database}'
        self.engine = create_engine(connection_url)

        self.Base = automap_base()
        self.Base.prepare(autoload_with=self.engine)
        
    def get_session(self) :
        
        if self.engine is None : 
            raise Exception("Database connection not initialized. Call db_connect() first.")

        Session = sessionmaker(bind=self.engine)
        return Session()
        
    def get_base(self) -> automap_base :
        
        if self.Base is None : 
            raise Exception("ORM Base not initialized. Call db_connect() first.")
        
        return self.Base