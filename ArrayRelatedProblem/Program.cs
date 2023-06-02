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
            Console.WriteLine("Welcome to Print Pattern UC5");
            int rows = 8;
            int j, k, i;
            for ( i = 1; i <= rows; i++) 
            {
                for ( j = 1; j <= rows-i; j++) 
                {
                    //Console.Write("*");
                }
                for( k = 1; k <= j; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
            }
            Console.WriteLine();
        }
    }
}
