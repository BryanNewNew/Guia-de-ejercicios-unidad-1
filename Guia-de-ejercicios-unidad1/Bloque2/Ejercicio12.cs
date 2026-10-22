using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Guia_de_ejercicios_unidad1.Bloque2
{
    public class Ejercicio12
    {
       public void Ejecutar()
        {
            Console.Clear();
            Console.WriteLine("--- Ejercicio 12: Mayor y Menor de Tres Números ---");
            Console.Write("Ingrese el primer número: ");
            int n1 = int.Parse(Console.ReadLine()!);
            Console.Write("Ingrese el segundo número: ");
            int n2 = int.Parse(Console.ReadLine()!);
            Console.Write("Ingrese el tercer número: ");
            int n3 = int.Parse(Console.ReadLine()!);

            int mayor, menor;

            // Determinar mayor usando &&
            if (n1 >= n2 && n1 >= n3) mayor = n1;
            else if (n2 >= n1 && n2 >= n3) mayor = n2;
            else mayor = n3;

            // Determinar menor
            if (n1 <= n2 && n1 <= n3) menor = n1;
            else if (n2 <= n1 && n2 <= n3) menor = n2;
            else menor = n3;

            Console.WriteLine($"\nEl número MAYOR es: {mayor}");
            Console.WriteLine($"El número MENOR es: {menor}");
            Console.WriteLine("\nPresione una tecla para continuar...");
            Console.ReadKey();
        }
    }
}