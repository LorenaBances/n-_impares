﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace n__impares
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el número límite:");
            int limite = int.Parse(Console.ReadLine());

            Console.WriteLine("============================");
            Console.WriteLine("Escoja una opción:");
            Console.WriteLine("0: Números pares");
            Console.WriteLine("1: Números impares");
            Console.WriteLine("2: Factorial");

            int opcion = int.Parse(Console.ReadLine());


                List<int> numeros = Enumerable.Range(1, 20).Where(x => x % 2 != 0).ToList();

                foreach (var numero in numeros)
                {
                    Console.WriteLine(numero);
                }
                Console.ReadKey();

            
        }
    }
}
