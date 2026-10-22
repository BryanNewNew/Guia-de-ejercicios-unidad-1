using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Guia_de_ejercicios_unidad1.Bloque3
{
    public class Ejercicio26
    {
       public void Ejecutar()
        {
            Console.Clear();
            Console.WriteLine("--- Ejercicio 26: Potencia con Ciclo (Sin Math.Pow) ---");
            Console.Write("Ingrese la base: ");
            if (double.TryParse(Console.ReadLine(), out double baseNum))
            {
                Console.Write("Ingrese el exponente (entero): ");
                if (int.TryParse(Console.ReadLine(), out int exp))
                {
                    double resultado = 1;

                    if (exp == 0)
                    {
                        resultado = 1;
                    }
                    else if (exp > 0)
                    {
                        for (int i = 0; i < exp; i++) resultado *= baseNum;
                    }
                    else
                    {
                        for (int i = 0; i < Math.Abs(exp); i++) resultado *= baseNum;
                        resultado = 1 / resultado;
                    }

                    Console.WriteLine($"\nResultado de {baseNum}^{exp} = {resultado}");
                }
                else { Console.WriteLine("Exponente inválido."); }
            }
            else { Console.WriteLine("Base inválida."); }
            Console.WriteLine("\nPresione una tecla para continuar...");
            Console.ReadKey();
        }
    }
}