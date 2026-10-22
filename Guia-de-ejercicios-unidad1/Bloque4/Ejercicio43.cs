using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Guia_de_ejercicios_unidad1.Bloque4
{
    public class Ejercicio43
    {
        public void Ejecutar()
        {
            Console.Clear();
            Console.WriteLine("--- 43. Rotación de arreglo ---");
            int[] arr = { 1, 2, 3, 4, 5 };
            Console.WriteLine($"Original: {string.Join(", ", arr)}");

            Console.Write("Ingrese K posiciones a rotar/invertir: ");
            if (int.TryParse(Console.ReadLine(), out int k))
            {
                k %= arr.Length; // Evitar desbordamiento si k es mayor al tamaño

                // Rotar a la izquierda
                int[] izq = new int[arr.Length];
                Array.Copy(arr, k, izq, 0, arr.Length - k);
                Array.Copy(arr, 0, izq, arr.Length - k, k);
                Console.WriteLine($"Rotado K={k} posiciones a la izquierda: {string.Join(", ", izq)}");

                // Rotar a la derecha
                int[] der = new int[arr.Length];
                Array.Copy(arr, arr.Length - k, der, 0, k);
                Array.Copy(arr, 0, der, k, arr.Length - k);
                Console.WriteLine($"Rotado K={k} posiciones a la derecha: {string.Join(", ", der)}");

                // Invertir arreglo
                int[] inv = (int[])arr.Clone();
                Array.Reverse(inv);
                Console.WriteLine($"Arreglo invertido: {string.Join(", ", inv)}");
            }
            else
            {
                Console.WriteLine("Valor K inválido.");
            }
            Console.WriteLine("\nPresione una tecla para continuar...");
            Console.ReadKey();
        }
    }
}