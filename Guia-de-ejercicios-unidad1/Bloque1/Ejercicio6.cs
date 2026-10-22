using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Guia_de_ejercicios_unidad1.Bloque1
{
    public class Ejercicio6
    {
       public void Ejecutar()
        {
            Console.Clear();
            Console.WriteLine("--- Ejercicio 6: Suma de dígitos ---");
            Console.Write("Ingrese un número entero positivo de tres dígitos: ");
            if (int.TryParse(Console.ReadLine(), out int num) && num >= 100 && num <= 999)
            {
                int centenas = num / 100;
                int decenas = (num / 10) % 10;
                int unidades = num % 10;
                int suma = centenas + decenas + unidades;
                Console.WriteLine($"La suma de los dígitos de {num} es: {suma}");
            }
            else
            {
                Console.WriteLine("Error: Debe ingresar un número válido de tres dígitos.");
            }
            Console.WriteLine("\nPresione una tecla para continuar...");
            Console.ReadKey();
        }
    }
}