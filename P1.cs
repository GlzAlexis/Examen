using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P1._Valor_menor_y_mayor
{
    class Program
    {
        static void Main(string[] args)
        {
            int cant;

            Console.Write("Introdusca la cantidad de cifras que deas escribir: ");
            cant = Convert.ToInt32(Console.ReadLine());

            double[] numeros = new double[cant];

            for (int i = 0; i < cant; i++)
            {
                Console.Write("no.-" + (i + 1) + " de la sucesion: ");
                numeros[i] = double.Parse(Console.ReadLine());
            }

            Console.Write("\n El numero mayor es: " + numeros.Max() + "\n El numero menor es: " + numeros.Min());
            Console.ReadKey();
        }
    }
}
