using System;
using System.Transactions;

namespace Exercise_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Prompt for row width
            int row;
            int width;
            Console.WriteLine("Enter a Row Width");
            width = int.Parse(Console.ReadLine());
            //Prompt for number of rows
            Console.WriteLine("Enter a number of Rows");
            row = int.Parse(Console.ReadLine());
            //Print correct number of asteriks.
            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < row; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            //problem 2
            Console.WriteLine("Enter a Row Width");
            int asteriks = int.Parse(Console.ReadLine());
            for (int n = 1; n <= asteriks; n++)
            {
                for (int m = 1; m <= n; m++)
                {
                    Console.Write("*");
                }


                Console.WriteLine();
            }   
            
           
           
        }
    }
}