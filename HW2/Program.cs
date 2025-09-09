using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<List<double>> numbers = new List<List<double>>();

            Console.Write("Enter amount of row: ");
            int r_num = int.Parse(Console.ReadLine());

            Console.Write("Enter amount of column:");
            int c_num = int.Parse(Console.ReadLine());

            double sum = 0;
            double ave = 0;

            for (int r = 0; r < r_num; r++)
            {
                List<double> input_num = new List<double>();
                Console.WriteLine($"\nRows {r + 1}: ");

                for (int c = 0; c < c_num; c++)
                {
                    Console.Write($"Enter Number " + (c + 1) + " : ");
                    double nums = double.Parse(Console.ReadLine());
                    input_num.Add(nums);
                    sum += nums;
                }

                numbers.Add(input_num);
            }

            Console.Write("\nThe numbers are: \n");

            for (int f = 0; f < numbers.Count; f++)
            {
                for (int s = 0; s < numbers[f].Count; s++)
                {
                    Console.Write(numbers[f][s] + " ");
                }
            }

            Console.WriteLine($"\n\nThe sum is: {sum}");

            ave = sum / (r_num * c_num);
            Console.WriteLine($"\nThe average is: {ave}");

            Console.ReadKey();
        }
    }
}
