#include <iostream>
#include <string>

#define INDEX_ARR 0

using namespace std;

int binarySearch(const string* data, int arr_size, const string& target);

int main() {
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
    
    int arr_size = sizeof(dataNegara) / sizeof(dataNegara[0]);

    int index = binarySearch(dataNegara, arr_size, dataInpt);

    if (index != -1) {
        cout << "Data ditemukan pada index " << index << endl;
    } else {
        cout << "Data tidak ditemukan" << endl;
    }

    return 0;
}

int binarySearch(const string* data, int arr_size, const string& target) {
    int index_awal = INDEX_ARR;
    int index_akhir = arr_size - 1;
    int index_sementara;

    while (index_awal <= index_akhir) {
        index_sementara = (index_awal + index_akhir) / 2;

        if (data[index_sementara] == target) {
            return index_sementara; 
        } else if (data[index_sementara] < target) {
            index_awal = index_sementara + 1; 
        } else {
            index_akhir = index_sementara - 1;
        }
    }

    return -1; 
}