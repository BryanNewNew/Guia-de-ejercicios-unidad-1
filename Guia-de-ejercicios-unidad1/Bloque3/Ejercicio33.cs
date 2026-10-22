using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Guia_de_ejercicios_unidad1.Bloque3
{
    public class Ejercicio33
    {
        public void Ejecutar()
        {
            Console.Clear();
            Console.WriteLine("--- Ejercicio 33: Juego de Adivinanza (1 al 100) ---");
            Random rnd = new Random();
            int secreto = rnd.Next(1, 101);
            int intentosMax = 7;
            bool ganado = false;

            for (int intento = 1; intento <= intentosMax; intento++)
            {
                Console.Write($"Intento {intento}/{intentosMax} - Ingrese un número: ");
                if (int.TryParse(Console.ReadLine(), out int num))
                {
                    if (num == secreto)
                    {
                        Console.WriteLine($"¡Felicidades! Adivinaste el número en el intento {intento}.");
                        ganado = true;
                        break;
                    }
                    else if (num < secreto)
                    {
                        Console.WriteLine("El número secreto es MAYOR.");
                    }
                    else
                    {
                        Console.WriteLine("El número secreto es MENOR.");
                    }
                }
                else
                {
                    Console.WriteLine("Entrada inválida. Pierdes este intento.");
                }
            }

            if (!ganado)
            {
                Console.WriteLine($"\n¡Te quedaste sin intentos! El número secreto era: {secreto}");
            }
            Console.WriteLine("\nPresione una tecla para continuar...");
            Console.ReadKey();
        }
    }
}