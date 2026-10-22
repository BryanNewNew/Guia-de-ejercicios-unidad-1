using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Guia_de_ejercicios_unidad1.Bloque1
{
    public class Ejercicio3
    {
        public void Ejecutar()
        {
            Console.Clear();
            Console.WriteLine("--- Ejercicio 3: Intercambio de valores ---");
            int a = 10, b = 20;
            Console.WriteLine($"Antes (Temporal): a = {a}, b = {b}");
            int temp = a; a = b; b = temp;
            Console.WriteLine($"Después (Temporal): a = {a}, b = {b}");

            int x = 5, y = 15;
            Console.WriteLine($"Antes (Aritmético): x = {x}, y = {y}");
            x = x + y; y = x - y; x = x - y;
            Console.WriteLine($"Después (Aritmético): x = {x}, y = {y}");
            Console.WriteLine("\nPresione una tecla para continuar...");
            Console.ReadKey();
        }
    }
}