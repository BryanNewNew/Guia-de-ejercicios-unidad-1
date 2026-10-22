using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Guia_de_ejercicios_unidad1.Bloque2
{
    public class Ejercicio22
    {
      public void Ejecutar()
        {
            Console.Clear();
            Console.WriteLine("--- Ejercicio 22: Cajero Automático ---");
            decimal saldo = 5000m; // Saldo inicial simulado
            Console.WriteLine($"Saldo disponible: L. {saldo:F2}");
            Console.Write("Ingrese el monto a retirar (debe ser múltiplo de 20): ");

            if (int.TryParse(Console.ReadLine(), out int retiro) && retiro > 0)
            {
                if (retiro % 20 != 0)
                {
                    Console.WriteLine("Error: El monto a retirar debe ser múltiplo de L. 20.");
                }
                else if (retiro > saldo)
                {
                    Console.WriteLine("Error: Fondos insuficientes.");
                }
                else
                {
                    saldo -= retiro;
                    Console.WriteLine("\nRetiro procesado con éxito.");
                    Console.WriteLine("Desglose de billetes entregados:");

                    int[] billetes = { 500, 100, 50, 20 };
                    int montoRestante = retiro;

                    foreach (int b in billetes)
                    {
                        int cant = montoRestante / b;
                        montoRestante %= b;
                        if (cant > 0)
                        {
                            Console.WriteLine($" - {cant} billete(s) de L. {b}");
                        }
                    }

                    Console.WriteLine($"\nSaldo restante: L. {saldo:F2}");
                }
            }
            else
            {
                Console.WriteLine("Monto inválido.");
            }
            Console.WriteLine("\nPresione una tecla para continuar...");
            Console.ReadKey();
        }
    }
}