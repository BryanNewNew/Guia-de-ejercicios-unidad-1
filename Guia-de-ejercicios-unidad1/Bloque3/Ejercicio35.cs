using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Guia_de_ejercicios_unidad1.Bloque3
{
    public class Ejercicio35
    {
        public void Ejecutar()
        {
            Console.Clear();
            Console.WriteLine("--- Ejercicio 35: Patrones en Consola (Pirámide Numérica) ---");
            Console.Write("Ingrese el tamaño del patrón: ");
            if (int.TryParse(Console.ReadLine(), out int n) && n > 0)
            {
                for (int i = 1; i <= n; i++)
                {
                    for (int k = 1; k <= n - i; k++) Console.Write(" ");
                    for (int j = 1; j <= i; j++) Console.Write(j);
                    for (int j = i - 1; j >= 1; j--) Console.Write(j);
                    Console.WriteLine();
                }
            }
            else { Console.WriteLine("Tamaño inválido."); }
            Console.WriteLine("\nPresione una tecla para continuar...");
            Console.ReadKey();
        }
    }
}