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
            Console.WriteLine("Welcome to the ArrayRelatedPro UC3");
            int[] numbers = { 1, 2, 3, 4, 5, 6, 2, 5, 1, 4, 5, 2, 4, 2, 5, 2, 9, 8 };

           Dictionary<int,int>frequency=CountElementFrequency(numbers);

            Console.WriteLine("Elements Frequency");
            

            foreach(KeyValuePair<int,int> pair in frequency)
            {
                Console.WriteLine($"{pair.Key} - frequency :{pair.Value}");
            }
           
        }
        static Dictionary<int,int> CountElementFrequency (int[] numbers )
        {
           
            Dictionary<int,int> frequency = new Dictionary<int,int>(); 

            
            foreach (int number in numbers) 
            {
                if (frequency.ContainsKey(number)) 
                {
                    frequency[number]++;
                }
                else
                {
                    frequency[number] = 1;

                }
            }
            
            return frequency;
            
            
        }
    }
}
