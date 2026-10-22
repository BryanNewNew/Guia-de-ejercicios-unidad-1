using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Guia_de_ejercicios_unidad1.Bloque3
{
    public class Ejercicio27
    {
       public void Ejecutar()
        {
            Console.Clear();
            Console.WriteLine("--- Ejercicio 27: Inversión de Número y Palíndromo ---");
            Console.Write("Ingrese un número entero positivo: ");
            if (int.TryParse(Console.ReadLine(), out int n) && n >= 0)
            {
                int original = n;
                int invertido = 0;

                while (n > 0)
                {
                    int digito = n % 10;
                    invertido = invertido * 10 + digito;
                    n /= 10;
                }

                Console.WriteLine($"Número invertido: {invertido}");
                if (original == invertido)
                    Console.WriteLine("¡El número SÍ es palíndromo (capicúa)!");
                else
                    Console.WriteLine("El número NO es palíndromo.");
            }
            else { Console.WriteLine("Número inválido."); }
            Console.WriteLine("\nPresione una tecla para continuar...");
            Console.ReadKey();
        }
    }
}