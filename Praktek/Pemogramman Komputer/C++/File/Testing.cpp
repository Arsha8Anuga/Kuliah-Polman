#include <iostream>
#include <string>

using namespace std;

int main(){
    

    int input;

    const int LOW_VAL = 0;
    const char MAX_CHAR = 'Z';
    const char DEFAULT_CHAR = 'A';

    char character = 65;

    cout<<"Masukan Nilai : ";
    cin>>input;

    int decrement = input;
    // for(int i = 0; i < input; i++){
    //     if( (i+1) % 2 != 0){
    //         for(int j = 0; j < input ; j++){
    //             cout<<j+1<<" ";
    //         }
    //         cout<<endl;
    //     }else{
    //          for(int j = input ; j > LOW_VAL ; j--){
    //             cout<<j<<" ";
    //         }
    //         cout<<endl;
    //     }

        // for(int i = 0; i < input; i++){
          
        //     for(int j = 0; j < input ; j++){
        //         if(character > MAX_CHAR){
        //             character = DEFAULT_CHAR;
        //         }

        //         if(j+1 < decrement){
        //             cout<<" "<<" ";
        //         }else{
        //             cout<< character << " ";
        //             character++;
        //         }
        //     }
        //     decrement--;
        //     cout<<endl;
        // }  

        for(int i = 0 ; i < input ; i++){

                for (int j = decrement ; j > LOW_VAL; j--){
                    cout<<"* ";
                }

                decrement--;
                cout<<endl; 
            }

    return 0;
}   