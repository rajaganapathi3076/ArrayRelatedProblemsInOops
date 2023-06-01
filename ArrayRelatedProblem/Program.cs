using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace ArrayRelatedProblem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the ArrayRelatedPro UC1");
            int[] numbers = { 1, 2, 3, 4, 5, 6, 2, 5, 1, 4, 5, 2, 4, 2, 5, 2 };

            Dictionary<int, int> duplicates = CountDuplicates(numbers);

            Console.WriteLine("Duplicate Elements:  ");

            foreach(KeyValuePair<int, int> pair in duplicates)
            {
                if (pair.Value > 1)
                {
                    Console.WriteLine($"{pair.Key} - Count: {pair.Value}");
                }
            }
            int totalDuplicates = duplicates.Values.Sum();
            Console.WriteLine($"Total number of duplicate elements: {totalDuplicates}");

        }
        static Dictionary<int,int> CountDuplicates(int[] numbers)
        {
            Dictionary<int,int>count=new Dictionary<int,int>();
            foreach (int number in numbers) 
            {
                if (count.ContainsKey(number)) 
                {
                    count[number]++;
                }
                else
                {
                    count[number] = 1;

                }
            }
            
            return count;
        }
    }
}
