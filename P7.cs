using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P7.__No_aleatorios
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = new int[100];
            Random no = new Random();

            for (int i = 0; i < 100; i++)
            {
                numeros[i] = no.Next(0, 100);

            }
            for (int i = 0; i < 100; i++)
            {
                Console.Write(numeros[i] + ", ");

            }
            Array.Sort(numeros);
            Console.WriteLine("\n");
            for (int i = 0; i < 100; i++)
            {
                Console.Write(numeros[i] + ", ");

            }
            Console.ReadKey();
        }
    }
}
