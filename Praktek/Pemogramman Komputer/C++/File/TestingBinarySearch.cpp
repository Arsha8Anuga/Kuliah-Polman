#include <iostream>
#include <string>

#define INDEX_ARR 0

using namespace std;

int binarySearch(int* index_awal, int* index_akhir, int* index_sementara);

int main(){

    string dataNegara[] = {
        "indonesia",
        "jepang",
        "jerman",
        "singapura",
        "swiss",
        "thailand",
        "turki",
        "zimbabwe"
    };

    string dataInpt = "zimbabwe";

    int index_awal = INDEX_ARR;
    int index_akhir = (sizeof(dataNegara)/sizeof(dataNegara[0])) - 1 ;
    int index_tengah;

    int arr_size = sizeof(dataNegara)/sizeof(dataNegara[0]);

    for(int i = 0; i < arr_size; i++){
        int test = binarySearch(&index_awal,&index_akhir,&index_tengah);
        if(test == 1){
            if(dataInpt.compare(dataNegara[index_tengah]) > 0){
                index_awal = index_tengah;
            }else if(dataInpt.compare(dataNegara[index_tengah]) < 0){
                index_akhir = index_tengah;
            }
        }else{
            if(dataInpt.compare(dataNegara[index_tengah]) == 0){
                cout<<"data ditemukan";
            }else{
                cout<<"data tidak ditemukan";
            }
        }
        
    }


    return 0;
}


int binarySearch(int* index_awal, int* index_akhir, int* index_sementara){
      cout<<(*index_sementara)<<endl;
    *index_sementara = (*index_awal + *index_akhir)/2;
    if(*index_sementara != 1){
        return 1;
    }else{
        return 0;
    }
}

// int binaryComparasion(string data[],string input,int* index_awal, int* index_akhir, int* index_sementara){
//     int arr_size = sizeof(data)/sizeof(data[0]);
//     int str_size = sizeof(data[0]);
//     for(int i = 0 ; i < arr_size; i++){
//         for(int j = 0; j < str_size){}
//     }
// }





