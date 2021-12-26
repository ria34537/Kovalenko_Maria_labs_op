using System;

namespace lab_8_cs
{
    class Program
    {
        static void Main(string[] args)
        {

            OutputResults();
        }



        // outputing results
        static void OutputResults()
        {
            Random rnd = new Random();
            int n = rnd.Next(1, 10);

            Console.WriteLine("Matrix_A");
            int[,] matrix_a = CreateA(n);
            matrixOutput(n, matrix_a);

            Console.WriteLine("Matrix_B");
            int[,] matrix_b = CreateB(n, matrix_a);
            matrixOutput(n, matrix_b);
            string center_number = CenterNumber(n, matrix_a);
            Console.WriteLine("center_number: " + center_number);
           
            
        }

        //find center number
        static string CenterNumber(int n, int[,] matrix)
        {
            string answer = "";

            if (n % 2 == 0)
            {
                answer = "matrix has no center number";
            }
            else
            {
                answer = Convert.ToString(matrix[n / 2 + 1, n / 2 + 1]);
            }
            return answer;
        }

        //creating matrix 
        static int[,] CreateA(int n){

            Random random = new Random();
            int[,] matrix_A = new int[n, n];
            for (int i = 0; i < n; i++)
            {
                for (int k = 0; k < n; k++)
                {
                    matrix_A[i, k] = random.Next(1,1000);
                }
            }

            return matrix_A;
        }

        //creating B by changing elements of a
        static int[,] CreateB(int n, int[,] matrix_A)
        {
            int[,] matrix_B = new int[n,n];
            int k = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    k = 0;
                    matrix_B[i,j] = matrix_A[i,j];
                    if (n > 2)
                    {
                        while (k < i && k < (n - 1 - i))
                        {

                            matrix_B[i,k] = matrix_A[i,n - 1 - k];
                            matrix_B[i,n - 1 - k] = matrix_A[i,k];
                            k++;
                        }
                    }
                }
            }

            return matrix_B;
        }


        //outputing matrix
        static void matrixOutput(int n, int[,] matrix)
        {
            for (int i = 0; i < n; i++)
            {
                for (int k = 0; k < n; k++)
                {
                    Console.Write(matrix[i, k] + "\t");
                }
                Console.WriteLine("");
            }
            Console.WriteLine(" ");
        }

    }
}
