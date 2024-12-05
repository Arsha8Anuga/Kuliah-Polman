from environs import Env

def getEnv(env_name : tuple | str, prefix : str) -> list :
    env = Env()
    env_value = []
    env.read_env()
    try :
        with env.prefixed(prefix):
            for item in env_name :
                env_value.append(env(item))
        return env_value
    except Exception as e: 
        print(e)
        return None
    
        
    

            