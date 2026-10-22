using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Guia_de_ejercicios_unidad1.Bloque5
{
    public class Ejercicio50
    {
        public void Ejecutar()
        {
            List<string> nombres = new List<string>();
            List<double> promedios = new List<double>();
            int op;

            do
            {
                Console.Clear();
                Console.WriteLine("--- 50. Registro de Estudiantes (Listas Paralelas) ---");
                Console.WriteLine("1. Agregar estudiante");
                Console.WriteLine("2. Buscar estudiante por nombre");
                Console.WriteLine("3. Mostrar estudiante con mejor promedio");
                Console.WriteLine("4. Ver listado general");
                Console.WriteLine("5. Salir");
                Console.Write("Seleccione una opción: ");

                if (int.TryParse(Console.ReadLine(), out op))
                {
                    switch (op)
                    {
                        case 1:
                            Console.Write("Ingrese el nombre del estudiante: ");
                            string nom = Console.ReadLine() ?? "";
                            Console.Write("Ingrese el promedio (0-100): ");
                            if (double.TryParse(Console.ReadLine(), out double prom) && prom >= 0 && prom <= 100)
                            {
                                nombres.Add(nom);
                                promedios.Add(prom);
                                Console.WriteLine("¡Estudiante registrado con éxito!");
                            }
                            else
                            {
                                Console.WriteLine("Promedio inválido.");
                            }
                            break;

                        case 2:
                            Console.Write("Ingrese el nombre a buscar: ");
                            string busqueda = Console.ReadLine() ?? "";
                            int index = nombres.FindIndex(n => n.Equals(busqueda, StringComparison.OrdinalIgnoreCase));
                            if (index != -1)
                            {
                                Console.WriteLine($"\n¡Encontrado!\nEstudiante: {nombres[index]} - Promedio: {promedios[index]}");
                            }
                            else
                            {
                                Console.WriteLine("Estudiante no encontrado.");
                            }
                            break;

                        case 3:
                            if (nombres.Count > 0)
                            {
                                double maxProm = promedios[0];
                                int maxIndex = 0;
                                for (int i = 1; i < promedios.Count; i++)
                                {
                                    if (promedios[i] > maxProm)
                                    {
                                        maxProm = promedios[i];
                                        maxIndex = i;
                                    }
                                }
                                Console.WriteLine($"\nEstudiante con mejor promedio:\nNombre: {nombres[maxIndex]} - Promedio: {promedios[maxIndex]}");
                            }
                            else
                            {
                                Console.WriteLine("No hay estudiantes registrados.");
                            }
                            break;

                        case 4:
                            Console.WriteLine("\n--- Listado General de Estudiantes ---");
                            if (nombres.Count == 0)
                            {
                                Console.WriteLine("La lista está vacía.");
                            }
                            else
                            {
                                for (int i = 0; i < nombres.Count; i++)
                                {
                                    Console.WriteLine($"{i + 1}. {nombres[i]} - Promedio: {promedios[i]}");
                                }
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