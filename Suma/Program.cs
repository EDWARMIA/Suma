using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Suma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            {
                Console.WriteLine("Calculadora de Suma de Dos Dígitos");

                Console.Write("Ingrese el primer dígito: ");
                string input1 = Console.ReadLine();

                Console.Write("Ingrese el segundo dígito: ");
                string input2 = Console.ReadLine();

                if (int.TryParse(input1, out int num1) && int.TryParse(input2, out int num2))
                {
                    int suma = num1 + num2;
                    Console.WriteLine($"La suma de {num1} y {num2} es igual a: {suma}");
                }
                else
                {
                    Console.WriteLine("Entrada no válida. Por favor, ingrese dos dígitos válidos.");
                }

                Console.ReadLine();
            }
        }

    }
}

