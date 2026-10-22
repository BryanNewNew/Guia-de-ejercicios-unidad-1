using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Guia_de_ejercicios_unidad1.Bloque1
{
    public class Ejercicio8
    {
       public void Ejecutar()
        {
            Console.Clear();
            Console.WriteLine("--- Ejercicio 8: Desglose de billetes ---");
            Console.Write("Ingrese un monto en lempiras: ");
            if (int.TryParse(Console.ReadLine(), out int monto) && monto > 0)
            {
                int[] billetes = { 500, 100, 50, 20, 10, 5, 2, 1 };
                Console.WriteLine("\nDesglose:");
                foreach (var b in billetes)
                {
                    int cantidad = monto / b;
                    monto %= b;
                    Console.WriteLine($"Billetes de L. {b}: {cantidad}");
                }
            }
            else
            {
                Console.WriteLine("Error: Monto inválido.");
            }
            Console.WriteLine("\nPresione una tecla para continuar...");
            Console.ReadKey();
        }
    }
}