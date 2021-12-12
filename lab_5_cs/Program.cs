using System;


namespace lab_5_cs
{
    //12. Дано натуральне число n. Визначити всі числа, менші за n, та взаємно прості з ним.

    class Program
    {
        static void Main(string[] args)
        {
            int n;
            
            Console.Write("Please, input n: ");
            n = Convert.ToInt32(Console.ReadLine());

            AllSimpleNumbers(n);



        }


        static int AllSimpleNumbers(int num)
        {
            
            for (int i = 1; i < num; i++)
            {
                if (FindingMinDiv(i, num) == 1)
                {
                    Console.WriteLine(i);
                }

            }

          
            return 0;
        }
        //функція для виведення всіх взаємно простих чисел

       

       
        static int FindingMinDiv(int num_1, int num_2)
        {
            int result;

            while (num_1 != num_2)
            {
                if (num_1 > num_2)
                {
                    num_1 = num_1 - num_2;
                }
                else
                {
                    num_2 = num_2 - num_1;
                }

            }

            result = num_1;

            return result;
          
        }
        //функція для пошуку найбільшого спільного дільника







    }
}
