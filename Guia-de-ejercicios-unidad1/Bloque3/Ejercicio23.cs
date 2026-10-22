using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Guia_de_ejercicios_unidad1.Bloque3
{
    public class Ejercicio23
    {
        public void Ejecutar()
        {
            Console.Clear();
            Console.WriteLine("--- Ejercicio 23: Tabla de Multiplicar Extendida ---");
            Console.Write("Ingrese un número para ver su tabla: ");
            if (int.TryParse(Console.ReadLine(), out int n))
            {
                Console.WriteLine($"\nTabla del {n} (del 1 al 12):");
                for (int i = 1; i <= 12; i++)
                {
                    Console.WriteLine($"{n,2} x {i,2} = {n * i,3}");
                }
            }
            else { Console.WriteLine("Número inválido."); }
            Console.WriteLine("\nPresione una tecla para continuar...");
            Console.ReadKey();
        }
    }
}