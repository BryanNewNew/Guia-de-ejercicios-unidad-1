using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Guia_de_ejercicios_unidad1.Bloque1
{
    public class Ejercicio5
    {
       public void Ejecutar()
        {
            Console.Clear();
            Console.WriteLine("--- Ejercicio 5: Conversión de Temperatura ---");
            Console.Write("Ingrese temperatura en Celsius: ");
            if (double.TryParse(Console.ReadLine(), out double c))
            {
                double f = (c * 9 / 5) + 32;
                double k = c + 273.15;
                Console.WriteLine($"Fahrenheit: {f:F2}, Kelvin: {k:F2}");
            }
            Console.WriteLine("\nPresione una tecla para continuar...");
            Console.ReadKey();
        }
    }
    }
