#include <iostream>
#include <string>
#include <cstdio>
#include <iomanip>

using namespace std;

void introduction();
void introStatement();
void endStatement();
void constraint(int maxLooping);
void constrChap(int maxLooping); 

class LatFunctions {
    public :
        int hitungBagiBensin(int x, int y){
            return x/y;
        }
        void lat1(){
            int A,B,T;

            cout<<"Masukan nilai A = ";
            cin>> A;

            cout<<"Masukan nilai B = ";
            cin>> B;

            T = A + B;

            cout<<endl<<T<<endl;

            endStatement();
        }
        void lat2(){
            cout<< "Hello World!" << endl;
            endStatement();
        }
        void lat3(){
            cout<< "Hello World!" << endl;
            cout<< "Nama Saya Anugrah" << endl;
            endStatement();
        }
        void lat4(){
            cout<< "Hello World!\t";
            cout<< "Nama Saya Anugrah" << endl;
            endStatement();
        }
        void lat5(){
            cout<<"Bandung"<<endl;
            endStatement();
        }
        void lat6(){
            printf("%10s", "Bandung");
            printf("%s", "Surabaya");
            endStatement();
        }
        void lat7(){
            cout<< "12345678901234567890" << endl;
            printf("%10s", "Bandung");
            printf("%s", "Surabaya");
            endStatement();
        }
        void lat8(){
            cout<< 'A' << endl;
            endStatement();
        }
        void lat9(){
            cout<< static_cast<char>(65) << endl;
            endStatement();
        }
        void lat10(){
            cout<< static_cast<char>(97) << endl;
            endStatement();
        }
        void lat11(){
            cout<< 65 << endl;
            endStatement();
        }
        void lat12(){
            cout<< 65.0 << endl;
            endStatement();
        }
        void lat13(){
            int var_bulat = 32767;
            float var_pecahan1 = 339.2345678f;
            double var_pecahan2 = 3.4567e+40;
            char var_karakter = 'S';

            cout << "Variabel bulat = " << var_bulat << endl;
            cout << "Variabel pecahan1 = " << fixed << setprecision(7) << var_pecahan1 << endl;
            cout << "Variabel pecahan2 = " << scientific << var_pecahan2 << endl;
            cout << "Variabel karakter = " << var_karakter << endl;

            cout << "Press Enter to continue...";
            cin.ignore(); 
            cin.get();

            endStatement();
        }
        void lat14(){
            int a;
            a = 75;
            cout<< a << endl;

            endStatement();
        }
        void lat15(){
            int a;
            int b;
            a = 75;
            b = 5;
            cout<< a << endl;
            cout<< b << endl;

            endStatement();
        }
        void lat16(){
            int a;
            int b;
            int tambah;
            a = 75;
            b = 5;
            tambah = a+b;
            cout<< "nilai " << a << " + nilai " << b << "=" << tambah;

            endStatement();
        }
        void lat17(){

            int a = 14, b = 2, c = 3, d = 4;

            cout << "a = " << a << ", b = " << b << ", c = " << c << ", d = " << d << endl << endl;
            cout << "Hasil a % b = " << a % b << endl;
            cout << "Hasil a % c = " << a % c << endl;
            cout << "Hasil a % d = " << a % d << endl;
            cout << "Hasil a / d * d + a % d = " << a / d * d + a % d << endl;

            cout << "Press Enter to continue...";
            cin.ignore();
            cin.get();

            endStatement();
        }
        void lat18(){
            float a, b, c, d = 0;
            a = 3.0f;
            b = 4.0f;
            c = 7.0f;
            d = b * b - 4 * a * c;

            cout << fixed << setprecision(6);
            cout << "Hasil Diskriminan = " << d << endl;

            cout << "Press Enter to continue...";
            cin.ignore();
            cin.get();

            endStatement();
        }
        void lat19(){
            float radius, keliling, luas;
            radius = 10;
            keliling = 2 * 3.14f * radius;
            luas = 3.14f * radius * radius;

            cout << fixed << setprecision(2);
            cout << "\n Data lingkaran \n";
            cout << "Jari-jari = " << setw(8) << radius << endl;
            cout << "Keliling = " << setw(8) << keliling << endl;
            cout << "Luas = " << setw(8) << luas << endl;

            cout << "Press Enter to continue...";
            cin.ignore();
            cin.get();

            endStatement();
        }
        void lat20(){
            system("Color 07");
            cout << "Hello World dengan warna" << endl;
            endStatement();
        }
        void lat21(){
            float radius, keliling, luas;

            cout << "Masukkan jari-jari: ";
            cin >> radius;

            keliling = 2 * 3.14f * radius;
            luas = 3.14f * radius * radius;

            cout << fixed << setprecision(2);
            cout << "\n Data lingkaran \n";
            cout << "Jari-jari = " << setw(8) << radius << endl;
            cout << "Keliling = " << setw(8) << keliling << endl;
            cout << "Luas = " << setw(8) << luas << endl;

            cout << "Press Enter to continue...";
            cin.ignore();
            cin.get();
                    endStatement();
        }
        void lat22(){
            int p, l;
            float Luas;

            cout << "Masukkan Panjang: ";
            cin >> p;
            cout << "Masukkan Lebar: ";
            cin >> l;

            Luas = p * l;

            cout << "Luas persegi " << p << " * " << l << " adalah: " << Luas << endl;
            endStatement();
        }
        void lat23(){
            float x;

            cout << "Masukkan nilai = ";
            cin >> x;

            cout << fixed << setprecision(6);
            cout << "Format e = " << scientific << x << endl;
            cout << "Format f = " << fixed << x << endl;
            cout << "Format g = " << defaultfloat << x << endl;

            cout << "Press Enter to continue...";
            cin.ignore();
            cin.get();
           endStatement();  
        }
        void lat24(){

            int x,y,z;

            cout<<"Masukan Nilai alas : ";
            cin>> x;

            cout<<"Masukan Nilai tinggi : ";
            cin>> y;

            z =  x * y * 1/2;

            cout<<"Hasil luas segitiga = "<< z << endl << endl;

            endStatement();
        }
        void lat25(){

            int x,y;

            cout<<"Masukan Nilai sisi : ";
            cin>> x;

            y = x * x;

            cout<<"Hasil luas persegi = "<< y << endl << endl;

            endStatement();
        }
        void lat26(){

            int x,y;

            cout<<"Masukan Nilai x : ";
            cin>> x;

            y = 3*(x*x)-5*x+6;

            cout<<"Hasil polynomial 3x^2-5x+6 = "<< y << endl << endl;

            endStatement();
        }
        void lat27(){

            int celsius, hasil;

            cout<<"Masukan suhu dalam celsius : ";
            cin>> celsius;

            hasil = celsius*1.8 + 32;

            cout<<"suhu dalam farenheit adalah "<< hasil <<"F" << endl << endl;

            endStatement();

        }
        void lat28(){

            int uang_user, pertamax = 1500, pertalite = 1000, solar = 800, l_pertamax, l_pertalite, l_solar;

            cout<<"Masukan nilai uang : ";
            cin>> uang_user;

            l_pertamax = uang_user/pertamax;
            l_pertalite = uang_user/pertalite;
            l_solar = uang_user/solar;

            cout<<"hasil : Pertamax = "<<l_pertamax<<"L, Pertalite = "<<l_pertalite<<"L, Solar = "<<l_solar<<"L"<<endl<<endl;

            endStatement();
        }
        void lat29(){
            int nilai_A,nilai_B,nilai_C;

            cout<<"Masukan nilai A : ";
            cin>> nilai_A;

            cout<<"Masukan nilai B : ";
            cin>> nilai_B;

            nilai_C=nilai_A;
            nilai_A=nilai_B;
            nilai_B=nilai_C;

            cout<<"Nilai A = "<< nilai_A <<endl << "Nilai B = "<< nilai_B<<endl<<endl;

            endStatement();
        }
        void lat30(){
            int a,b;
            cout<<"Masukan Angka 1 = ";
            cin>>a;
            cout<<"Masukan Angka 2 = ";
            cin>>b;

            if(a>b){
                cout<<a<<" lebih besar dari "<<b<<endl<<endl;
            }else{
                cout<<b<<" lebih besar dari "<<a<<endl<<endl;
            }

            cin.get();
            system("pause");

            endStatement();
        }
        void lat31(){
            int nilai = 70;

            // cout<<"Masukan nilai anda : ";
            // cin>>nilai;
            

            if(nilai < 70){
                cout<<"Nilai anda jelek"<<endl<<endl;
            }else{
                cout<<"Nilai anda bagus"<<endl<<endl;
            }

            cin.get();
            system("pause");

            endStatement();
        }
        void lat32(){
            int nilai = 70;
            
            if(nilai < 70){
                cout<<"Nilai anda jelek"<<endl<<endl;
            }else if(nilai == 70) {
                cout<<"Nilai tepat di 70"<<endl<<endl;
            }else{
                cout<<"Nilai anda bagus"<<endl<<endl;
            }

            cin.get();
            system("pause");

            endStatement();
        }
        void lat33(){
            int A,B,C;
            
            cout<<"Masukan nilai A = ";
            cin>>A;
            cout<<"Masukan nilai B = ";
            cin>>B;
            cout<<"Masukan nilai C = ";
            cin>>C;

            if (A>B){
                if(A>C){
                    cout<<A<<endl<<endl;
                }else{
                    cout<<C<<endl<<endl;
                }
            }else{
                if(B>C){
                    cout<<B<<endl<<endl;
                }else{
                    cout<<C<<endl<<endl;
                }
            }

            
            endStatement();
        }
        void lat34(){
            int a;
            cout<<"Masukan nilai a = ";
            cin>>a;

            switch(a){
                case 1 : 
                cout<<"Anda memasukan angka 1"<<endl<<endl;
                break;
                case 2 : 
                cout<<"Anda memasukan angka 2"<<endl<<endl;
                break;
                case 3 : 
                cout<<"Anda memasukan angka 3"<<endl<<endl;
                break;
                default:
                cout<<"Anda memasukan angka selain 1, 2, dan 3";
                break;
            }

            endStatement();
        }
        void lat35(){
            char KodePulau;
            int KodeKota;

            cout<<"Masukan kode pulau (J/B)= ";
            cin>>KodePulau;

            switch(KodePulau){
                case 'J':
                    cout<<"Anda memilih pulau Jawa"<<endl;
                    cout<<"Silahkan masukan kode kota (1-3)= ";
                    cin>>KodeKota;
                    switch (KodeKota)
                    {
                    case 1 :
                        cout<<"Kota Jakarta"<<endl<<endl;
                        break;
                    case 2 :
                        cout<<"Kota Bandung"<<endl<<endl;
                        break;
                    case 3 :
                        cout<<"Kota Surabaya"<<endl<<endl;
                        break;
                    
                    default:
                        cout<<"Kode Kota Salah"<<endl<<endl;
                        break;
                    }
                    break;
                case 'S':
                    cout<<"Anda memilih pulau Sumatera"<<endl;
                    cout<<"Silahkan masukan kode kota (1-3)= ";
                    cin>>KodeKota;
                    switch (KodeKota)
                    {
                    case 1 :
                        cout<<"Kota Medan"<<endl<<endl;
                        break;
                    case 2 :
                        cout<<"Kota Palembang"<<endl<<endl;
                        break;
                    case 3 :
                        cout<<"Kota Padang"<<endl<<endl;
                        break;
                    
                    default:
                        cout<<"Kode Kota Salah"<<endl<<endl;
                        break;
                    }
                    break;
                default:
                    cout<<"Anda memasukan huruf selain J dan S"<<endl<<endl;
                    break;
            }
            endStatement();
        }
        void lat36(){

            float nilai;
            float nilai_A = 90.0,nilai_B = 70.0,nilai_C = 50.0,nilai_D = 30.0,nilai_E=0.0; 

            cout<<"Masukan nilai anda : ";
            cin>>nilai;
            

            if(nilai >= nilai_A){
                cout<<"Nilai anda A"<<endl<<endl;
            }else if(nilai >= nilai_B){
                cout<<"Nilai anda B"<<endl<<endl;
            }else if(nilai >= nilai_C){
                cout<<"Nilai anda C"<<endl<<endl;
            }else if(nilai >= nilai_D){
                cout<<"Nilai anda D"<<endl<<endl;
            }else if(nilai >= nilai_E){
                cout<<"Nilai anda E"<<endl<<endl;
            }else{
                cout<<"Nilai tidak dapat diidentifikasi"<<endl<<endl;
            }

            cin.get();
            system("pause");

            endStatement();
        }
        void lat37(){
            
            int inptBulan;

            cout<<"Masukan angka bulan (1-12) : ";
            cin>>inptBulan;

            switch(inptBulan){
                case 1 : 
                    cout<<"Januari"<<endl<<endl;
                    break;
                case 2 : 
                    cout<<"Februari"<<endl<<endl;
                    break;
                case 3 : 
                    cout<<"Maret"<<endl<<endl;
                    break;
                case 4 : 
                    cout<<"April"<<endl<<endl;
                    break;
                case 5 : 
                    cout<<"Mei"<<endl<<endl;
                    break;
                case 6 : 
                    cout<<"Juni"<<endl<<endl;
                    break;
                case 7 : 
                    cout<<"Juli"<<endl<<endl;
                    break;
                case 8 : 
                    cout<<"Agustus"<<endl<<endl;
                    break;
                case 9 : 
                    cout<<"September"<<endl<<endl;
                    break;
                case 10 : 
                    cout<<"Oktober"<<endl<<endl;
                    break;
                case 11 : 
                    cout<<"November"<<endl<<endl;
                    break;
                case 12 : 
                    cout<<"September"<<endl<<endl;
                    break;
                default:
                    cout<<"input angka tidak benar"<<endl<<endl;
                    break;
            }

            cin.get();
            system("pause");

            endStatement();
        }
        void lat38(){
            int x;

            cout<<"Masukan Nilai x : ";
            cin>>x;

            if(x%2==0){
                cout<<"Genap"<<endl<<endl;
            }else{
                cout<<"Ganjil"<<endl<<endl;
            }

            cin.get();
            system("pause");

            endStatement();
        
        }
        void lat39(){
            int angka;

            cout<<"Masukan nilai angka : ";
            cin>>angka;

            if(angka >= 81){
                cout<<"Nilai = A"<<endl<<endl;
            }else if(angka >= 76){
                cout<<"Nilai = AB"<<endl<<endl;
            }else if(angka >= 66){
                cout<<"Nilai = B"<<endl<<endl;
            }else if(angka >= 61){
                cout<<"Nilai = BC"<<endl<<endl;
            }else if(angka >= 56){
                cout<<"Nilai = C"<<endl<<endl;
            }else if(angka >= 41){
                cout<<"Nilai = D"<<endl<<endl;
            }else{
                cout<<"Nilai = E"<<endl<<endl;
            }

            cin.get();
            system("pause");

            endStatement();
        }
        void lat40(){

            int nilai_1,nilai_2,NR;

            cout<<"Masukan nilai 1 : ";
            cin>>nilai_1;

            cout<<"Masukan nilai 2 : ";
            cin>>nilai_2;

            if(nilai_1 >= 60){
                cout<<"lulus"<<endl<<endl;
            }else{
                NR = (nilai_1 + nilai_2)/2;

                if(NR >= 70){
                    cout<<"lulus"<<endl<<endl;
                }else{
                    cout<<"tidak lulus"<<endl<<endl;
                }

            }

            cin.get();
            system("pause");

            endStatement();
        }
        void lat41(){

            int N;

            cout<<"Masukan N : ";
            cin>>N;

            if(N > 50){
                if(N > 75){
                    N -= 25;
                }else{
                    N -= 10;
                }
            }else{
                N += 10;

            }

            cout<<N<<endl<<endl;

            cin.get();
            system("pause");

            endStatement();
        }
        void lat42(){
            int i;
            for(i=1;i<=20;i++){
                cout<<i;
            }

            cout<<endl<<endl;

            cin.get();
            system("pause");

            endStatement();
        }
        void lat43(){
            int I,A,B,C;
            A = 1;
            B = 20;
            C = 2;

            for(I=A; I<=B ; I+=C){
                cout<<I<<endl;
                B+=1;
            }

            cout<<endl<<endl;

            cin.get();
            system("pause");

            endStatement();
        }
        void lat44(){
            int i;
            for(i=1 ; i<=100 ; i++){
                if(i % 2== 0 && i % 3==0){
                    cout<<i<<endl;
                }
            }
            cout<<endl<<endl;

            cin.get();
            system("pause");

            endStatement();
        }
        void lat45(){
            int i, n, max = 0;

            for (i = 1; i <= 10; i++) {
                cout << "Masukkan nilai = ";
                cin >> n;
                
                if (n > max) {
                    max = n;
                }
            }

            cout << "Nilai terbesar adalah = " << max << endl;

            cout<<endl<<endl;

            cin.get();
            system("pause");

            endStatement();

        }
        void lat46(){
             int i, n = 0;

            for (i = 1; i <= 10; i++) {
                n = n + (i * 2);
                cout << n << " ";
            }

            cout<<endl<<endl;

            cin.get();
            system("pause");

            endStatement();
        }
        void lat47(){
            int i = 1;

            while (i <= 5) {
                cout << i << endl;
                i++;
            }

            cout<<endl<<endl;

            cin.get();
            system("pause");

            endStatement();
        }
        void lat48(){
            int i = 1;

            do {
                cout << i << endl;
                i++;
            } while (i <= 5);

            cout<<endl<<endl;

            cin.get();
            system("pause");

            endStatement();
        }
        void lat49(){

            int i, n, t = 0;

            for (i = 1; i <= 10; i++) {
                cout << "n = ";
                cin >> n;
                t = t + n;

                if (t > 100)
                    break;
            }

            cout << t << endl;

            cout<<endl<<endl;

            cin.get();
            system("pause");

            endStatement();
        }
        void lat50(){
            int i = 1, n, t = 0, r, count = 0;

            while (i <= 5) {
                cin >> n;
                if (n < 60)
                    continue;
                t = t + n;
                count++;
                i++;
            }

            r = t / count;
            cout << r << endl;

            cout<<endl<<endl;

            cin.get();
            system("pause");

            endStatement();
        }
        void lat51(){
            int i = 1;
            int MAX_VAL= 10;



            for (; i <= MAX_VAL ; i++){
                if(i * 2 != MAX_VAL){
                    cout<<i<<" = "<<i<<endl;
                }else{
                    cout<<i<<" = "<<(i * 10)<<endl;
                }
            }

            cout<<endl<<endl;

            cin.get();
            system("pause");

            endStatement();
        }
        void lat52(){
            const int MAX_VAL = 10;
            const int NUM_STD = 6;

            for (int i = 0; i < NUM_STD; i++){
                cout<< (i+1) << ". Kombinasi " << (i+1)<< "\t : " ;
                switch (i)
                {
                case 0 : 
                    for(int j = 0; j < MAX_VAL; j++){
                        if( (j+1) % 2 != 0){
                            cout<< j+1 << " ";
                        }else{
                            cout<< "* ";
                        }
                    }
                    break;
                case 1 : 
                    for(int j = 0; j < MAX_VAL; j++){
                        if( (j+1) % 2 == 0){
                            cout<< j+1 << " ";
                        }else{
                            cout<< "* ";
                        }
                    }
                    break;
                case 2 : 
                    for(int j = 0; j < MAX_VAL; j++){
                        if( (j+1) % 2 != 0){
                            cout<< j+1 << " ";
                        }else{
                            cout<< "* ";
                        }
                    }
                    break;
                case 3 : 
                    for(int j = 0; j < MAX_VAL; j++){
                        if( (j+1) % 2 == 0){
                            cout<< j+1 << " ";
                        }else{
                            cout<< "* ";
                        }
                    }
                    break;
                case 4 : 
                    for(int j = 0; j < MAX_VAL; j++){
                        if( j > ((MAX_VAL/2)-1)){
                            cout<< j+1 << " ";
                        }else{
                            cout<< "* ";
                        }
                    }
                    break;
                case 5 : 
                    for(int j = 0; j < MAX_VAL; j++){
                        if( j <= ((MAX_VAL/2)-1)){
                            cout<< j+1 << " ";
                        }else{
                            cout<< "* ";
                        }
                    }
                    break;
                
                default:
                    break;
                } 
                cout<<endl;
            }

            cout<<endl<<endl;

            cin.get();
            system("pause");

            endStatement();
            
        }
        void lat53(){

            const int n_1 = 0, n_2 = 1;
            const int SUKU_1 = 0, SUKU_2 = 1;
            int n, next, a = n_1, b = n_2;

            cout<<"Masukan seberapa banyak angka yang mau di masukan : ";
            cin>>n;

            cout<<"Bilangan Fibbonaci = ";
            
            for(int i = 0; i < n; i++){
               if (i == 0) {
                    cout << n_1;
                } else if (i == 1) {
                    cout << ", " << n_2;
                } else {
                    next = a + b;
                    a = b;
                    b = next;
                    cout << ", " << next;
                }
            }

             cout<<endl<<endl;

            cin.get();
            system("pause");

            endStatement();
        }
        void lat54(){

            int nilai_a, nilai_b, nilai_c, nilai_tertinggi = 0; 
            const int BANYAK_SISWA = 3;

            cout<<"Masukan nilai mahasiswa ke-1 : ";
            cin>>nilai_a;
            cout<<"Masukan nilai mahasiswa ke-2 : ";
            cin>>nilai_b;
            cout<<"Masukan nilai mahasiswa ke-3 : ";
            cin>>nilai_c;

            for(int i = 0; i < BANYAK_SISWA; i++){
                switch(i){
                    case 0: 
                        if(nilai_a >= nilai_b && nilai_a >= nilai_c){
                            nilai_tertinggi = nilai_a;
                        }
                        break;
                    case 1: 
                        if(nilai_b >= nilai_c && nilai_b >= nilai_a){
                            nilai_tertinggi = nilai_b;
                        }
                        break;
                    case 2: 
                        if(nilai_c >= nilai_b && nilai_c >= nilai_a){
                            nilai_tertinggi = nilai_c;
                        }
                        break;
                }
            }

            if(nilai_tertinggi >= 81){
                cout<< "Nilai Angka tertinggi adalah "<< nilai_tertinggi << "dengan Nilai Huruf A";
            }else if(nilai_tertinggi >= 76){
                cout<< "Nilai Angka tertinggi adalah "<< nilai_tertinggi << "dengan Nilai Huruf AB";
            }else if(nilai_tertinggi >= 66){
                cout<< "Nilai Angka tertinggi adalah "<< nilai_tertinggi << "dengan Nilai Huruf B";
            }else if(nilai_tertinggi >= 61){
                cout<< "Nilai Angka tertinggi adalah "<< nilai_tertinggi << "dengan Nilai Huruf BC";
            }else if(nilai_tertinggi >= 56){
                cout<< "Nilai Angka tertinggi adalah "<< nilai_tertinggi << "dengan Nilai Huruf C";
            }else if(nilai_tertinggi >= 41){
                cout<< "Nilai Angka tertinggi adalah "<< nilai_tertinggi << "dengan Nilai Huruf D";
            }else if(nilai_tertinggi >= 0){
                cout<< "Nilai Angka tertinggi adalah "<< nilai_tertinggi << "dengan Nilai Huruf E";
            }else{
                cout<< "Nilai Angka tertinggi adalah Tak terdefinisi dengan Nilai Huruf Tak terdefinisi";
            }

            cout<<endl<<endl;

            cin.get();
            system("pause");

            endStatement();
        }
        void lat55(){
            
            int inpt,total = 1,nilaiFaktor;

            cout<<"Masukan nilai N : ";
            cin>>inpt;
            
            nilaiFaktor = inpt;

            cout<< "Total Faktorisasi "<< nilaiFaktor << "! = ";

            for(int i = 0; inpt > i ; inpt-- ){
                total *= inpt;
                if(inpt - 1 != 0 ){
                    cout<<inpt<<".";
                }else{
                    cout<<inpt<<" = ";
                }
            }

             cout<< total;

             cout<<endl<<endl;

            cin.get();
            system("pause");

            endStatement();
        }
        void lat56(){
            int i, j;
            for(i = 1; i <= 3; i++) {
                for(j = 1; j <= 5; j++) {
                    cout << j << endl;
                }
            }

            cout<<endl<<endl;

            cin.get();
            system("pause");

            endStatement();
        }
        void lat57(){
            int i, j;
            for(i = 1; i <= 3; i++) {
                for(j = 1; j <= 5; j++) {
                    cout << " " << j;
                }
                cout << endl;
            }
            cout<<endl<<endl;

            cin.get();
            system("pause");

            endStatement();
        }
        void lat58(){
            int i, j;
            for(i = 1; i <= 3; i++) {
                for(j = 1; j <= 5; j++) {
                    cout << setw(3) << i;
                }
                cout << endl;
            }
            cout<<endl<<endl;

            cin.get();
            system("pause");

            endStatement();
        }
        void lat59(){
            int i, j;
            for(i = 1; i <= 3; i++) {
                for(j = 1; j <= 5; j++) {
                    cout << setw(3) << i;
                }
                cout << endl;
            }
            cout<<endl<<endl;

            cin.get();
            system("pause");

            endStatement();
        }
        void lat60(){
            int i, j;
            for(i = 1; i <= 3; i++) {
                for(j = 1; j <= 5; j++) {
                    cout << setw(3) << (i - 1) * 5 + j;
                }
                cout << endl;
            }
            cout<<endl<<endl;

            cin.get();
            system("pause");

            endStatement();
        }
        void lat61(){
            int i, j, n;
            n = 1;
            for(i = 1; i <= 3; i++) {
                for(j = 1; j <= 5; j++) {
                    cout << setw(3) << n;
                    n++;
                }
                cout << endl;
            }
            cout<<endl<<endl;

            cin.get();
            system("pause");

            endStatement();
        }
        void lat62(){
            int i, j;
            char k = 65;  
            for(i = 1; i <= 3; i++) {
                for(j = 1; j <= 5; j++) {
                    cout << setw(3) << k;
                    k++;
                }
                cout << endl;
            }
            cout<<endl<<endl;

            cin.get();
            system("pause");
        }
        void lat63(){
            int i, j;
            char k = 'A';
            for(i = 1; i <= 3; i++) {
                for(j = 1; j <= 5; j++) {
                    cout << setw(3) << k;
                    k++;
                }
                cout << endl;
            }
            cout<<endl<<endl;

            cin.get();
            system("pause");
        }
        void lat64(){
            int input;

            cout<<"Masukan Nilai :  ";
            cin>>input;

            for(int i = 0; i < input; i++ ){
                for(int j = 0; j < input; j++){
                    cout<< "+" << " ";
                }
                cout<<endl;
            }

             cout<<endl<<endl;

            cin.get();
            system("pause");

            endStatement();
        }
        void lat65(){

            int input;

            const int LOW_VAL = 0;

            cout<<"Masukan Nilai : ";
            cin>>input;

            for(int i = 0; i < input; i++){
                if( (i+1) % 2 != 0){
                    for(int j = 0; j < input ; j++){
                        cout<<j+1<<" ";
                    }
                    cout<<endl;
                }else{
                     for(int j = input ; j > LOW_VAL ; j--){
                        cout<<j<<" ";
                    }
                    cout<<endl;
                }

            
            }
            cout<<endl<<endl;

            cin.get();
            system("pause");    

            endStatement(); 
        }
        void lat66(){
            int input;

            const int LOW_VAL = 0;
            int decrement;

            cout<<"Masukan Nilai : ";
            cin>>input;
             decrement = input;
             for(int i = 0 ; i < input ; i ++){

                for (int j = decrement ; j > LOW_VAL; j--){
                    cout<<"* ";
                }

                decrement--;
                cout<<endl; 
            }

            cout<<endl<<endl;

            cin.get();
            system("pause");     

            endStatement();

        }
        void lat67(){

            int input;

            const int LOW_VAL =  0;
            const char MAX_CHAR = 'Z';
            const char DEFAULT_CHAR = 'A';

            char character = 65;

            cout<<"Masukan Nilai :  ";
            cin>>input;

            for(int i = 0; i < input; i++ ){
                for(int j = 0; j < i  ; j++){
                    if(character > MAX_CHAR){
                        character = DEFAULT_CHAR;
                    }

                    cout<< character << " ";
                    character++;
                }
                cout<<endl;
            }
            
            cout<<endl<<endl;

            cin.get();
            system("pause"); 

            endStatement();
        }
        void lat68(){
            int input;

            const int LOW_VAL = 0;
            const char MAX_CHAR = 'Z';
            const char DEFAULT_CHAR = 'A';

            char character = 65;

            cout<<"Masukan Nilai : ";
            cin>>input;

            int decrement = input;

            for(int i = 0; i < input; i++){
          
                for(int j = 0; j < input ; j++){
                    if(character > MAX_CHAR){
                        character = DEFAULT_CHAR;
                    }

                    if(j+1 < decrement){
                        cout<<" "<<" ";
                    }else{
                        cout<< character << " ";
                        character++;
                    }
                }
                decrement--;
                cout<<endl;
            }

            cout<<endl<<endl;

            cin.get();
            system("pause"); 

            endStatement();  
        }

};

int main(){
    introduction();
    return 0;
}


void introduction(){

    string listModul[] = {"Pertambahan",
                         "Hello World",
                         "Pindah Baris",
                         "Tabulasi",
                         "Menampilkan String 1",
                         "Menampilkan String 2",
                         "Menampilkan String 3", 
                         "Menampilkan Character",
                         "ASCII Converter 1", 
                         "ASCII Converter 2", 
                         "Integer", 
                         "float",
                         "Menampilkan Tipe Data dan Format Data",
                         "Menampilkan Isi Variabel 1",
                         "Menampilkan Isi Variabel 2",
                         "Menampilkan Isi Variabel 3",
                         "Menampilkan Isi Variabel 4",
                         "Menampilkan Isi Variabel 5",
                         "Menampilkan Isi Variabel 6",
                         "Merubah Tampilan Warna Background Dan Foreground",
                         "Memasukkan Nilai Dari Pengguna 1",
                         "Memasukkan Nilai Dari Pengguna 2",
                         "Memasukkan Nilai Dari Pengguna 3",
                         "Algoritma menghitung luas segitiga",
                         "Algoritma menghitung luas persegi",
                         "Program evaluasi polynomial 3*2-5x+6",
                         "Program konversi suhu Celsius ke Farenheit",
                         "Program menghitung nilai Pertamax, Pertalite, dan Solar",
                         "Menterjemahkan Flowchart",
                         "Membandingkan Dua Nilai",
                         "Membandingkan Nilai Lebih Besar",
                         "Multi kondisi 1",
                         "Multi kondisi 2",
                         "Program switch case 1",
                         "Program switch case 2",
                         "Mengkonversi Nilai",
                         "Menampilkan nama bulan",
                         "Translasi Flowchart ganjil genap",
                         "Konversi nilai ke angka",
                         "Menentukan kelulusan",
                         "Keluaran Nilai N", 
                         "Menampilkan deret angka 1 - 20",
                         "Deret angka dengan syarat", 
                         "Deret bilangan 1 - 100 habis dibagi 2 dan 3",
                         "Menampilkan nilai terbesar",
                         "Menampilkan nilai kostumisasi",
                         "Program While Do",
                         "Program Do While",
                         "Program for dan break",
                         "Program for dan continue",
                         "Mengubah Flowchart ke looping program",
                         "Kondisi if dalam for kombinasi",
                         "Matematika Fibbonacci", 
                         "3 Inputan nilai mahasiswa",
                         "Nilai faktorial",
                         "Nested Loop 1",
                         "Nested Loop 2",
                         "Nested Loop 3",
                         "Nested Loop 4",
                         "Nested Loop 5",
                         "Nested Loop 6",
                         "Nested Loop 7",
                         "Nested Loop 8",
                         "Program output kotak", 
                         "Program output Kotak dengan angka",
                         "Program segitiga terbalik",
                         "Program segitiga huruf",
                         "Program segitiga mirror"};

    int modulLength = sizeof(listModul)/ sizeof(listModul[0]);
    const int MAX_AESTERISK = 60;

    constraint(MAX_AESTERISK);


    cout<<"Silahkan Pilih Latihan Modul 1"<<endl<<endl;

    for(int i = 0; i < MAX_AESTERISK ; i++){
        if (i + 1 != MAX_AESTERISK){
            cout<<"*";
        }else{
            cout<<"*"<<endl<<endl;
        }
    }

    for(int i = 0; i < modulLength; i++){
            if (i+1 == 30){
                cout<<endl<<endl;
                constrChap(MAX_AESTERISK);
                cout<<i+1<<"."<<"\t"<<listModul[i]<<endl;
            }else if(i+1 == 42){
                cout<<endl<<endl;
                constrChap(MAX_AESTERISK);
                cout<<i+1<<"."<<"\t"<<listModul[i]<<endl;
            }else{
                cout<<i+1<<"."<<"\t"<<listModul[i]<<endl;
            }
    }

    cout<<endl;

    constraint(MAX_AESTERISK);

    introStatement();

    return;
}


void introStatement(){

    int switchStatement = 0;

    LatFunctions objClass;

    cout<<"Masukan latihan yang ingin dilihat : ";
    cin>> switchStatement;

    switch (switchStatement)
    {
        case 1: objClass.lat1(); break;
        case 2: objClass.lat2(); break;
        case 3: objClass.lat3(); break;
        case 4: objClass.lat4(); break;
        case 5: objClass.lat5(); break;
        case 6: objClass.lat6(); break;
        case 7: objClass.lat7(); break;
        case 8: objClass.lat8(); break;
        case 9: objClass.lat9(); break;
        case 10: objClass.lat10(); break;
        case 11: objClass.lat11(); break;
        case 12: objClass.lat12(); break;
        case 13: objClass.lat13(); break;
        case 14: objClass.lat14(); break;
        case 15: objClass.lat15(); break;
        case 16: objClass.lat16(); break;
        case 17: objClass.lat17(); break;
        case 18: objClass.lat18(); break;
        case 19: objClass.lat19(); break;
        case 20: objClass.lat20(); break;
        case 21: objClass.lat21(); break;
        case 22: objClass.lat22(); break;
        case 23: objClass.lat23(); break;
        case 24: objClass.lat24(); break;
        case 25: objClass.lat25(); break;
        case 26: objClass.lat26(); break;
        case 27: objClass.lat27(); break;
        case 28: objClass.lat28(); break;
        case 29: objClass.lat29(); break;
        case 30: objClass.lat30(); break;
        case 31: objClass.lat31(); break;
        case 32: objClass.lat32(); break;
        case 33: objClass.lat33(); break;
        case 34: objClass.lat34(); break;
        case 35: objClass.lat35(); break;
        case 36: objClass.lat36(); break;
        case 37: objClass.lat37(); break;
        case 38: objClass.lat38(); break;
        case 39: objClass.lat39(); break;
        case 40: objClass.lat40(); break;
        case 41: objClass.lat41(); break;
        case 42: objClass.lat42(); break;
        case 43: objClass.lat43(); break;
        case 44: objClass.lat44(); break;
        case 45: objClass.lat45(); break;
        case 46: objClass.lat46(); break;
        case 47: objClass.lat47(); break;
        case 48: objClass.lat48(); break;
        case 49: objClass.lat49(); break;
        case 50: objClass.lat50(); break;
        case 51: objClass.lat51(); break;
        case 52: objClass.lat52(); break;
        case 53: objClass.lat53(); break;
        case 54: objClass.lat54(); break;
        case 55: objClass.lat55(); break;
        case 56: objClass.lat56(); break;
        case 57: objClass.lat57(); break;
        case 58: objClass.lat58(); break;
        case 59: objClass.lat59(); break;
        case 60: objClass.lat60(); break;
        case 61: objClass.lat61(); break;
        case 62: objClass.lat62(); break;
        case 63: objClass.lat63(); break;
        case 64: objClass.lat64(); break;
        case 65: objClass.lat65(); break;
        case 66: objClass.lat66(); break;
        case 67: objClass.lat67(); break;
        case 68: objClass.lat68(); break;
        default: 
            cout<<"input nomor tidak valid, tolong masukan dari 1-21"<<endl<<endl;
            introStatement();
        break;
    }

}

void endStatement(){

    char answerInpt;

    cout<<"Apakah anda ingin kembali ke awal?(Y/N)"<<endl;
    cout<<"Jawaban Anda : ";
    cin>>answerInpt;
    cout<<endl;

    char toupperInpt = toupper(static_cast<unsigned char>(answerInpt));

        
    if(toupperInpt == 'Y'){
        introduction();
    }else if(toupperInpt == 'N') {
        exit(0);
    }else{
        cout << "Invalid input. Tolong masukan 'Y' atau 'N'." << endl;
        endStatement();
    }
}

void constraint(int maxLooping){
    for(int i = 0; i < maxLooping ; i++){
        if (i + 1 != maxLooping){
            cout<<"*";
        }else{
            cout<<"*"<<endl<<endl;
        }
    }
}

void constrChap(int maxLooping){
    for(int i = 0; i < maxLooping ; i++){
        if (i + 1 != maxLooping){
            cout<<"*";
        }else{
            cout<<"*"<<endl<<endl;
        }
    }
    for(int i = 0; i < maxLooping ; i++){
        if (i + 1 != maxLooping){
            cout<<"*";
        }else{
            cout<<"*"<<endl<<endl;
        }
    }
}