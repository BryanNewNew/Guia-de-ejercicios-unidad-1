using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Guia_de_ejercicios_unidad1.Bloque4
{
    public class Ejercicio39
    {
        public void Ejecutar()
        {
            Console.Clear();
            Console.WriteLine("--- 39. Estadísticas de calificaciones ---");
            Console.Write("Ingrese la cantidad de calificaciones N: ");
            if (int.TryParse(Console.ReadLine(), out int n) && n > 0)
            {
                double[] notas = new double[n];
                for (int i = 0; i < n; i++)
                {
                    Console.Write($"Calificación {i + 1} (0-100): ");
                    notas[i] = double.Parse(Console.ReadLine()!);
                }

                double promedio = notas.Average();
                double maxima = notas.Max();
                double minima = notas.Min();
                int aprobados = notas.Count(nota => nota >= 65);
                int reprobados = notas.Count(nota => nota < 65);

                // Desviación estándar
                double sumaCuadrados = notas.Sum(d => Math.Pow(d - promedio, 2));
                double desviacionEstandar = Math.Sqrt(sumaCuadrados / notas.Length);

                Console.WriteLine("\n--- Resultados Estadísticos ---");
                Console.WriteLine($"Promedio: {promedio:F2}");
                Console.WriteLine($"Nota Máxima: {maxima}");
                Console.WriteLine($"Nota Mínima: {minima}");
                Console.WriteLine($"Aprobados (>=65): {aprobados}");
                Console.WriteLine($"Reprobados (<65): {reprobados}");
                Console.WriteLine($"Desviación Estándar: {desviacionEstandar:F2}");
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