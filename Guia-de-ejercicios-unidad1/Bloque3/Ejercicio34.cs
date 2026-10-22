using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Guia_de_ejercicios_unidad1.Bloque3
{
    public class Ejercicio34
    {
        public void Ejecutar()
        {
            Console.Clear();
            Console.WriteLine("--- Ejercicio 34: Validación de Contraseña ---");
            string pass;
            bool cumple = false;

            do
            {
                Console.Write("Ingrese contraseña (mín 8 chars, 1 Mayús, 1 Minús, 1 Num, 1 Especial): ");
                pass = Console.ReadLine() ?? "";

                bool largo = pass.Length >= 8;
                bool mayus = pass.Any(char.IsUpper);
                bool minus = pass.Any(char.IsLower);
                bool num = pass.Any(char.IsDigit);
                bool especial = pass.Any(ch => !char.IsLetterOrDigit(ch));

                if (largo && mayus && minus && num && especial)
                {
                    Console.WriteLine("¡Contraseña válida y segura!");
                    cumple = true;
                }
                else
                {
                    Console.WriteLine("Contraseña inválida. Falta:");
                    if (!largo) Console.WriteLine("- Al menos 8 caracteres.");
                    if (!mayus) Console.WriteLine("- Al menos una letra mayúscula.");
                    if (!minus) Console.WriteLine("- Al menos una letra minúscula.");
                    if (!num) Console.WriteLine("- Al menos un número.");
                    if (!especial) Console.WriteLine("- Al menos un carácter especial.");
                    Console.WriteLine("Intente de nuevo.\n");
                }
            } while (!cumple);

            Console.WriteLine("\nPresione una tecla para continuar...");
            Console.ReadKey();
        }
    }
}