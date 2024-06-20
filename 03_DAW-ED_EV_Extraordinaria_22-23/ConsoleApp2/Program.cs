using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PrediccionNS;

namespace PrediccionApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            Prediccion miPrediccion = new Prediccion();

            List<double> dia1 = new List<double>(),
                         dia2 = new List<double>(),
                         dia3 = new List<double>();


            dia1.Add(12.5); dia1.Add(16.5); dia1.Add(21); dia1.Add(17); dia1.Add(15);
            dia2.Add(13); dia2.Add(15); dia2.Add(19.5); dia2.Add(16.5); dia2.Add(14);
            dia3.Add(14.5); dia3.Add(18.5); dia3.Add(23); dia3.Add(20); dia3.Add(17.5);

            miPrediccion.ObtenerPrediccion(dia1, dia2, dia3);

            ImprimirPrediccion(miPrediccion);

           

            // Resultado final
            // Celsius: 17,155
            // Farenheit: 62,879
            // Máxima: 21
            // Mínima: 12,5
        }

        private static void ImprimirPrediccion(Prediccion miPrediccion)
        {
            Console.WriteLine("Temperatura Celsius: " + miPrediccion.tc);
            Console.WriteLine("Temperatura Farenheit: " + miPrediccion.tf);
            Console.WriteLine("Máxima: " + miPrediccion.max);
            Console.WriteLine("Mínima: " + miPrediccion.min);
            Console.ReadKey();
            Console.ReadLine();
        }
    }
}
