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
            Console.WriteLine("Sum of digits problems UC8");
            Console.WriteLine("Enter the number");
            int a =int .Parse(Console.ReadLine());
            int sum = 0, b;
            while(a != 0)
            {
                b = a % 10;
                sum = sum + b;
                a = a / 10;
                
            }
            Console.WriteLine($"The sum of  the Digits is:  {sum}");


        }    
    }
}
