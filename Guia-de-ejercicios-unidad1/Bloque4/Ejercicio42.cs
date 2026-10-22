using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Guia_de_ejercicios_unidad1.Bloque4
{
    public class Ejercicio42
    {
        public void Ejecutar()
        {
            Console.Clear();
            Console.WriteLine("--- 42. Búsqueda y Ordenamiento ---");
            int[] arr = { 15, 42, 8, 23, 42, 16, 4, 99, 31, 12 };
            Console.WriteLine($"Arreglo original: {string.Join(", ", arr)}");

            // Segundo mayor
            var ordenadosDesc = arr.Distinct().OrderByDescending(x => x).ToArray();
            int segundoMayor = ordenadosDesc.Length > 1 ? ordenadosDesc[1] : ordenadosDesc[0];
            Console.WriteLine($"Segundo mayor elemento: {segundoMayor}");

            // Ordenar de forma ascendente (Método Burbuja)
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = 0; j < arr.Length - 1 - i; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
            Console.WriteLine($"Ordenado (Burbuja ascendente): {string.Join(", ", arr)}");

            // Mostrar elementos en posiciones pares
            Console.Write("Elementos en índices pares: ");
            for (int i = 0; i < arr.Length; i += 2)
            {
                Console.Write($"{arr[i]} ");
            }
            Console.WriteLine();

            Console.WriteLine("\nPresione una tecla para continuar...");
            Console.ReadKey();
        }
    }
}