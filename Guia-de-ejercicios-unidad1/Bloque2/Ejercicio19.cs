using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Guia_de_ejercicios_unidad1.Bloque2
{
    public class Ejercicio19
    {
       public void Ejecutar()
        {
            Console.Clear();
            Console.WriteLine("--- Ejercicio 19: Clasificación de Triángulos ---");
            Console.Write("Ingrese el lado A: ");
            double a = double.Parse(Console.ReadLine()!);
            Console.Write("Ingrese el lado B: ");
            double b = double.Parse(Console.ReadLine()!);
            Console.Write("Ingrese el lado C: ");
            double c = double.Parse(Console.ReadLine()!);

            // Validación de triángulo
            if (a + b > c && a + c > b && b + c > a)
            {
                Console.WriteLine("\n¡Es un triángulo válido!");

                // Por sus lados
                if (a == b && b == c)
                    Console.WriteLine("Por lados: Equilátero");
                else if (a == b || a == c || b == c)
                    Console.WriteLine("Por lados: Isósceles");
                else
                    Console.WriteLine("Por lados: Escaleno");

                // Por sus ángulos (usando teorema de Pitágoras)
                double[] lados = { a, b, c };
                Array.Sort(lados); // lados[2] es la hipotenusa potencial
                double cat1 = lados[0], cat2 = lados[1], hip = lados[2];

                double sumaCatetos = (cat1 * cat1) + (cat2 * cat2);
                double hipCuadrado = hip * hip;

                if (Math.Abs(sumaCatetos - hipCuadrado) < 0.0001)
                    Console.WriteLine("Por ángulos: Rectángulo");
                else if (sumaCatetos > hipCuadrado)
                    Console.WriteLine("Por ángulos: Acutángulo");
                else
                    Console.WriteLine("Por ángulos: Obtusángulo");
            }
            else
            {
                Console.WriteLine("Los lados ingresados NO forman un triángulo válido.");
            }
            Console.WriteLine("\nPresione una tecla para continuar...");
            Console.ReadKey();
        }
    }
}