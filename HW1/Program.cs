using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] word = new string[100];
            string[] revWord = new string[100];
            int count = 0;

            while (true)
            {
                Console.Write("Enter String: ");
                word[count] = Console.ReadLine();
                if (word[count] == "*")
                {
                    break;
                }

                char[] revChar = new char[word[count].Length];

                string toLower = word[count].ToLower();

                for (int i = 0; i <= word[count].Length - 1; i++)
                {
                    revChar[i] = word[count][word[count].Length - 1 - i];
                    revWord[count] += revChar[i];
                }

                if (revWord[count].ToLower() == word[count].ToLower())
                {
                    Console.WriteLine("Original String: " + "\t\t  " + "Reversed: " + "\t\t  " + "Palindrome: ");
                    Console.WriteLine($"{word[count]} \t\t\t  {revWord[count]} \t\t  True \n");
                }
                else
                {
                    Console.WriteLine("Original String: " + "\t\t  " + "Reversed: " + "\t\t  " + "Palindrome: ");
                    Console.WriteLine($"{word[count]} \t\t\t  {revWord[count]} \t\t  False \n");
                }

                count++;

            }

            Console.ReadKey();
        }
    }
}
