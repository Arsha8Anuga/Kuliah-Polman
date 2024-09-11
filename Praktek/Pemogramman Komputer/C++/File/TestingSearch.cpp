#include <iostream>
#include <string>

using namespace std;

const string dataNegara[] = {
    "indonesia",
    "malaysia",
    "timor_leste",
    "singapore",
    "thailand",
};

int searchingData(string inptData);

int main(){

    string cariData;

    cout<< sizeof(dataNegara)/sizeof(dataNegara[0]);

    do{
        cout<<"masukan negara : ";
        cin>>cariData;

    }while(searchingData(cariData) == 0);

    return 0;
}

int searchingData(string inptData){
      int size = sizeof(dataNegara) / sizeof(dataNegara[0]);

    for(int i = 0; i < size; i++){
        if(inptData == dataNegara[i]){
            cout<< "data ditemukan" <<endl;
            return 1;
        }
    }
    cout<< "data tidak ditemukan" <<endl;
    return 0;
}