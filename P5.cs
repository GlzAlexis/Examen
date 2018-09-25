using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P.__Regresar_la_primera_ocurrencia
{
    class Program
    {
        static void Main(string[] args)
        {
            int cont;

            Console.Write("Introdusca el numero de datos que ingresara: ");
            cont = int.Parse(Console.ReadLine());
            Console.Write("\n");
            double[] dig = new double[cont];

            for (int i = 0; i < cont; i++)
            {
                Console.Write((i + 1) + ".- Ingrese el digito: ");
                dig[i] = double.Parse(Console.ReadLine());
            }

            Console.Write("\nLa posicion de la ultima ocurrencia del numero maximo es: {0}", dig.ToList().IndexOf(dig.Max()) + 1);
            Console.ReadKey();
        }
    }
}
