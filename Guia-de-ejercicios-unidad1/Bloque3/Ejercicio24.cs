using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Guia_de_ejercicios_unidad1.Bloque3
{
    public class Ejercicio24
    {
       public void Ejecutar()
        {
            Console.Clear();
            Console.WriteLine("--- Ejercicio 24: Suma de Pares e Impares ---");
            Console.Write("Ingrese un número límite N: ");
            if (int.TryParse(Console.ReadLine(), out int n) && n > 0)
            {
                int sumaPares = 0, cantPares = 0;
                int sumaImpares = 0, cantImpares = 0;

                for (int i = 1; i <= n; i++)
                {
                    if (i % 2 == 0)
                    {
                        sumaPares += i;
                        cantPares++;
                    }
                    else
                    {
                        sumaImpares += i;
                        cantImpares++;
                    }
                }

                Console.WriteLine($"\nResultados del 1 al {n}:");
                Console.WriteLine($"Cantidad de números pares: {cantPares} - Suma: {sumaPares}");
                Console.WriteLine($"Cantidad de números impares: {cantImpares} - Suma: {sumaImpares}");
            }
            else { Console.WriteLine("Ingrese un número válido mayor a 0."); }
            Console.WriteLine("\nPresione una tecla para continuar...");
            Console.ReadKey();
        }
    }
}