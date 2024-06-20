using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using LotoClassNS;

namespace PruebaLoto
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Loto apuesta = new Loto();
            int[] bonoloto = new int[6] {1,2,3,4,5,6};
            Loto miApuesta = new Loto(bonoloto);
            apuesta.comprobar(bonoloto);
            Assert.AreEqual(miApuesta, apuesta.comprobar(bonoloto), "No te ha tocado nada");
        }
    }
}
