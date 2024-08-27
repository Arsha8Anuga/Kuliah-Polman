#include <iostream>

using namespace std;

double bilPer;
double bilKed;

void kalkulator();
void pertambahan(double bilPer, double bilKed);
void pengurangan(double bilPer, double bilKed);
void perkalian(double bilPer, double bilKed);
void pembagian(double bilPer, double bilKed);
void moduls(double bilPer, double bilKed);

int main(){

    kalkulator();
    return 0;
}

void kalkulator(){
    int pilih;
    char ulangi;

    do{

    cout<<"\t ==== Kalkulator POLMAN ===="<<endl;

    cout<<"\t 1. Penjumlahan"<<endl;
    cout<<"\t 2. Pengurangan"<<endl;
    cout<<"\t 3. Perkalian"<<endl;
    cout<<"\t 4. Pembagian"<<endl;
    cout<<"\t 5. Modulus"<<endl;
    cout<<"\t 0. Exit"<<endl;

    cout<<"\t Silahkan pilih (0-5) : ";
    cin>>pilih;

    switch(pilih){
        case 1: pertambahan(bilPer,bilKed);break;
        case 2: pengurangan(bilPer,bilKed);break;
        case 3: perkalian(bilPer,bilKed);break;
        case 4: pembagian(bilPer,bilKed);break;
        case 5: moduls(bilPer,bilKed);break;
        case 0: cout<<"\tsee ya!!"<<endl;
                break;
        default:cout<<"\t Maaf anda salah memasukan angka"<<endl; continue; break;
    }
    cout<<endl;
    cout<<"\t Ulangi? (Y/N): ";
    cin>>ulangi;
    } while (ulangi == 'Y');
}

void pengurangan(double bilPer, double bilKed){
    cout<<"\t --- Pengurangan ---"<<endl;
    cout<<"\t Silahkan masukan bilangan pertama : ";
    cin>>bilPer;
    cout<<"\t Silahkan masukan bilangan kedua : ";
    cin>>bilKed;
    cout<<"\t"<<bilPer<<" - "<<bilKed<<" = "<<bilPer-bilKed<<endl;
}
void pertambahan(double bilPer, double bilKed){
    cout<<"\t --- Pertambahan ---"<<endl;
    cout<<"\t Silahkan masukan bilangan pertama : ";
    cin>>bilPer;
    cout<<"\t Silahkan masukan bilangan kedua : ";
    cin>>bilKed;
    cout<<"\t"<<bilPer<<" + "<<bilKed<<" = "<<bilPer+bilKed<<endl;
}
void perkalian(double bilPer, double bilKed){
    cout<<"\t --- Perkalian ---"<<endl;
    cout<<"\t Silahkan masukan bilangan pertama : ";
    cin>>bilPer;
    cout<<"\t Silahkan masukan bilangan kedua : ";
    cin>>bilKed;
    cout<<"\t"<<bilPer<<" * "<<bilKed<<" = "<<bilPer*bilKed<<endl;
}
void pembagian(double bilPer, double bilKed){
    cout<<"\t --- Pembagian ---"<<endl;
    cout<<"\t Silahkan masukan bilangan pertama : ";
    cin>>bilPer;
    cout<<"\t Silahkan masukan bilangan kedua : ";
    cin>>bilKed;
    cout<<"\t"<<bilPer<<" / "<<bilKed<<" = "<<bilPer/bilKed<<endl;
}
void moduls(double bilPer, double bilKed){
    cout<<"\t --- Modulus ---"<<endl;
    cout<<"\t Silahkan masukan bilangan pertama : ";
    cin>>bilPer;
    cout<<"\t Silahkan masukan bilangan kedua : ";
    cin>>bilKed;
    cout<<"\t"<<bilPer<<" % "<<bilKed<<" = "<<static_cast<int>(bilPer)%static_cast<int>(bilKed)<<endl;
}
