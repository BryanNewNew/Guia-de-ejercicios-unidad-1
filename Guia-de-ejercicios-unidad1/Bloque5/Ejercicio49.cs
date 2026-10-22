using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Guia_de_ejercicios_unidad1.Bloque5
{
    public class Ejercicio49
    {
        public void Ejecutar()
        {
            Console.Clear();
            Console.WriteLine("--- 49. Separar Pares e Impares ---");
            List<int> listaOriginal = new List<int>();
            Random rnd = new Random();

            Console.Write("Generando 15 números enteros aleatorios: ");
            for (int i = 0; i < 15; i++)
            {
                int num = rnd.Next(1, 100);
                listaOriginal.Add(num);
                Console.Write($"{num} ");
            }
            Console.WriteLine();

            List<int> pares = new List<int>();
            List<int> impares = new List<int>();

            foreach (var num in listaOriginal)
            {
                if (num % 2 == 0)
                    pares.Add(num);
                else
                    impares.Add(num);
            }

            pares.Sort();
            impares.Sort();

            Console.WriteLine($"\nLista de Pares (ordenada): {string.Join(", ", pares)}");
            Console.WriteLine($"Lista de Impares (ordenada): {string.Join(", ", impares)}");

            Console.WriteLine("\nPresione una tecla para continuar...");
            Console.ReadKey();
        }
    }
}