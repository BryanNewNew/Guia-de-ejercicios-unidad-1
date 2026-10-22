using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Guia_de_ejercicios_unidad1.Bloque2
{
    public class Ejercicio14
    {
       public void Ejecutar()
        {
            Console.Clear();
            Console.WriteLine("--- Ejercicio 14: Calculadora con Switch ---");
            Console.Write("Ingrese el primer número: ");
            double num1 = double.Parse(Console.ReadLine()!);
            Console.Write("Ingrese el operador (+, -, *, /, %): ");
            char op = Console.ReadLine()![0];
            Console.Write("Ingrese el segundo número: ");
            double num2 = double.Parse(Console.ReadLine()!);

            switch (op)
            {
                case '+':
                    Console.WriteLine($"Resultado: {num1} + {num2} = {num1 + num2}");
                    break;
                case '-':
                    Console.WriteLine($"Resultado: {num1} - {num2} = {num1 - num2}");
                    break;
                case '*':
                    Console.WriteLine($"Resultado: {num1} * {num2} = {num1 * num2}");
                    break;
                case '/':
                    if (num2 != 0)
                        Console.WriteLine($"Resultado: {num1} / {num2} = {num1 / num2}");
                    else
                        Console.WriteLine("Error: No se puede dividir entre cero.");
                    break;
                case '%':
                    if (num2 != 0)
                        Console.WriteLine($"Resultado: {num1} % {num2} = {num1 % num2}");
                    else
                        Console.WriteLine("Error: No se puede calcular el módulo entre cero.");
                    break;
                default:
                    Console.WriteLine("Operador no válido.");
                    break;
            }
            Console.WriteLine("\nPresione una tecla para continuar...");
            Console.ReadKey();
        }
    }
}