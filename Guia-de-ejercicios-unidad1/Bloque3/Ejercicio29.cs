using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Guia_de_ejercicios_unidad1.Bloque3
{
    public class Ejercicio29
    {
       public void Ejecutar()
        {
            Console.Clear();
            Console.WriteLine("--- Ejercicio 29: Serie Fibonacci ---");
            Console.Write("Ingrese la cantidad de términos N: ");
            if (int.TryParse(Console.ReadLine(), out int n) && n > 0)
            {
                long a = 0, b = 1, suma = 0;
                Console.Write("Serie: ");

                for (int i = 1; i <= n; i++)
                {
                    Console.Write($"{a} ");
                    suma += a;
                    long temp = a;
                    a = b;
                    b = temp + b;
                }

                double promedio = (double)suma / n;
                Console.WriteLine($"\nSuma total: {suma}");
                Console.WriteLine($"Promedio: {promedio:F2}");
            }
            else { Console.WriteLine("Número inválido."); }
            Console.WriteLine("\nPresione una tecla para continuar...");
            Console.ReadKey();
        }
    }
}