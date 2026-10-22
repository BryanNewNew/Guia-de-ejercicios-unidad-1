using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Guia_de_ejercicios_unidad1.Bloque2
{
    public class Ejercicio21
    {
       public void Ejecutar()
        {
            Console.Clear();
            Console.WriteLine("--- Ejercicio 21: Validador de Fecha ---");
            Console.Write("Ingrese el día: ");
            int dia = int.Parse(Console.ReadLine()!);
            Console.Write("Ingrese el mes: ");
            int mes = int.Parse(Console.ReadLine()!);
            Console.Write("Ingrese el año: ");
            int anio = int.Parse(Console.ReadLine()!);

            bool fechaValida = false;

            if (mes >= 1 && mes <= 12)
            {
                int diasEnMes = DateTime.DaysInMonth(anio, mes);
                if (dia >= 1 && dia <= diasEnMes)
                {
                    fechaValida = true;
                }
            }

            if (fechaValida)
                Console.WriteLine($"\nLa fecha {dia:D2}/{mes:D2}/{anio} es una FECHA REAL Y VÁLIDA.");
            else
                Console.WriteLine($"\nLa fecha {dia}/{mes}/{anio} NO es válida.");

            Console.WriteLine("\nPresione una tecla para continuar...");
            Console.ReadKey();
        }
    }
}