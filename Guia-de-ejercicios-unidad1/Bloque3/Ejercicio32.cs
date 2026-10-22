using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Guia_de_ejercicios_unidad1.Bloque3
{
    public class Ejercicio32
    {
           public void Ejecutar()
        {
            Console.Clear();
            Console.WriteLine("--- Ejercicio 32: Números Primos en Rango ---");
            Console.Write("Ingrese el inicio del rango: ");
            if (int.TryParse(Console.ReadLine(), out int inicio))
            {
                Console.Write("Ingrese el fin del rango: ");
                if (int.TryParse(Console.ReadLine(), out int fin) && fin >= inicio)
                {
                    int contadorPrimos = 0;
                    Console.Write("Números primos encontrados: ");

                    for (int i = inicio; i <= fin; i++)
                    {
                        if (i < 2) continue;
                        bool esPrimo = true;
                        for (int j = 2; j <= Math.Sqrt(i); j++)
                        {
                            if (i % j == 0)
                            {
                                esPrimo = false;
                                break;
                            }
                        }
                        if (esPrimo)
                        {
                            Console.Write($"{i} ");
                            contadorPrimos++;
                        }
                    }

                    Console.WriteLine($"\nTotal de números primos encontrados: {contadorPrimos}");
                }
                else { Console.WriteLine("Rango inválido."); }
            }
            else { Console.WriteLine("Inicio inválido."); }
            Console.WriteLine("\nPresione una tecla para continuar...");
            Console.ReadKey();
        }
        }
    }