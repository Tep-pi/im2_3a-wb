using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Currency
{
    class Program
    {
        static void converterTiKuwarta(double moneh)
        {
            double pesoInD = 57.17;
            double yenInD = 146.67;

            double P_peso = moneh * pesoInD;
            double J_yen = moneh * yenInD;


            Console.WriteLine(moneh + "\t\t" + P_peso + "\t\t" + J_yen);
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            //Create a method / function to convert  a dollar to peso and yen.
            //Return multiple values. 1D=146.67yen 1D=57.17peso

            string kuwartaInput;
            string[] listaTiKuwarta;
            double kuwarta = 0.0;

            Console.Write("Enter currency in $ (example: 50,100): ");
            kuwartaInput = Console.ReadLine();

            listaTiKuwarta = kuwartaInput.Split(',');

            Console.WriteLine();
            Console.WriteLine("Dollars($)" + "\tPeso(P)" + "\t\tYen(Y)");

            for (int m = 0; m<listaTiKuwarta.Length; m++)
            {
                string listaKuwarta = listaTiKuwarta[m];
                kuwarta = double.Parse(listaKuwarta);
                
                converterTiKuwarta(kuwarta);
            }

            Console.ReadKey();
        }
    }
}
