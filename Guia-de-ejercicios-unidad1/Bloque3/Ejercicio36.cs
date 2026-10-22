using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Guia_de_ejercicios_unidad1.Bloque3
{
    public class Ejercicio36
    {
        public void Ejecutar()
        {
            double ultimoResultado = 0;
            int op;

            do
            {
                Console.Clear();
                Console.WriteLine($"--- 36. Calculadora con Menú ---");
                Console.WriteLine($"[Último resultado guardado: {ultimoResultado}]");
                Console.WriteLine("1. Sumar\n2. Restar\n3. Multiplicar\n4. Dividir\n5. Potencia\n6. Raíz cuadrada\n7. Porcentaje\n8. Nuevo valor inicial\n9. Salir");
                Console.Write("Seleccione una opción: ");

                if (int.TryParse(Console.ReadLine(), out op))
                {
                    if (op == 9) break;

                    if (op == 8)
                    {
                        Console.Write("Ingrese nuevo valor: ");
                        ultimoResultado = double.Parse(Console.ReadLine() ?? "0");
                        continue;
                    }

                    double num = 0;
                    if ((op >= 1 && op <= 5) || op == 7)
                    {
                        Console.Write("Ingrese el siguiente número: ");
                        num = double.Parse(Console.ReadLine() ?? "0");
                    }

                    switch (op)
                    {
                        case 1: ultimoResultado += num; break;
                        case 2: ultimoResultado -= num; break;
                        case 3: ultimoResultado *= num; break;
                        case 4: 
                            if (num != 0) ultimoResultado /= num; 
                            else Console.WriteLine("Error: División entre cero."); 
                            break;
                        case 5: ultimoResultado = Math.Pow(ultimoResultado, num); break;
                        case 6: 
                            if (ultimoResultado >= 0) ultimoResultado = Math.Sqrt(ultimoResultado); 
                            else Console.WriteLine("Error: Raíz negativa."); 
                            break;
                        case 7: ultimoResultado = (ultimoResultado * num) / 100.0; break;
                        default: Console.WriteLine("Opción no válida."); break;
                    }

                    Console.WriteLine($"Resultado actual: {ultimoResultado}");
                    Console.WriteLine("Presione una tecla para continuar...");
                    Console.ReadKey();
                }
            } while (op != 9);
        }
    }
}