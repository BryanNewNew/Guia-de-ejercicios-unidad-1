using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Guia_de_ejercicios_unidad1.Bloque1
{
    public class Ejercicio4
    {
        public void Ejecutar()
        {
            Console.Clear();
            Console.WriteLine("--- Ejercicio 4: Área y Perímetro ---");
            Console.WriteLine("1. Círculo\n2. Triángulo\n3. Rectángulo\n4. Trapecio");
            Console.Write("Seleccione una opción: ");
            if (int.TryParse(Console.ReadLine(), out int op))
            {
                switch (op)
                {
                    case 1:
                        Console.Write("Radio: ");
                        if (double.TryParse(Console.ReadLine(), out double r) && r > 0)
                            Console.WriteLine($"Área: {Math.PI * r * r:F2}, Perímetro: {2 * Math.PI * r:F2}");
                        break;
                    case 2:
                        Console.Write("Base: "); double b = double.Parse(Console.ReadLine()!);
                        Console.Write("Altura: "); double h = double.Parse(Console.ReadLine()!);
                        Console.Write("Lado 1: "); double l1 = double.Parse(Console.ReadLine()!);
                        Console.Write("Lado 2: "); double l2 = double.Parse(Console.ReadLine()!);
                        Console.Write("Lado 3: "); double l3 = double.Parse(Console.ReadLine()!);
                        if (b > 0 && h > 0 && l1 > 0 && l2 > 0 && l3 > 0)
                            Console.WriteLine($"Área: {(b * h) / 2:F2}, Perímetro: {l1 + l2 + l3}");
                        break;
                    case 3:
                        Console.Write("Base: "); double baseR = double.Parse(Console.ReadLine()!);
                        Console.Write("Altura: "); double altR = double.Parse(Console.ReadLine()!);
                        if (baseR > 0 && altR > 0)
                            Console.WriteLine($"Área: {baseR * altR}, Perímetro: {2 * (baseR + altR)}");
                        break;
                    default:
                        Console.WriteLine("Opción no válida.");
                        break;
                }
            }
            Console.WriteLine("\nPresione una tecla para continuar...");
            Console.ReadKey();
        }
    }
    }
