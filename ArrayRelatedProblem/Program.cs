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
            Console.WriteLine("Welcome to the ArrayRelatedPro UC2");
            int[] numbers = { 1, 2, 3, 4, 5, 6, 2, 5, 1, 4, 5, 2, 4, 2, 5, 2, 9, 8 };

            List<int> uniquenElements = GetuniqueElements(numbers);

            Console.WriteLine("uniqueElements");
            

            foreach(int element in uniquenElements)
            {
                Console.WriteLine($"{element}");
            }
           
        }
        static List<int> GetuniqueElements(int[] numbers )
        {
            List<int>uniqueelements=new List<int>();
            Dictionary<int,int> count = new Dictionary<int,int>(); 

            
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
            foreach(KeyValuePair<int,int> pair in count)
            {
                if(pair.Value == 1)
                {
                    uniqueelements.Add(pair.Key);
                }
            }return uniqueelements;
            
            
        }
    }
}
