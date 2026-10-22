using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Guia_de_ejercicios_unidad1.Bloque1
{
    public class Ejercicio9
    {
       public void Ejecutar()
        {
            Console.Clear();
            Console.WriteLine("--- Ejercicio 9: Cálculo de salario semanal ---");
            Console.Write("Ingrese las horas trabajadas en la semana: ");
            if (double.TryParse(Console.ReadLine(), out double horas) && horas >= 0)
            {
                Console.Write("Ingrese la tarifa por hora (L.): ");
                if (double.TryParse(Console.ReadLine(), out double tarifa) && tarifa >= 0)
                {
                    double horasNormales = Math.Min(horas, 44);
                    double horasExtras = Math.Max(0, horas - 44);

                    double pagoNormal = horasNormales * tarifa;
                    double pagoExtra = horasExtras * (tarifa * 1.5);
                    double salarioTotal = pagoNormal + pagoExtra;

                    Console.WriteLine("\n--- Desglose de Salario ---");
                    Console.WriteLine($"Horas normales (hasta 44): {horasNormales} - Pago: L. {pagoNormal:F2}");
                    Console.WriteLine($"Horas extras (150%): {horasExtras} - Pago: L. {pagoExtra:F2}");
                    Console.WriteLine($"Salario Total Semanal: L. {salarioTotal:F2}");
                }
                else { Console.WriteLine("Tarifa inválida."); }
            }
            else { Console.WriteLine("Horas inválidas."); }
            Console.WriteLine("\nPresione una tecla para continuar...");
            Console.ReadKey();
        }
    }
}