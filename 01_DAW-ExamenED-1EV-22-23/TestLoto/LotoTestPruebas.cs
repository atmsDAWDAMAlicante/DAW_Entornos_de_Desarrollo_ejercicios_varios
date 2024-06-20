using ExamenLoto;
using LotoClassNS;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Windows.Forms;

namespace TestLoto
{
    [TestClass]
    public class LotoTestPruebas
    {
        [TestMethod]
        public void TestMethod1()
        {
        }

        public void GenerarCombination_ValidCombinationGenerated()
        {
            // Arrange
            var form = new Form1();

            // Act
            form.btGenerar_Click(null, null);
            
            // Assert
            foreach (var textBox in form.combinacion)
            {
                var value = int.Parse(textBox.Text);
                Assert.IsTrue(value >= Loto.NUMERO_MENOR && value <= Loto.NUMERO_MAYOR);
            }
        }

        [TestMethod]
        public void ValidarCombination_ValidCombination_ValidMessageShown()
        {
            // Arrange
            var form = new Form1();

            // Act
            form.btValidar_Click(null, null);

            // Assert
            Assert.AreEqual("Combinación válida", MessageBox.Show("ValidarCombination_ValidCombination_ValidMessageShown").ToString());
        }

        [TestMethod]
        public void ValidarCombination_InvalidCombination_InvalidMessageShown()
        {
            // Arrange
            var form = new Form1();

            // Modify the combination to be invalid
            foreach (var textBox in form.combinacion)
            {
                textBox.Text = "50";
            }

            // Act
            form.btValidar_Click(null, null);

            // Assert
            Assert.AreEqual("Combinación no válida", MessageBox.Show("ValidarCombination_InvalidCombination_InvalidMessageShown").ToString());
        }

        [TestMethod]
        public void ComprobarCombination_WinningCombination_PremierMessageShown()
        {
            // Arrange
            var form = new Form1();

            // Set the winning combination
            foreach (var textBox in form.ganadora)
            {
                textBox.Text = "1";
            }

            // Set the user's combination
            foreach (var textBox in form.combinacion)
            {
                textBox.Text = "1";
            }

            // Act
            form.btComprobar_Click(null, null);

            // Assert
            Assert.AreEqual("¡Enhorabuena! Tiene una combinación con 6 aciertos", MessageBox.Show("ComprobarCombination_WinningCombination_PremierMessageShown").ToString());
        }

        [TestMethod]
        public void ComprobarCombination_LosingCombination_NotPremierMessageShown()
        {
            // Arrange
            var form = new Form1();

            // Set the winning combination
            foreach (var textBox in form.ganadora)
            {
                textBox.Text = "1";
            }

            // Set the user's combination
            foreach (var textBox in form.combinacion)
            {
                textBox.Text = "2";
            }

            // Act
            form.btComprobar_Click(null, null);

            // Assert
            Assert.AreEqual("No ha resultado premiada", MessageBox.Show("ComprobarCombination_LosingCombination_NotPremierMessageShown").ToString());
        }






    }
}
