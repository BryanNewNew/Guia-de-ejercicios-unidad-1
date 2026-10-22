using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Guia_de_ejercicios_unidad1.Bloque1
{
    public class Ejercicio2
    {
//  Calculadora de IMC - Solicitar peso (kg) y altura (m), calcular el índice de masa corporal y
// mostrar en qué categoría se encuentra (bajo peso, normal, sobrepeso, obesidad).
           public void Ejecutar()
        {
            Console.Clear();
            Console.WriteLine("--- Ejercicio 2: Calculadora de IMC ---");
            Console.Write("Ingrese su peso en kg: ");
            if (double.TryParse(Console.ReadLine(), out double peso) && peso > 0)
            {
                Console.Write("Ingrese su altura en metros: ");
                if (double.TryParse(Console.ReadLine(), out double altura) && altura > 0)
                {
                    double imc = peso / (altura * altura);
                    string categoria = imc < 18.5 ? "Bajo peso" : imc < 25 ? "Normal" : imc < 30 ? "Sobrepeso" : "Obesidad";
                    Console.WriteLine($"Tu IMC es: {imc:F2} - Categoría: {categoria}");
                }
                else { Console.WriteLine("Altura inválida."); }
            }
            else { Console.WriteLine("Peso inválido."); }
            Console.WriteLine("\nPresione una tecla para continuar...");
            Console.ReadKey();
        }
        }
    }
    