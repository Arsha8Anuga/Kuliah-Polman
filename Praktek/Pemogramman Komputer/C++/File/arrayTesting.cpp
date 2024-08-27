#include <iostream>

using namespace std;

void *func1(int x, int y);

int main(){

    float t_badan[100];

    float t_badan_min = 20;

    int  sizeBadan = sizeof(t_badan)/sizeof(t_badan[0]);

    for(int i = 0 ; i < sizeBadan; i++){
        t_badan[i] = t_badan_min;
        t_badan_min += 1;
    }

    for(int i = 0 ; i < sizeBadan ; i++){
        cout<<t_badan[i]<<endl;
    }


    return 0;
}

void* func1(int x, int y){
    cout<<x+y<<endl;
}
