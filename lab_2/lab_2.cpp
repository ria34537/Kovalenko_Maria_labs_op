
// 12. Визначити якому квалранту належть точка з координатами x,y

#include <math.h>
#include <iomanip>
#include <iostream>



using namespace std;


int main()
{
    int x, y;
    string answer = " ";
    setlocale(LC_ALL, "");
    cout << "12. Визначити якому квадранту належть точка з координатами x,y";
    cout << "\n Будь ласка, x ";
    cin >> x; // вводимо x
    cout << "\n Будь ласка,  y ";
    cin >> y; // вводимо y




    if (x==0 or y==0)
        answer = "Точка знаходиться на координатнiй осi";
    else {
       
        if (x > 0) {

            if (y > 0) 
                answer = "Точка в першому квадрантi";
            else
                answer = "Точка в четвертому квадрантi";
            
        }
        else{
                if (y > 0)
                    answer = "Точка в другому квадрантi";
                else
                    answer = "Точка в третьому квадрантi";
         }
        
            
            
    }

    cout << answer;











}