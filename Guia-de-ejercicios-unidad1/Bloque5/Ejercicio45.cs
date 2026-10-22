using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Guia_de_ejercicios_unidad1.Bloque5
{
    public class Ejercicio45
    {
        public void Ejecutar()
        {
            List<string> tareas = new List<string>();
            int op;

            do
            {
                Console.Clear();
                Console.WriteLine("--- 45. Lista de Tareas Pendientes ---");
                Console.WriteLine("1. Agregar tarea");
                Console.WriteLine("2. Mostrar todas las tareas");
                Console.WriteLine("3. Eliminar tarea por número");
                Console.WriteLine("4. Salir");
                Console.Write("Seleccione una opción: ");

                if (int.TryParse(Console.ReadLine(), out op))
                {
                    switch (op)
                    {
                        case 1:
                            Console.Write("Ingrese la nueva tarea: ");
                            string nuevaTarea = Console.ReadLine() ?? "";
                            if (!string.IsNullOrWhiteSpace(nuevaTarea))
                            {
                                tareas.Add(nuevaTarea);
                                Console.WriteLine("¡Tarea agregada con éxito!");
                            }
                            break;

                        case 2:
                            Console.WriteLine("\n--- Tareas Pendientes ({0}) ---", tareas.Count);
                            if (tareas.Count == 0)
                            {
                                Console.WriteLine("No hay tareas registradas.");
                            }
                            else
                            {
                                for (int i = 0; i < tareas.Count; i++)
                                {
                                    Console.WriteLine($"{i + 1}. {tareas[i]}");
                                }
                            }
                            break;

                        case 3:
                            Console.Write("Ingrese el número de la tarea a eliminar: ");
                            if (int.TryParse(Console.ReadLine(), out int index) && index >= 1 && index <= tareas.Count)
                            {
                                tareas.RemoveAt(index - 1);
                                Console.WriteLine("¡Tarea eliminada!");
                            }
                            else
                            {
                                Console.WriteLine("Número de tarea inválido.");
                            }
                            break;

                        case 4:
                            Console.WriteLine("Saliendo del gestor de tareas...");
                            break;

                        default:
                            Console.WriteLine("Opción no válida.");
                            break;
                    }
                }
                if (op != 4)
                {
                    Console.WriteLine("\nPresione una tecla para continuar...");
                    Console.ReadKey();
                }
            } while (op != 4);
        }
    }
}