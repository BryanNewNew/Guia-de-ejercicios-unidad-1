using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Guia_de_ejercicios_unidad1.Bloque2
{
    public class Ejercicio13
    {
      public void Ejecutar()
        {
            Console.Clear();
            Console.WriteLine("--- Ejercicio 13: Día de la Semana ---");
            Console.Write("Ingrese un número del 1 al 7: ");
            if (int.TryParse(Console.ReadLine(), out int dia) && dia >= 1 && dia <= 7)
            {
                // 1. Switch Clásico
                Console.Write("Resultado con Switch Clásico: ");
                switch (dia)
                {
                    case 1: Console.WriteLine("Lunes"); break;
                    case 2: Console.WriteLine("Martes"); break;
                    case 3: Console.WriteLine("Miércoles"); break;
                    case 4: Console.WriteLine("Jueves"); break;
                    case 5: Console.WriteLine("Viernes"); break;
                    case 6: Console.WriteLine("Sábado"); break;
                    case 7: Console.WriteLine("Domingo"); break;
                }

                // 2. Expresión Switch
                string nombreDia = dia switch
                {
                    1 => "Lunes",
                    2 => "Martes",
                    3 => "Miércoles",
                    4 => "Jueves",
                    5 => "Viernes",
                    6 => "Sábado",
                    7 => "Domingo",
                    _ => "Invalido"
                };
                Console.WriteLine($"Resultado con Expresión Switch: {nombreDia}");
            }
            else
            {
                Console.WriteLine("Error: Número fuera de rango (debe ser 1-7).");
            }
            Console.WriteLine("\nPresione una tecla para continuar...");
            Console.ReadKey();
        }
    }
}