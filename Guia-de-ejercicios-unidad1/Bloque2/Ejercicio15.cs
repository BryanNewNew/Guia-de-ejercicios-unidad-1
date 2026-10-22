using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Guia_de_ejercicios_unidad1.Bloque2
{
    public class Ejercicio15
    {
      public void Ejecutar()
        {
            Console.Clear();
            Console.WriteLine("--- Ejercicio 15: Vocal o Consonante ---");
            Console.Write("Ingrese un carácter: ");
            string entrada = Console.ReadLine()!;

            if (!string.IsNullOrEmpty(entrada) && char.IsLetter(entrada[0]))
            {
                char letra = char.ToLower(entrada[0]);
                switch (letra)
                {
                    case 'a':
                    case 'e':
                    case 'i':
                    case 'o':
                    case 'u':
                        Console.WriteLine($"La letra '{entrada[0]}' es una VOCAL.");
                        break;
                    default:
                        Console.WriteLine($"La letra '{entrada[0]}' es una CONSONANTE.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Error: El carácter ingresado no es una letra válida.");
            }
            Console.WriteLine("\nPresione una tecla para continuar...");
            Console.ReadKey();
        }
    }
}