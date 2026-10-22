using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Guia_de_ejercicios_unidad1.Bloque1
{
    public class Ejercicio10
    {
       public void Ejecutar()
        {
            Console.Clear();
            Console.WriteLine("--- Ejercicio 10: Calculadora de préstamo simple ---");
            Console.Write("Ingrese el monto del préstamo (L.): ");
            if (double.TryParse(Console.ReadLine(), out double monto) && monto > 0)
            {
                Console.Write("Ingrese la tasa de interés anual (%): ");
                if (double.TryParse(Console.ReadLine(), out double tasaAnual) && tasaAnual >= 0)
                {
                    Console.Write("Ingrese el plazo en meses: ");
                    if (int.TryParse(Console.ReadLine(), out int meses) && meses > 0)
                    {
                        double interesTotal = monto * (tasaAnual / 100.0) * (meses / 12.0);
                        double totalAPagar = monto + interesTotal;
                        double cuotaMensual = totalAPagar / meses;

                        Console.WriteLine("\n--- Resumen del Préstamo ---");
                        Console.WriteLine($"Interés Total: L. {interesTotal:F2}");
                        Console.WriteLine($"Total a Pagar: L. {totalAPagar:F2}");
                        Console.WriteLine($"Cuota Mensual Fija: L. {cuotaMensual:F2}");
                    }
                    else { Console.WriteLine("Plazo inválido."); }
                }
                else { Console.WriteLine("Tasa inválida."); }
            }
            else { Console.WriteLine("Monto inválido."); }
            Console.WriteLine("\nPresione una tecla para continuar...");
            Console.ReadKey();
        }
    }
}