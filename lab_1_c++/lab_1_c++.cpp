
// 12. Задана довжина окола. Визначити площу кола обмеженого цим околом

#include <math.h>
#include <iomanip>
#include <iostream>



using namespace std;


int main()
{
    float length, square; // задаємо змінні для довжини та площі кола
    const float pi = 3.1459265358979; //визначаємо пі
    setlocale(LC_ALL, "");
    cout << "12. Задана довжина окола. Визначити площу кола обмеженого цим околом";
    cout << "\n Будь ласка, введіть довжину кола ";
    cin >> length; // вводимо довжину кола
    square = (length * length) / (pi) ; //знаходимо площу кола
    cout << "Площа кола, обмеженого околом = " << fixed << setprecision(3) << square; // виводимо площу кола

    return 0;
}