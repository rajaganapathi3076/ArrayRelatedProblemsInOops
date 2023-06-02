using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ArrayRelatedProblem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int rows, columns;

            Console.Write("Enter the number of rows: ");
            rows = int.Parse(Console.ReadLine());

            Console.Write("Enter the number of columns: ");
            columns = int.Parse(Console.ReadLine());

            PrintRectanglePattern(rows, columns);

            Console.ReadLine();
        }

        static void PrintRectanglePattern(int rows, int columns)
        {
            for (int i = 1; i <= rows; i++)
            {
                for (int j = 1; j <= columns; j++)
                {
                    if (i == 1 || i == rows || j == 1 || j == columns)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }    }
    }
}
