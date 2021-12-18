using System;

namespace lab_7_cs
{
    class Program
    {
  
        //12 варіант
        
        
        static void Main(string[] args)
        {

            int[] array = CreateChange();
        }



        //this will create two arrays of the inputed size, fill third array with their elements and change min and last elements places
        static int[] CreateChange()
        {

            //inputing length of array
            Console.Write("Please, input n: ");
            int n = Convert.ToInt32(Console.ReadLine());


            //result of calculations
            int[] array = ChangingElements(ArrayD(n));


            return array;
        }




        //this will change places of min and last elements in array
        static int[] ChangingElements(int[] array) {

            int min = array[0];
            int index = 0;
            for (int i = 0; i < array.Length; i++)
            {

                if (array[i]<min)
                {
                    min = array[i];
                    index = i;
                }

            }

            array[index] = array[array.Length - 1];
            array[array.Length - 1] = min;

            return array;

        }


        //this will create an array D fro two random arrays
        static int[] ArrayD(int n)
        {
            
            int[] array_a = CreateArray(n);          
            int[] array_b = CreateArray(n);
            int[] array_d = new int[n];
           
            for (int i = 0; i < n; i++)
            {
               
                if (array_a[i] > array_b[i])
                {
                    array_d[i] = array_a[i];
                }
                else
                {

                    if (array_b[i] > array_a[i])
                    {
                        array_d[i] = array_b[i];
                    }
                    else
                    {
                        array_d[i] = 0;
                    }
                }               
            }

            return array_d;
        }



        //this will create an array and fill it with random numers
        static int[] CreateArray(int n)
        {
            int[] array = new int[n];
            Random rnd = new Random();

            for (int i = 0; i < n; i++)
            {
                array[i] = rnd.Next(1, 1000);               
            }
           
            return array;

        }
    }












}
