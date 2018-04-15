using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Guia_numero_uno.Formularios
{
    public partial class LiquidacionDeSueldo : Form
    {
        public LiquidacionDeSueldo()
        {
            InitializeComponent();
        }

        private void CalcularLiquidacion(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            string mes = cbxMes.Text;
            int horaExtra = int.Parse(txtHoras.Text);
            int sueldo = int.Parse(txtSueldo.Text);

            int valorHora =Convert.ToInt16(2333.34);

            int totalHora= horaExtra* valorHora;

            MessageBox.Show("El trabajador "+nombre+" en el mes de "+mes+" ha generado un total de "+horaExtra+" que equivale a un: $"+totalHora);
        }
    }
}
