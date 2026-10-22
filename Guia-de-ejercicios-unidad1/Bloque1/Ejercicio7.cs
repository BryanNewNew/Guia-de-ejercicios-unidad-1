using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Guia_de_ejercicios_unidad1.Bloque1
{
    public class Ejercicio7
    {
        public void Ejecutar()
        {
            Console.Clear();
            Console.WriteLine("--- Ejercicio 7: Tiempo transcurrido ---");
            // Usando valores de prueba o solicitud por consola
            int h1 = 10, m1 = 30, s1 = 15;
            int h2 = 14, m2 = 45, s2 = 50;

            Console.WriteLine($"Hora inicial: {h1:D2}:{m1:D2}:{s1:D2}");
            Console.WriteLine($"Hora final: {h2:D2}:{m2:D2}:{s2:D2}");

            int totalSeg1 = h1 * 3600 + m1 * 60 + s1;
            int totalSeg2 = h2 * 3600 + m2 * 60 + s2;
            int diff = Math.Abs(totalSeg2 - totalSeg1);

            int h = diff / 3600;
            int m = (diff % 3600) / 60;
            int s = diff % 60;

            Console.WriteLine($"Tiempo transcurrido: {h} horas, {m} minutos y {s} segundos.");
            Console.WriteLine("\nPresione una tecla para continuar...");
            Console.ReadKey();
        }
    }
}