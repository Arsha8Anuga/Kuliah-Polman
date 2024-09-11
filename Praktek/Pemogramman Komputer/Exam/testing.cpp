#include <iostream>

using namespace std;

int main(){
float nilai [7] = {70, 80.5, 90.7, 75, 88.5, 77.25, 95.25};
float *c;
float **d;

c = nilai;
d = &c;
cout<<*(*d + 3) + 5<<endl;
    return 0;
}