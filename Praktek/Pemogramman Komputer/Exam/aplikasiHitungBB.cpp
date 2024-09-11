#include <iostream>
#include <string>
#include <stdlib.h>



using namespace std;

void brocaCalc(string* info, float* calc);
void BMICalc(string* info, float* calc);
void menuHitung();

char jenis_kelamin;
float tinggi_badan;
float berat_badan;


int main(){

    menuHitung();
    return 0;
}

void menuHitung(){

    int choice;

    string info = "";
    float result = 0.0;
 
    string menu[] = {
        "Hitung dengan metode Broca",
        "Hitung dengan metode BMI"
    };

    int sizeMenu = sizeof(menu)/sizeof(menu[0]);

    tinggi_badan = 0;
    berat_badan = 0;

    while(true){

        

        cout<<"\t === Aplikasi Hitung Berat Badan Ideal ==="<<endl;
        cout<<"\t\t = Anugrah's Property ="<<endl<<endl;

        for(int i = 0 ; i < sizeMenu ; i++){
            cout<< i+1 << ".  "<< menu[i] << endl;
        }
            cout<< "0.  Keluar"<<endl;

        cout<<endl;

        cout<<"Silahkan masukan pilihan anda (0-2) : ";

        cin>>choice;

        switch (choice)
        {
        case 1:
            brocaCalc(&info,&result);
        break;
        case 2: 
            BMICalc(&info,&result);
        break;
        case 0:
            exit(0);
        break;
        
        default:
            cout<<"Masukan angka yang benar (0-2)."<<endl;
            system("pause");
            cin.get();
            system("CLS");
            continue;
        break;
        }
      
        break;
    }

}

void brocaCalc(string* info, float* calc ){



    while(true){

    cout<<"\t = Anugrah's Property ="<<endl;

    cout<<"==============================="<<endl<<endl;

    cout<<"Jenis kelamin Anda (P/L) : ";
    cin>>jenis_kelamin;




    cout<<"Silahkan masukan tinggi Anda (CM) : ";
    cin>>tinggi_badan;

    cout<<"Silahkan masukan berat Anda (KG) : ";
    cin>>berat_badan;

    if(jenis_kelamin == 'P'){
        *calc = (tinggi_badan - 100) - ((tinggi_badan - 100 ) * (15/100));
        if(berat_badan == (tinggi_badan - 100) - ((tinggi_badan - 100 ) * (15/100))){
            *info = "berat badan anda ideal";
            break;
        }else if(berat_badan < (tinggi_badan - 100) - ((tinggi_badan - 100 ) * (15/100))){
            *info = "berat badan anda kekurangan";
            break;
        }else if(berat_badan > (tinggi_badan - 100) - ((tinggi_badan - 100 ) * (15/100))){
            *info = "berat badan anda berlebih";
            break;
        }
    }else{
        *calc = (tinggi_badan - 100) - ((tinggi_badan - 100 ) * (10/100));
         if(berat_badan == (tinggi_badan - 100) - ((tinggi_badan - 100 ) * (10/100))){
            *info = "berat badan anda ideal";
            break;
        }else if(berat_badan < (tinggi_badan - 100) - ((tinggi_badan - 100 ) * (10/100))){
            *info = "berat badan anda kekurangan";
            break;
        }else if(berat_badan > (tinggi_badan - 100) - ((tinggi_badan - 100 ) * (10/100))){
            *info = "berat badan anda berlebih";
            break;
        }
    }


    }
    
    cout<< "Hasil perhitungan broca : " << *calc << endl;
    cout<< "Analisis Broca : " << *info << endl; 
}


void BMICalc(string* info, float* calc){
    
    cout<<"Silahkan masukan tinggi Anda (CM) : ";
    cin>>tinggi_badan;

    cout<<"Silahkan masukan berat Anda (KG) : ";
    cin>>berat_badan;

    *calc = berat_badan / (tinggi_badan / 100) ;

    if(*calc > 25){
        *info = "BMI lebih";
    }else if(*calc < 18,5){
        *info = "BMI Kurang";
    }else{
        *info = "BMI normal";
    }

    cout<< "Hasil perhitungan BMI : " << *calc << endl;
    cout<< "Analisis Broca : " << *info << endl; 

}

