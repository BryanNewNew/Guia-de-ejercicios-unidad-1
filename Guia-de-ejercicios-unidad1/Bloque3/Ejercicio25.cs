using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Guia_de_ejercicios_unidad1.Bloque3
{
    public class Ejercicio25
    {
        public void Ejecutar()
        {
            Console.Clear();
            Console.WriteLine("--- Ejercicio 25: Promedio con Centinela (-1 para salir) ---");
            double suma = 0;
            int contador = 0;
            double max = double.MinValue;
            double min = double.MaxValue;
            double numero;

            do
            {
                Console.Write("Ingrese un número (-1 para terminar): ");
                if (double.TryParse(Console.ReadLine(), out numero))
                {
                    if (numero == -1) break;

                    suma += numero;
                    contador++;

                    if (numero > max) max = numero;
                    if (numero < min) min = numero;
                }
                else
                {
                    Console.WriteLine("Entrada no válida. Intente de nuevo.");
                }
            } while (true);

            if (contador > 0)
            {
                double promedio = suma / contador;
                Console.WriteLine($"\n--- Estadísticas ---");
                Console.WriteLine($"Valores ingresados: {contador}");
                Console.WriteLine($"Promedio: {promedio:F2}");
                Console.WriteLine($"Valor Máximo: {max}");
                Console.WriteLine($"Valor Mínimo: {min}");
            }
            else
            {
                Console.WriteLine("No se ingresaron números válidos.");
            }
            Console.WriteLine("\nPresione una tecla para continuar...");
            Console.ReadKey();
        }
    }
}