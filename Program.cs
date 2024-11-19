using System;

namespace Assignment__3._2._2
{
    internal class Program
    {
        public void AddTwoArrays()
        {
            Console.Write("Enter the size of the matrix (less than 5): ");
            int matrixSize = Convert.ToInt32(Console.ReadLine());

            int[,] array = new int[matrixSize, matrixSize]; //arrays created
            int[,] array2 = new int[matrixSize, matrixSize];
            int[,] sum = new int[matrixSize, matrixSize];

            
            Console.WriteLine("First Array: ");
            for (int i = 0; i < matrixSize; i++) //diplaying arrays (row)
            {
                for (int j = 0;j < matrixSize; j++) //diplaying arrays (column)
                {
                    Console.Write(" " + array[i, j]);
                }
            }
            Console.WriteLine("Enter second array: ");
            for (int i = 0; i < matrixSize; i++) //loops until 'matrixSize' completed with input (x||'i', row)
            {
                for (int j = 0; j < matrixSize; j++) //loops until 'matrixSize' completed with input (y||'j', column)
                {
                    Console.Write($"Array Index [{0}][{1}]: ");
                    array[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }


            Console.WriteLine("Second Array: ");
            for (int i = 0; i < matrixSize; i++)
            {
                for (int j = 0; j < matrixSize; j++)
                {
                  Console.Write(" " + array2[i, j]);  
                }
                Console.WriteLine();

            }

            Console.WriteLine();

            Console.WriteLine("Lets add these arrays!");

            for (int i = 0;i < matrixSize; i++)
            {
                for (int j = 0;j < matrixSize; j++)
                {
                    sum[i,j] = array[i,j] + array2[i, j]; 
                }
            }
            Console.WriteLine();
            Console.WriteLine("Here is the result of the arrays: ");
            
            for(int i = 0; i <matrixSize; i++)
            {
                for (int j = 0; j < matrixSize; j++)
                {
                    
                   Console.Write(" " + sum[i,j]);
                    

                }
                Console.WriteLine();
            }
        }
         
        static void Main(string[] args)
        {
            Program addArray = new Program();
            addArray.AddTwoArrays();
           
        }
    }
}
