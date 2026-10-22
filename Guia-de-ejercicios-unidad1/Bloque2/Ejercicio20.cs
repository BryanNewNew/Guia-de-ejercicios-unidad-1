using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Guia_de_ejercicios_unidad1.Bloque2
{
    public class Ejercicio20
    {
       public void Ejecutar()
        {
            Console.Clear();
            Console.WriteLine("--- Ejercicio 20: Año Bisiesto y Días del Mes ---");
            Console.Write("Ingrese el año: ");
            int anio = int.Parse(Console.ReadLine()!);
            Console.Write("Ingrese el mes (1-12): ");
            int mes = int.Parse(Console.ReadLine()!);

            if (mes >= 1 && mes <= 12)
            {
                bool esBisiesto = (anio % 4 == 0 && anio % 100 != 0) || (anio % 400 == 0);
                int dias = DateTime.DaysInMonth(anio, mes);

                Console.WriteLine($"\nEl año {anio} {(esBisiesto ? "SÍ" : "NO")} es bisiesto.");
                Console.WriteLine($"El mes {mes} tiene {dias} días.");
            }
            else
            {
                Console.WriteLine("Error: Mes fuera de rango.");
            }
            Console.WriteLine("\nPresione una tecla para continuar...");
            Console.ReadKey();
        }
    }
}