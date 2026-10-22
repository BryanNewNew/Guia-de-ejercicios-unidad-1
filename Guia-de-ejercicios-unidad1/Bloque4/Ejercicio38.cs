using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Guia_de_ejercicios_unidad1.Bloque4
{
    public class Ejercicio38
    {
        public void Ejecutar()
        {
            Console.Clear();
            Console.WriteLine("--- 38. Arreglo de nombres ---");
            string[] nombres = new string[5];

            for (int i = 0; i < 5; i++)
            {
                Console.Write($"Ingrese el nombre {i + 1}: ");
                nombres[i] = Console.ReadLine() ?? "";
            }

            // Mostrar en orden inverso
            Array.Reverse(nombres);
            Console.WriteLine("\nNombres en orden inverso:");
            foreach (var nombre in nombres)
            {
                Console.WriteLine($"- {nombre}");
            }
            // Restaurar orden original para buscar y evaluar
            Array.Reverse(nombres);

            // Nombre más largo
            string masLargo = nombres.OrderByDescending(n => n.Length).First();
            Console.WriteLine($"\nEl nombre más largo es: {masLargo}");

            // Buscar un nombre
            Console.Write("\nIngrese un nombre a buscar en el arreglo: ");
            string busqueda = Console.ReadLine() ?? "";
            bool encontrado = Array.Exists(nombres, n => n.Equals(busqueda, StringComparison.OrdinalIgnoreCase));

            if (encontrado)
                Console.WriteLine($"¡El nombre '{busqueda}' SÍ se encuentra en el arreglo!");
            else
                Console.WriteLine($"El nombre '{busqueda}' NO fue encontrado.");

            Console.WriteLine("\nPresione una tecla para continuar...");
            Console.ReadKey();
        }
    }
}