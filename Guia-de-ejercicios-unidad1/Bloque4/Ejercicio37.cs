using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Guia_de_ejercicios_unidad1.Bloque4
{
    public class Ejercicio37
    {
        public void Ejecutar()
        {
            Console.Clear();
            Console.WriteLine("--- 37. Registro de números ---");
            Console.Write("Ingrese la cantidad de números (N) para el arreglo: ");
            if (int.TryParse(Console.ReadLine(), out int n) && n > 0)
            {
                int[] numeros = new int[n];
                for (int i = 0; i < n; i++)
                {
                    Console.Write($"Ingrese el número en la posición {i + 1}: ");
                    numeros[i] = int.Parse(Console.ReadLine()!);
                }

                // Recorrido con for
                int sumaFor = 0;
                for (int i = 0; i < numeros.Length; i++)
                {
                    sumaFor += numeros[i];
                }

                // Recorrido con foreach
                int sumaForeach = 0;
                foreach (var num in numeros)
                {
                    sumaForeach += num;
                }

                double promedio = (double)sumaFor / numeros.Length;
                int mayor = numeros.Max();
                int menor = numeros.Min();

                Console.WriteLine($"\nSuma (for): {sumaFor}");
                Console.WriteLine($"Suma (foreach): {sumaForeach}");
                Console.WriteLine($"Promedio: {promedio:F2}");
                Console.WriteLine($"Valor Mayor: {mayor}");
                Console.WriteLine($"Valor Menor: {menor}");
            }
            else
            {
                Console.WriteLine("Cantidad inválida.");
            }
            Console.WriteLine("\nPresione una tecla para continuar...");
            Console.ReadKey();
        }
    }
}