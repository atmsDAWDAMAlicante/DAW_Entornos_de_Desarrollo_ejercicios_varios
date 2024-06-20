using System;
using System.Collections.Generic;

namespace PrediccionNS  // El primer paso debe ser añadir aquí vuestras iniciales
{
    // Clase para obtener la predicción de la temperatura a partir de las observaciones de los tres días previos
    // 
    // La clase calcula la predicción tanto en grados celsius como farenheit
    // CAMBIO EL NAVEGADOR A FIREFOX
    public class Prediccion
    {
        public double tc; // temperatura en grados Celsius
        public double tf; // temperatura en grados farenheit
        public double max; // temperatura máxima
        public double min; // temperatura mínima

        // La siguiente función obtiene la temperatura promedio de cada uno 
        // de los días que se pasan como parámetro y devuelve una estimación 
        // basada en una fórmula.
        // obsdia1, obsdia2 y obsdia3 contienen las observaciones de los días anteriores
        //
		// La función retorna true si se ha podido obtener la predicción, false si ha ocurrido un error
		//
        public bool ObtenerPrediccion(List<double> obsdia1, List<double> obsdia2, List<double> obsdia3)
        {
            int i;  // contador
            double tmd1 = 0, tmd2 = 0, tmd3 = 0; // temperatura media de cada día

            max = -1000; // Inicializamos los máximos y los mínimos
            min = +1000;

            // Para cada día obtenemos la suma de temperaturas
            // Observaciones pera el día 1
            if (obsdia1.Count <= 0)
            {
                return false;  // Tenemos que tener al menos una observación
            } 
            else
            {
                for (i = 0; i < obsdia1.Count; i++)
                {
                    tmd1 = tmd1 + obsdia1[i];
                    if (min > obsdia1[i]) min = obsdia1[i];
                    if (max < obsdia1[i]) max = obsdia1[i];
                }
                tmd1 = tmd1 / obsdia1.Count;
                Console.WriteLine(tmd1.ToString());
            }
			



            // Observaciones para el día 2
            if (obsdia2.Count <= 0) return false;  // Tenemos que tener al menos una observación

            for (i=0;i<obsdia2.Count;i++)
             {
                tmd2 = tmd2 + obsdia2[i];
                if (min > obsdia2[i]) min = obsdia2[i];
                if (max < obsdia2[i]) max = obsdia2[i];
            }
            tmd2 = tmd2 / obsdia2.Count;
            Console.WriteLine(tmd2.ToString());


            // Observaciones para el día 3

            if (obsdia3.Count <= 0) return false;  // Tenemos que tener al menos una observación

            for (i=0;i<obsdia3.Count;i++)
             {
                tmd3 = tmd3 + obsdia3[i];
                if (min > obsdia3[i]) min = obsdia1[i];
                if (max < obsdia3[i]) max = obsdia1[i];
            }
            tmd3 = tmd3 / obsdia3.Count;
            Console.WriteLine(tmd3.ToString());

            // Finalmente calculamos la temperatura media total, dándo más peso 		
            // al último día que al primero
            //
            tc = 0.2 * tmd1 + 0.35 * tmd2 + 0.45 * tmd3;

            // calculamos también la temperatura en grados farenheit
            //
            tf = (tc * 1.8) + 32;

            return true;
        }
    }
}

