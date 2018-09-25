using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4.__Elemento_menor_entre_abc
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] abc = new double[3];

            Console.Write("Escriba el numero a: ");
            abc[0] = double.Parse(Console.ReadLine());
            Console.Write("Escriba el numero b: ");
            abc[1] = double.Parse(Console.ReadLine());
            Console.Write("Escriba el numero c: ");
            abc[2] = double.Parse(Console.ReadLine());

            Console.Write("\nEl numero menor es: " + abc.Min());
            Console.ReadKey();
        }
    }
}
