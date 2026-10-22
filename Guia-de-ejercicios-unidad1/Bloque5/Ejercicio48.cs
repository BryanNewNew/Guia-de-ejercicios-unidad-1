using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Guia_de_ejercicios_unidad1.Bloque5
{
    public class Ejercicio48
    {
        public void Ejecutar()
        {
            Console.Clear();
            Console.WriteLine("--- 48. Números Únicos ---");
            Console.Write("Ingrese la cantidad de números (N) a procesar: ");
            if (int.TryParse(Console.ReadLine(), out int n) && n > 0)
            {
                List<int> listaUnicos = new List<int>();
                int duplicadosDescartados = 0;

                for (int i = 0; i < n; i++)
                {
                    Console.Write($"Ingrese el número {i + 1}: ");
                    int num = int.Parse(Console.ReadLine()!);

                    if (!listaUnicos.Contains(num))
                    {
                        listaUnicos.Add(num);
                    }
                    else
                    {
                        duplicadosDescartados++;
                    }
                }

                Console.WriteLine($"\nLista resultante (sin duplicados): {string.Join(", ", listaUnicos)}");
                Console.WriteLine($"Cantidad de duplicados descartados: {duplicadosDescartados}");
            }
            else
            {
                Console.WriteLine("Número inválido.");
            }

            Console.WriteLine("\nPresione una tecla para continuar...");
            Console.ReadKey();
        }
    }
}