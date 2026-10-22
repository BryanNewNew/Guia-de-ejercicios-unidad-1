using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Guia_de_ejercicios_unidad1.Bloque5
{
    public class Ejercicio47
    {
        public void Ejecutar()
        {
            Console.Clear();
            Console.WriteLine("--- 47. Registro de Calificaciones ---");
            List<double> notas = new List<double>();
            string respuesta;

            do
            {
                Console.Write("Ingrese una calificación (0-100): ");
                if (double.TryParse(Console.ReadLine(), out double nota) && nota >= 0 && nota <= 100)
                {
                    notas.Add(nota);
                }
                else
                {
                    Console.WriteLine("Nota inválida, no se agregará.");
                }

                Console.Write("¿Desea ingresar otra nota? (s/n): ");
                respuesta = Console.ReadLine()?.Trim().ToLower() ?? "n";
            } while (respuesta == "s");

            if (notas.Count > 0)
            {
                double promedioInicial = notas.Average();
                double maxima = notas.Max();
                double minima = notas.Min();

                Console.WriteLine($"\nTotal de notas ingresadas: {notas.Count}");
                Console.WriteLine($"Promedio inicial: {promedioInicial:F2}");
                Console.WriteLine($"Nota máxima: {maxima}");
                Console.WriteLine($"Nota mínima: {minima}");

                // Eliminar la nota más baja
                notas.Remove(minima);
                double promedioRecalculado = notas.Count > 0 ? notas.Average() : 0;

                Console.WriteLine($"\n[Eliminando la nota más baja ({minima})]");
                Console.WriteLine($"Nuevo promedio recalculado: {promedioRecalculado:F2}");
            }
            else
            {
                Console.WriteLine("No se ingresaron calificaciones.");
            }

            Console.WriteLine("\nPresione una tecla para continuar...");
            Console.ReadKey();
        }
    }
}