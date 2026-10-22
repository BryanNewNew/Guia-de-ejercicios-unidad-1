using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Guia_de_ejercicios_unidad1.Bloque4
{
    public class Ejercicio44
    {
        public void Ejecutar()
        {
            Console.Clear();
            Console.WriteLine("--- 44. Histograma de calificaciones ---");
            Console.Write("Ingrese la cantidad de calificaciones N: ");
            if (int.TryParse(Console.ReadLine(), out int n) && n > 0)
            {
                int[] notas = new int[n];
                Random rnd = new Random();

                // Generar notas aleatorias (0-100) para demostración rápida
                for (int i = 0; i < n; i++)
                {
                    notas[i] = rnd.Next(0, 101);
                }
                Console.WriteLine($"Notas generadas: {string.Join(", ", notas)}");

                int r0_59 = 0, r60_69 = 0, r70_79 = 0, r80_89 = 0, r90_100 = 0;

                foreach (var nota in notas)
                {
                    if (nota <= 59) r0_59++;
                    else if (nota <= 69) r60_69++;
                    else if (nota <= 79) r70_79++;
                    else if (nota <= 89) r80_89++;
                    else r90_100++;
                }

                Console.WriteLine("\n--- Histograma ---");
                Console.WriteLine($"  0 - 59: {new string('*', r0_59)} ({r0_59})");
                Console.WriteLine($" 60 - 69: {new string('*', r60_69)} ({r60_69})");
                Console.WriteLine($" 70 - 79: {new string('*', r70_79)} ({r70_79})");
                Console.WriteLine($" 80 - 89: {new string('*', r80_89)} ({r80_89})");
                Console.WriteLine($"90 - 100: {new string('*', r90_100)} ({r90_100})");
            }
            else
            {
                Console.WriteLine("Número inválido.");
            }
            Console.WriteLine("\nPresione una tecla para continuar...");
            Console.ReadKey();
        }
    }
}