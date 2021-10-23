
        //
#include <math.h>
#include <iomanip>
#include <iostream>




using namespace std;


int main()
{
    
    float n, temp, sinx, x, eps;

    setlocale(LC_ALL, "");
    cout << "12. Із заданою точністю обчислити значення функції sin x";
    cout << "\n Будь ласка, x ";
    cin >> x; // вводимо x
    cout << "\n Будь ласка,  точність ";
    cin >> eps; // вводимо y


    temp = x;
    sinx = temp;
    n = 1;

    while (fabs(temp) > eps)
    {
        temp = temp * (-1 * (x * x) /((2*n + 1)*(2*n )));
        sinx += temp;
        ++n;


    }

    cout << sinx;

    
}


























