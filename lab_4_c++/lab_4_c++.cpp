
//
#include <math.h>
#include <iomanip>
#include <iostream>




using namespace std;


int main()
{

   
    float c, f, i, n;


    setlocale(LC_ALL, "");
    cout << "12. Отримати таблицю температур по Цельсію від 0 до n градусів і їх еквівалентів по шкалі Фаренгейта, ";
    cout << "\n Будь ласка, n ";
    cin >> n; // вводимо n
   
    c = 0;
    f = 0;
    cout << c << "          " << f <<"\n" ;

    for (i = 1; i <= n; i++) {
        c = ++c;
        f = c * 4.5 + 32;
        cout << c << "          " << f <<"\n";
    }
   

}


























