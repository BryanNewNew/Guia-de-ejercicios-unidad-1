using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Guia_de_ejercicios_unidad1.Bloque2
{
    public class Ejercicio18
    {
       public void Ejecutar()
        {
            Console.Clear();
            Console.WriteLine("--- Ejercicio 18: Tarifa de Estacionamiento ---");
            Console.Write("Ingrese las horas estacionado: ");
            if (int.TryParse(Console.ReadLine(), out int horas) && horas > 0)
            {
                decimal total = 20m; // Primera hora cuesta L. 20

                if (horas > 1)
                {
                    total += (horas - 1) * 10m; // Cada hora adicional L. 10
                }

                if (total > 100m)
                {
                    total = 100m; // Tope máximo por día L. 100
                }

                Console.WriteLine($"Total a pagar por {horas} hora(s): L. {total:F2}");
            }
            else
            {
                Console.WriteLine("Error: Debe ingresar una cantidad de horas positiva mayor a 0.");
            }
            Console.WriteLine("\nPresione una tecla para continuar...");
            Console.ReadKey();
        }
    }
}