using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Guia_de_ejercicios_unidad1.Bloque3
{
    public class Ejercicio30
    {
       public void Ejecutar()
        {
            Console.Clear();
            Console.WriteLine("--- Ejercicio 30: Factorial y Combinaciones C(n,r) ---");
            Console.Write("Ingrese N: ");
            if (int.TryParse(Console.ReadLine(), out int n) && n >= 0)
            {
                Console.Write("Ingrese R (r <= n): ");
                if (int.TryParse(Console.ReadLine(), out int r) && r >= 0 && r <= n)
                {
                    long facN = CalcularFactorial(n);
                    long facR = CalcularFactorial(r);
                    long facNR = CalcularFactorial(n - r);

                    long combinacion = facN / (facR * facNR);

                    Console.WriteLine($"Factorial de {n} = {facN}");
                    Console.WriteLine($"Combinación C({n},{r}) = {combinacion}");
                }
                else { Console.WriteLine("R inválido."); }
            }
            else { Console.WriteLine("N inválido."); }
            Console.WriteLine("\nPresione una tecla para continuar...");
            Console.ReadKey();
        }

        private long CalcularFactorial(int num)
        {
            long f = 1;
            for (int i = 1; i <= num; i++) f *= i;
            return f;
        }
    }
}