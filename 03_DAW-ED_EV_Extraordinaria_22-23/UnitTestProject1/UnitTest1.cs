using Microsoft.VisualStudio.TestTools.UnitTesting;
using PrediccionApp;
using PrediccionNS;
using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void VerQueLosNuevosNombresVanBien()
        {
            Program miPrograma = new Program();
            Prediccion nuevaPrediccion = new Prediccion();
            double prediccionResultado = 2;
            bool esCorrectaLaPrediccion = true;
            List<double> prediccionPrueba1 = new List<double>() { 12.5, 16.5, 21, 17, 15 };
            List<double> prediccionPrueba2 = new List<double>() { 13, 15, 19.5, 16.5, 14 };
            List<double> prediccionPrueba3 = new List<double>() { 14.5, 18.5, 23, 20, 17.5 };
            Assert.AreEqual(esCorrectaLaPrediccion, nuevaPrediccion.ObtenerPrediccion(prediccionPrueba1, prediccionPrueba2, prediccionPrueba3), "Devuelve false; algo no ha ido bien en la refactorización"); 

        }
    }
}
