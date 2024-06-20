using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamenED1EV2324
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Función que realiza una división entera mediante restas sucesivas.
        // Contamos cuantas veces "cabe" el dividendo en el divisor.
        int divisionRestas(int dividendoATMS2324, int divisorATMS2324)
        {
            // Declaramos una variable para almacenar el resultado.
            int cont = 0;

            // Restamos el divisor al dividendo
            //
            while (dividendoATMS2324 >= divisorATMS2324)
            {
                dividendoATMS2324 -= divisorATMS2324;
                cont++;
            }

            // Devolvemos el resultado.
            return cont;
        }

        // Evento que se llama al pulsar el botón "Dividir".
        private void btDividir_Click(object sender, EventArgs e)
        {
            try
            {
                // Declaramos las variables necesarias.
                int dividendoATMS2324, divisorATMS2324, resultado;

                // Leemos los valores del cuadro de texto.
                dividendoATMS2324 = int.Parse(txtDividendo.Text);
                divisorATMS2324 = int.Parse(txtDivisor.Text);

                // Comprobamos que el divisor no sea cero.
                if (divisorATMS2324 == 0)
                {
                    // Lanzamos una excepción.
                    throw new Exception("El divisor no puede ser cero.");
                }
                // Comprobamos que el divisor no sea mayor que el dividendo.
                if (dividendoATMS2324 < divisorATMS2324)
                {
                    // Lanzamos una excepción.
                    throw new Exception("El divisor ha de ser menor que el dividendo.");
                }

                // Llamamos a la función para realizar la división.
                resultado = divisionRestas(dividendoATMS2324, divisorATMS2324);

                // Mostramos el resultado.
                MessageBox.Show("El resultado de dividir " + dividendoATMS2324 + " entre " + divisorATMS2324 + " es : " + resultado);
            }
            catch (FormatException ex)
            {
                // Capturamos la excepción de formato incorrecto.
                MessageBox.Show("Error de formato: " + ex.Message);
            }
            catch (Exception ex)
            {
                // Capturamos cualquier otra excepción.
                MessageBox.Show("Error: " + ex.Message);
            }
        }

    }
}