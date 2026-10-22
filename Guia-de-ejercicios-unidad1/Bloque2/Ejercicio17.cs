using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Guia_de_ejercicios_unidad1.Bloque2
{
    public class Ejercicio17
    {
        public void Ejecutar()
        {
            Console.Clear();
            Console.WriteLine("--- Ejercicio 17: Calculadora de Descuentos ---");
            Console.Write("Ingrese el monto total de la compra (L.): ");
            if (decimal.TryParse(Console.ReadLine(), out decimal compra) && compra >= 0)
            {
                decimal porcentajeDesc = 0m;

                if (compra >= 2500m)
                    porcentajeDesc = 0.15m; // 15%
                else if (compra >= 1000m)
                    porcentajeDesc = 0.10m; // 10%
                else if (compra >= 500m)
                    porcentajeDesc = 0.05m;  // 5%

                decimal descuento = compra * porcentajeDesc;
                decimal totalFinal = compra - descuento;

                Console.WriteLine($"\nPrecio Original: L. {compra:F2}");
                Console.WriteLine($"Descuento Aplicado ({porcentajeDesc * 100}%): L. {descuento:F2}");
                Console.WriteLine($"Precio Final a Pagar: L. {totalFinal:F2}");
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