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
            Console.WriteLine("Welcome to the ArrayRelatedPro UC4");
            int[] numbers = { 1, 2, 3, 4, 5, 6, 2, 5, 1, 4, 5, 2, 4, 2, 5, 2, 9, 8 };

            int maximum = FindMaximum(numbers);
            int minimum = FindMinimum(numbers);

            Console.WriteLine($"Maximum Elements :{maximum}");
            Console.WriteLine($"Minimum Elements  :{minimum}");
           
        }
        static int FindMaximum(int[] numbers)
        {

            int maximum = numbers[0]; 

            for(int i = 0; i < numbers.Length; i++)
            {
                if(numbers[i] > maximum)
                {
                    maximum = numbers[i];
                }
            }
            return maximum;
          
        }
        static int FindMinimum(int[] numbers)
        {
            int minimum= numbers[0];

            for(int i=0; i < numbers.Length; i++)
            {
                if(numbers[i] < minimum)
                {
                    minimum = numbers[i];
                }
            }
            return minimum;
        }
    }
}
