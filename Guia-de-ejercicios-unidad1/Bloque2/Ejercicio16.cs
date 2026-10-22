using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Guia_de_ejercicios_unidad1.Bloque2
{
    public class Ejercicio16
    {
       public void Ejecutar()
        {
            Console.Clear();
            Console.WriteLine("--- Ejercicio 16: Calificaciones UNAH ---");
            Console.Write("Ingrese la nota (0 - 100): ");
            if (int.TryParse(Console.ReadLine(), out int nota) && nota >= 0 && nota <= 100)
            {
                char letra;
                string descripcion;
                bool aprobo = nota >= 65; // Criterio de aprobación UNAH

                if (nota >= 90) { letra = 'A'; descripcion = "Excelente"; }
                else if (nota >= 80) { letra = 'B'; descripcion = "Muy Bueno"; }
                else if (nota >= 70) { letra = 'C'; descripcion = "Bueno"; }
                else if (nota >= 65) { letra = 'D'; descripcion = "Suficiente"; }
                else { letra = 'F'; descripcion = "Insuficiente"; }

                Console.WriteLine($"\nLetra: {letra}");
                Console.WriteLine($"Descripción: {descripcion}");
                Console.WriteLine($"Estado: {(aprobo ? "APROBADO" : "REPROBADO")}");
            }
            else
            {
                Console.WriteLine("Error: La nota debe ser un número entero entre 0 y 100.");
            }
            Console.WriteLine("\nPresione una tecla para continuar...");
            Console.ReadKey();
        }
    }
}