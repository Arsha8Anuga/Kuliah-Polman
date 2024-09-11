#include <iostream>
#include <string>
#include <stdlib.h>

using namespace std;


const int USERNAME = 0, PASSWORD = 1;
const string USER_DB[] = {"Anugrah_Muhammad_Arafah","224443048"};
const int USER_SIZE = sizeof(USER_DB)/sizeof(USER_DB[0]);

void loginMenu();
void congratsUser(string* user);
bool userCheking(string* user);


int main (){
    system("CLS");
    loginMenu();
    return 0 ;
}

void loginMenu(){

    string user[USER_SIZE];
    int login_catch = 0;


    while(true){

        cout<<"Silahkan masukan username (case sensitive) : ";
        cin>>user[USERNAME];

        cout<<"Silahkan masukan password (case sensitive) : ";
        cin>>user[PASSWORD];

        if(login_catch < 3 && !userCheking(user)){
            cout<< "Maaf username dan password tidak valid"<<endl;
            system("pause");
            cin.get();
            system("CLS");
            login_catch++;
            continue;


        }else if(login_catch > 2 && !userCheking(user)){
            cout<< "Akun Anda tidak dapat digunakan untuk sementara waktu" << endl;
            exit(0);
        }else{
            congratsUser(user);
            break;
        }
    
    }

}
void congratsUser(string* user){
    cout<< "Selamat datang " << user[USERNAME] << endl;
}

bool userCheking(string* user){
    if(user[USERNAME] == USER_DB[USERNAME] && user[PASSWORD] == USER_DB[PASSWORD]){
        return true;
    }
    return false;
}



