using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prime
{
    class Program
    {
        static void taga_determine(int numberJayUser)
        {
            if (numberJayUser < 2)
            {
                Console.WriteLine("Composite");
                return;
            }

            for (int i = 2; i < numberJayUser ; i++)
            {
                if(numberJayUser % i == 0)
                {
                    Console.WriteLine("Composite");
                    return;
                }
            }
            Console.WriteLine("Prime");
        }
        static void Main(string[] args)
        {
            //Create a user defined method/function
            //to determine if it is a prime or not.

            string num_input;
            string[] numbers_list = new string[50];

            Console.Write("Enter string of numbers: ");
            num_input = Console.ReadLine();

            numbers_list = num_input.Split(' ');

            for (int n = 0; n < numbers_list.Length; n++)
            {
                int user_num = int.Parse(numbers_list[n]);
                Console.Write($"{n + 1}. {user_num}\t");
                taga_determine(user_num);
            }

            Console.ReadKey();
        }
    }
}
