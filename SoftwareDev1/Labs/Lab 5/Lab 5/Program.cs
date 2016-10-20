/* Nick Schuler
 * Lab 5
 * Due October 26, 2014
 * CIS 199-01
 * The program is a console application that displays stars in a triangle. Using loops to create stars, but 
 *          also taking spaces into consideration for part c and d. */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_5
{
    class Program
    {
        static void Main(string[] args)
        {
            const int MAX_ROWS = 10;

            //part a
            Console.WriteLine("Part A");
            for (int row = 1; row <= MAX_ROWS; row++)
            {
                for (int star = 1; star <= row; star++)
                    Console.Write("*");
                Console.WriteLine();
            }

            //part b
            Console.WriteLine("Part B");
            for (int row = 1; row <= MAX_ROWS; row++)
            {
                for (int star = 10; star >= row; star--)
                    Console.Write("*");
                Console.WriteLine();
            }

            //part c
            Console.WriteLine("Part C");
            for (int row = 1; row <= MAX_ROWS; row++)
            {

                for (int space = 1; space < row; space++)
                    Console.Write(" ");
                for (int star = 10; star >= row; star--)
                    Console.Write("*");
                Console.WriteLine();
            }


            //part d
            Console.WriteLine("Part D");
            for (int row = 1; row <= MAX_ROWS; row++)
            {

                for (int space = 10; space > row; space--)
                    Console.Write(" ");
                for (int star = 1; star <= row; star++)
                    Console.Write("*");
                Console.WriteLine();
            }
                

                

        }
    }
}
