using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Guia_de_ejercicios_unidad1.ClasesDelaGuiadeEjercicios
{
    public class Ejercicio1
    {
// Conversor de moneda - Solicitar un monto en lempiras y la tasa de cambio del día. Convertir el
// monto a dólares y a euros, mostrando los resultados con dos decimales
        public void ConvertirMoneda()
        {
            double montoL = 0;
            Console.WriteLine("Ingrese el monto en Lempiras de la moneda que desea convertir:");
            while(!double.TryParse(Console.ReadLine(), out montoL) || montoL < 0)
            {
                Console.WriteLine("El monto que ingreso es invalido por favor vuelva a intentar y \nsolo escriba numeros no letras ni simbolos");
            }

            double TasaD = 0;
            Console.WriteLine("Ingrese la tasa de cambio del dolar:");
            while(!double.TryParse(Console.ReadLine(), out TasaD) || TasaD < 0)
            {
                Console.WriteLine("Tasa invalida vuelva a intentar");
            }

            double TasaE = 0;
            Console.WriteLine("Ingrese la tasa de cambio del euro:");
            while(!double.TryParse(Console.ReadLine(), out TasaE) || TasaE < 0)
            {
                Console.WriteLine("Tasa invalida vuelva a intentar");
            }

            double ResultadoLAD = (montoL/TasaD);
            double ResultadoLAE = (montoL/TasaE);

            Console.WriteLine($"La cantidad de Lempiras a Dolares es: {ResultadoLAD:F2}");
            Console.WriteLine($"La cantidad de Lempiras a Euros es: {ResultadoLAE:F2}");



        }
    }
}