using System;

namespace lab_6_cs
{
    class Program
    {
        //12 варіант  

        delegate double trigonometric_function(double argument);
        //this will allow us choose between arctan and sin while integral calculating  

        static void Main(string[] args)
        {
          
            Console.Write("please, input a ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("please, input b ");
            int b = Convert.ToInt32(Console.ReadLine());   
            Console.Write("please, input n, n>0 ");
            int n = Convert.ToInt32(Console.ReadLine());
            

            double answer;
            answer = SumOfIntegrals(a, b, n);
            Console.WriteLine("answer is " + answer);

        }

      //function for finding the sum of two integrals(one of them is squared)
        static double SumOfIntegrals(double a, double b, int n)
        {
            //this will allow us choose between arctan and sin when integral calculating
            trigonometric_function sin = SinExponent;
            trigonometric_function atan = Math.Atan;
           

            double answer = 0;
            answer = (Math.Pow(IntegralCalculation(a, b, n, atan), 2) + IntegralCalculation(0, Math.PI, n, sin));
            return answer;
        }
        
        // this function finds intergral from a to b by dividing it to n parts 
        static double IntegralCalculation(double num_a, double num_b, int num_n, trigonometric_function _function)
        {
            double h = (num_b - num_a) / num_n;
            double result = 0;
            double sum_for_integral = 0;
            for (double i = 1; i < num_n ; i ++)
            {
                sum_for_integral += _function(num_a + Convert.ToDouble(i) * h);
            }
            int int_part = Convert.ToInt32((_function(num_a) + _function(num_b))/2 + sum_for_integral);

            result = int_part * h;

          
            return result;

        }

        //this function finds sin of exponential function 
     static double SinExponent(double num)
        {
            double result = Math.Sin(Math.Pow(Math.E,(10 * num)));
            
            return result;
        }
    }
}
