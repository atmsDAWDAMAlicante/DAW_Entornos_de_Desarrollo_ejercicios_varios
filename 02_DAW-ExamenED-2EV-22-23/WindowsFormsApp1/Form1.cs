﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionBancariaAppNS
{
    public partial class GestionBancariaApp : Form
    {
        // ATMS2DAWY2324
        private double saldo;
		/*
        const int ERR_CANTIDAD_NO_VALIDA = 1;
        const int ERR_SALDO_INSUFICIENTE = 2;
        */
		// ATMS2DAWY2324
		public const String ERR_CANTIDAD_NO_VALIDA = "Cantidad no válida";
		public const String ERR_SALDO_INSUFICIENTE = "Saldo insuficiente";

		public GestionBancariaApp(double saldo = 0) // ATMS2DAWY2324
            {
            InitializeComponent();
            if (saldo > 0)
                this.saldo = saldo;
            else
                this.saldo = 0;
            txtSaldo.Text = ObtenerSaldo().ToString();
            txtCantidad.Text = "0";
        }

        public double ObtenerSaldo() { return saldo; } // ATMS2DAWY2324

        public string RealizarReintegro(double cantidad) // ATMS2DAWY2324
            {
            if (cantidad <= 0)
				//return ERR_CANTIDAD_NO_VALIDA;
				//throw new ArgumentOutOfRangeException("La cantidad indicada no es válida.");
				throw new ArgumentOutOfRangeException(ERR_CANTIDAD_NO_VALIDA);
			if (saldo < cantidad)
				//return ERR_SALDO_INSUFICIENTE;
				//throw new ArgumentOutOfRangeException("Saldo Insuficiente");
				throw new ArgumentOutOfRangeException(ERR_SALDO_INSUFICIENTE);
			// saldo += cantidad; Error intencionado
			saldo -= cantidad;
            return "OK";
        }

        public string RealizarIngreso(double cantidad) { // ATMS2DAWY2324
            if (cantidad <= 0) // hay que cambiar el > por <=
                //return ERR_CANTIDAD_NO_VALIDA;
                //throw new ArgumentOutOfRangeException("La cantidad indicada no es válida.");
                throw new ArgumentOutOfRangeException(ERR_CANTIDAD_NO_VALIDA);
			saldo += cantidad; // hay que cambiar el -= por un +=
            return "OK";
        }

        private void btOperar_Click(object sender, EventArgs e) // ATMS2DAWY2324
            {
			double cantidad = Convert.ToDouble(txtCantidad.Text);
			if (rbReintegro.Checked)
				{
				try
					{
					RealizarReintegro(cantidad);
					MessageBox.Show("Transacción realizada.");
					}
				catch (Exception error)
					{
					if (error.Message.Contains(ERR_SALDO_INSUFICIENTE))
						MessageBox.Show("No se ha podido realizar la operación (¿Saldo insuficiente ?)");
					else
						if (error.Message.Contains(ERR_CANTIDAD_NO_VALIDA))
							MessageBox.Show("Cantidad no válida, sólo se admiten cantidades	positivas.");
					}
				}
			else
				{
				try
					{
					RealizarIngreso(cantidad);
					MessageBox.Show("Transacción realizada.");
					}
				catch (Exception error)
					{
					if (error.Message.Contains(ERR_CANTIDAD_NO_VALIDA))
						MessageBox.Show("Cantidad no válida, sólo se admiten cantidades positivas.");
					}
				}
			txtSaldo.Text = ObtenerSaldo().ToString();
			/*
			double cantidad = Convert.ToDouble(txtCantidad.Text); // Cogemos la cantidad del TextBox y la pasamos a número
			if (rbReintegro.Checked)
			{
				string respuesta = RealizarReintegro(cantidad);
				if (respuesta == ERR_SALDO_INSUFICIENTE)
					MessageBox.Show("No se ha podido realizar la operación (¿Saldo insuficiente?)");
				else
				if (respuesta == ERR_CANTIDAD_NO_VALIDA)
					MessageBox.Show("Cantidad no válida, sólo se admiten cantidades positivas.");
				else
					MessageBox.Show("Transacción realizada.");

			}
			else {
				if (RealizarIngreso(cantidad) == ERR_CANTIDAD_NO_VALIDA)
					MessageBox.Show("Cantidad no válida, sólo se admiten cantidades positivas.");
				else
					MessageBox.Show("Transacción realizada.");
			}
		   txtSaldo.Text = ObtenerSaldo().ToString();


			*/
			}
    }
}
