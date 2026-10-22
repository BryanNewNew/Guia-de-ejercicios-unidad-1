using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Guia_de_ejercicios_unidad1.Bloque3
{
    public class Ejercicio28
    {
       public void Ejecutar()
        {
            Console.Clear();
            Console.WriteLine("--- Ejercicio 28: Decimal a Binario ---");
            Console.Write("Ingrese un número entero positivo: ");
            if (int.TryParse(Console.ReadLine(), out int n) && n >= 0)
            {
                if (n == 0)
                {
                    Console.WriteLine("Binario: 0");
                    return;
                }

                string binario = "";
                int temp = n;

                while (temp > 0)
                {
                    int residuo = temp % 2;
                    binario = residuo + binario;
                    temp /= 2;
                }

                Console.WriteLine($"El número {n} en binario es: {binario}");
            }
            else { Console.WriteLine("Número inválido."); }
            Console.WriteLine("\nPresione una tecla para continuar...");
            Console.ReadKey();
        }
    }
}