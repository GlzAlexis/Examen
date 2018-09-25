using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P2.__Algoritmo_inverso
{
    class Program
    {
        static void Main(string[] args)
        {
            string frase = "";

            Console.Write("introdusca la frase: ");
            frase = Console.ReadLine();

            string[] invertir = frase.Split(' ');

            Console.Write("\nLa frase invertida es: ");
            for (int e = invertir.GetLength(0) - 1; e >= 0; e--)
            {
                Console.Write(invertir[e] + " ");
            }
            Console.ReadKey();
        }
    }
}
