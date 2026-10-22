using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Guia_de_ejercicios_unidad1.Bloque2
{
    public class Ejercicio11
    {
       public void Ejecutar()
        {
            Console.Clear();
            Console.WriteLine("--- Ejercicio 11: Positivo, Negativo o Cero ---");
            Console.Write("Ingrese un número entero: ");
            if (int.TryParse(Console.ReadLine(), out int num))
            {
                // Determinar signo
                if (num > 0)
                    Console.WriteLine("El número es POSITIVO.");
                else if (num < 0)
                    Console.WriteLine("El número es NEGATIVO.");
                else
                    Console.WriteLine("El número es CERO.");

                // Determinar si es par o impar con operador ternario
                string paridad = (num % 2 == 0) ? "PAR" : "IMPAR";
                Console.WriteLine($"Además, el número es {paridad}.");
            }
            else
            {
                Console.WriteLine("Error: Entrada inválida.");
            }
            Console.WriteLine("\nPresione una tecla para continuar...");
            Console.ReadKey();
        }
    }
}