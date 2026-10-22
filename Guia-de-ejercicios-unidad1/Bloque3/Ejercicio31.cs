using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Guia_de_ejercicios_unidad1.Bloque3
{
    public class Ejercicio31
    {
       public void Ejecutar()
        {
            Console.Clear();
            Console.WriteLine("--- Ejercicio 31: MCD y MCM ---");
            Console.Write("Ingrese el primer número: ");
            if (int.TryParse(Console.ReadLine(), out int a) && a > 0)
            {
                Console.Write("Ingrese el segundo número: ");
                if (int.TryParse(Console.ReadLine(), out int b) && b > 0)
                {
                    int x = a, y = b;
                    while (y != 0)
                    {
                        int temp = y;
                        y = x % y;
                        x = temp;
                    }
                    int mcd = x;
                    int mcm = (a * b) / mcd;

                    Console.WriteLine($"\nMáximo Común Divisor (MCD): {mcd}");
                    Console.WriteLine($"Mínimo Común Múltiplo (MCM): {mcm}");
                }
                else { Console.WriteLine("Segundo número inválido."); }
            }
            else { Console.WriteLine("Primer número inválido."); }
            Console.WriteLine("\nPresione una tecla para continuar...");
            Console.ReadKey();
        }
    }
}