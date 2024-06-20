using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ent_02_02_Telegrama
{
    public partial class Ent_02_02_Telegrama : Form
    {
        public Ent_02_02_Telegrama()
        {
            // ColaboracionATMS2DAWY
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string textoTelegrama;
            char tipoTelegrama = 'o';
            char[] delimitadores = new char[] { ' ', '\r', '\n' };


            double coste;

            //Leo el telegrama
            textoTelegrama = txtTelegrama.Text;
            // telegrama urgente?
            if (cbUrgente.Checked)
                tipoTelegrama = 'u';

            //Obtengo el número de palabras que forma el telegrama
            int numPalabras = textoTelegrama.Split(delimitadores, StringSplitOptions.RemoveEmptyEntries).Length;


            //Si el telegrama es ordinario
            if (tipoTelegrama == 'o')
                if (numPalabras <= 10)
                    coste = 25;
                else
                    coste = 0.5 * numPalabras;
            else
            //Si el telegrama es urgente

            if (tipoTelegrama == 'u')
                if (numPalabras <= 10)
                    
                    coste = 5;
                else
                    coste = 5 + 0.75 * (numPalabras - 10);
            else
                coste = 0;
            txtPrecio.Text = coste.ToString() + " euros";
        }
    }
}
