using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P8.__Palindromo
{
    class Program
    {
        static void Main(string[] args)
        {
            string elemento = "", opc = "";
            do
            {
                Console.Write("Ingrese un elemento que contenga 5 digitos:");
                elemento = Console.ReadLine();
                if (elemento.Length > 5)
                {
                    Console.Write("\nEl elemento ingresado es mayor a 5 digitos\nPrecione 'enter' para continuar'"); Console.ReadKey(); Console.Clear();
                }
                if (elemento.Length < 5)
                {
                    Console.Write("\nEl elemento ingresado es menor a 5 digitos\nPrecione 'enter' para continuar'"); Console.ReadKey(); Console.Clear();
                }
                else               
                if (elemento[0] == elemento[elemento.Length - 1] && elemento[1] == elemento[elemento.Length - 2])
                {
                    Console.Write("\nEl elemento ingresado si es palindromo\nPrecione 'enter' para continuar'"); Console.ReadKey(); Console.Clear();
                }                
                else
                {
                    Console.WriteLine("\nEl elemento ingresado no es un palindromo\nPrecione 'enter' para continuar'"); Console.ReadKey(); Console.Clear();
                }
                Console.WriteLine("\nDesea ingresar otro elemento?\nIngrese 'si' para volver a ejecutarlo y 'no' para salir: ");
                opc = Console.ReadLine(); Console.Clear();
            }
            while (opc == "si");

        }
    }
}
