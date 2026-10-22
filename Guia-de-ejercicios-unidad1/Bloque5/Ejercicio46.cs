using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Guia_de_ejercicios_unidad1.Bloque5
{
    public class Ejercicio46
    {
        public void Ejecutar()
        {
            List<string> compras = new List<string>();
            int op;

            do
            {
                Console.Clear();
                Console.WriteLine("--- 46. Lista de Compras ---");
                Console.WriteLine("1. Agregar producto (evitando duplicados)");
                Console.WriteLine("2. Eliminar producto");
                Console.WriteLine("3. Buscar producto");
                Console.WriteLine("4. Mostrar lista ordenada alfabéticamente");
                Console.WriteLine("5. Salir");
                Console.Write("Seleccione una opción: ");

                if (int.TryParse(Console.ReadLine(), out op))
                {
                    switch (op)
                    {
                        case 1:
                            Console.Write("Ingrese el nombre del producto: ");
                            string prod = Console.ReadLine() ?? "";
                            if (!string.IsNullOrWhiteSpace(prod))
                            {
                                if (!compras.Contains(prod))
                                {
                                    compras.Add(prod);
                                    Console.WriteLine("¡Producto agregado!");
                                }
                                else
                                {
                                    Console.WriteLine("El producto ya existe en la lista.");
                                }
                            }
                            break;

                        case 2:
                            Console.Write("Ingrese el producto a eliminar: ");
                            string eliminar = Console.ReadLine() ?? "";
                            if (compras.Contains(eliminar))
                            {
                                compras.Remove(eliminar);
                                Console.WriteLine("Producto eliminado.");
                            }
                            else
                            {
                                Console.WriteLine("El producto no está en la lista.");
                            }
                            break;

                        case 3:
                            Console.Write("Ingrese el producto a buscar: ");
                            string buscar = Console.ReadLine() ?? "";
                            if (compras.Contains(buscar))
                                Console.WriteLine($"¡Sí! El producto '{buscar}' está en la lista.");
                            else
                                Console.WriteLine("El producto no se encuentra.");
                            break;

                        case 4:
                            compras.Sort();
                            Console.WriteLine("\n--- Lista de Compras (Orden Alfabético) ---");
                            foreach (var p in compras)
                            {
                                Console.WriteLine($"- {p}");
                            }
                            break;

                        case 5:
                            Console.WriteLine("Saliendo...");
                            break;

                        default:
                            Console.WriteLine("Opción no válida.");
                            break;
                    }
                }
                if (op != 5)
                {
                    Console.WriteLine("\nPresione una tecla para continuar...");
                    Console.ReadKey();
                }
            } while (op != 5);
        }
    }
}