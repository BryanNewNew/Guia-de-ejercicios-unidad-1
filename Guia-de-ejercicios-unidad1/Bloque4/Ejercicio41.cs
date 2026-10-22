using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Guia_de_ejercicios_unidad1.Bloque4
{
    public class Ejercicio41
    {
        public void Ejecutar()
        {
            Console.Clear();
            Console.WriteLine("--- 41. Arreglo de temperaturas (7 días) ---");
            double[] temps = new double[7];
            string[] dias = { "Lunes", "Martes", "Miércoles", "Jueves", "Viernes", "Sábado", "Domingo" };

            for (int i = 0; i < 7; i++)
            {
                Console.Write($"Ingrese la temperatura del día {dias[i]}: ");
                temps[i] = double.Parse(Console.ReadLine()!);
            }

            double promedioSemanal = temps.Average();
            int diasSobrePromedio = temps.Count(t => t > promedioSemanal);

            double maxTemp = temps.Max();
            int indexMax = Array.IndexOf(temps, maxTemp);

            double minTemp = temps.Min();
            int indexMin = Array.IndexOf(temps, minTemp);

            Console.WriteLine($"\nPromedio semanal: {promedioSemanal:F2} °C");
            Console.WriteLine($"Días con temperatura sobre el promedio: {diasSobrePromedio}");
            Console.WriteLine($"Día más caluroso: {dias[indexMax]} ({maxTemp} °C)");
            Console.WriteLine($"Día más frío: {dias[indexMin]} ({minTemp} °C)");

            Console.WriteLine("\nVariación entre días consecutivos:");
            for (int i = 0; i < temps.Length - 1; i++)
            {
                double variacion = temps[i + 1] - temps[i];
                Console.WriteLine($"{dias[i]} a {dias[i + 1]}: {variacion:+0.;-0.;0} °C");
            }

            Console.WriteLine("\nPresione una tecla para continuar...");
            Console.ReadKey();
        }
    }
}