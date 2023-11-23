using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema04_Lab14
{
    internal class Program
    {
        private static readonly int totalEncuestados;

        static void Main(string[] args)
        {
            Console.WriteLine("===================================");
            Console.WriteLine("Resultados de la encuesta");
            Console.WriteLine("===================================");

            int totalVacunados = seHaVacunado.Count(v => v);
            int totalNoVacunados = totalEncuestados - totalVacunados;

            Console.WriteLine($"{totalVacunados:D2} personas se han vacunado");
            Console.WriteLine($"{totalNoVacunados:D2} personas no se han vacunado");

            Console.WriteLine();
            Console.WriteLine($"Existen:");
            Console.WriteLine($"{ContarPersonasEnRango(1, 20):D2} personas entre 01 y 20 años");
            Console.WriteLine($"{ContarPersonasEnRango(21, 30):D2} personas entre 21 y 30 años");
            Console.WriteLine($"{ContarPersonasEnRango(31, 40):D2} personas entre 31 y 40 años");
            Console.WriteLine($"{ContarPersonasEnRango(41, 50):D2} personas entre 41 y 50 años");
            Console.WriteLine($"{ContarPersonasEnRango(51, 60):D2} personas entre 51 y 60 años");
            Console.WriteLine($"{ContarPersonasEnRango(61, int.MaxValue):D2} personas de más de 61 años");

            Console.WriteLine("===================================");
            Console.WriteLine("Presione una tecla para regresar ...");
            Console.ReadKey();
        }

        static int ContarPersonasEnRango(int edadMin, int edadMax)
        {
            return "edades".Count(e => e >= edadMin && e <= edadMax);
        }

        private class seHaVacunado
        {
            internal static int Count(Func<object, object> value)
            {
                throw new NotImplementedException();
            }
        }
    }
}

