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
            Console.WriteLine("ArrayRelaed problems UC7");
            string Inputstring, reversedString;

            Console.WriteLine("Enter the String");
            Inputstring = Console.ReadLine();


            reversedString = ReverseWord(Inputstring);
            Console.WriteLine("Reverse string: " + reversedString);

            Console.WriteLine();
        }
        static string  ReverseWord(string Input) 
        {
            string[] words = Input.Split(' ');
            string reversedString = "";

            foreach (string word in words)
            {
                char[] characters = word.ToCharArray();
                Array.Reverse(characters);
                string reversedWord = new string(characters);
                reversedString += reversedWord + " ";
            }
            return reversedString;

        }    
    }
}
