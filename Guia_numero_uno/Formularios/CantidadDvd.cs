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
    public partial class CantidadDvd : Form
    {
        public CantidadDvd()
        {
            InitializeComponent();
        }

        private void traerCantidadGb(object sender, EventArgs e)
        {
            double dvd =4.7;
            double Gb = double.Parse(txtGb.Text);
            double cantidad = Gb / dvd;
            

            MessageBox.Show("Necesita " + cantidad + " DVD Para poder respaldar " + Gb + " Gb");

            
        }
    }
}
