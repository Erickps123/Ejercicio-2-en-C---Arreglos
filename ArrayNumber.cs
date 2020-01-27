using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arreglos
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = new int[10];
            bool validar;
            int valor;
            Console.WriteLine("Arreglos");
            for(int i= 0; i <= 9; i++)
            {
                Console.Write("Ingrese un Numero: ");
                validar = int.TryParse(Console.ReadLine(), out valor);
                if (validar == true)
                {
                    numeros[i] = valor;
                }
                else
                {
                    Console.Write("No ingresó un numero valido! Ingrese un Numero: ");
                    validar = int.TryParse(Console.ReadLine(), out valor);
                    if (validar == true)
                    {
                        numeros[i] = valor;
                    }
                }
            }
            Console.WriteLine("El mayor de los numeros ingresados es: " + numeros.Max());
            Console.WriteLine("El menor de los numeros ingresados es: "+ numeros.Min());
            Console.ReadKey();
            
           
        }
    }
}

