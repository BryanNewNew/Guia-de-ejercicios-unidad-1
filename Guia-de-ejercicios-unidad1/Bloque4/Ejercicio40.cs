using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Guia_de_ejercicios_unidad1.Bloque4
{
    public class Ejercicio40
    {
        public void Ejecutar()
        {
            Console.Clear();
            Console.WriteLine("--- 40. Frecuencia de elementos (1 al 10) ---");
            int[] numeros = new int[20];
            Random rnd = new Random();

            Console.Write("Generando 20 números aleatorios: ");
            for (int i = 0; i < 20; i++)
            {
                numeros[i] = rnd.Next(1, 11);
                Console.Write($"{numeros[i]} ");
            }
            Console.WriteLine();

            int[] frecuencias = new int[11]; // Del 1 al 10
            foreach (var num in numeros)
            {
                frecuencias[num]++;
            }

            Console.WriteLine("\nFrecuencias:");
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"Número {i}: aparece {frecuencias[i]} vez/veces");
            }

            int masFrecuenteVal = 1;
            int maxFrec = frecuencias[1];
            int menosFrecuenteVal = 1;
            int minFrec = frecuencias[1];

            for (int i = 2; i <= 10; i++)
            {
                if (frecuencias[i] > maxFrec)
                {
                    maxFrec = frecuencias[i];
                    masFrecuenteVal = i;
                }
                if (frecuencias[i] < minFrec)
                {
                    minFrec = frecuencias[i];
                    menosFrecuenteVal = i;
                }
            }

            Console.WriteLine($"\nElemento más frecuente: {masFrecuenteVal} ({maxFrec} veces)");
            Console.WriteLine($"Elemento menos frecuente: {menosFrecuenteVal} ({minFrec} veces)");
            Console.WriteLine("\nPresione una tecla para continuar...");
            Console.ReadKey();
        }
    }
}