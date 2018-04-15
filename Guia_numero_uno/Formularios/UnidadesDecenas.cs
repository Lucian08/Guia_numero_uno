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
    public partial class UnidadesDecenas : Form
    {
        public UnidadesDecenas()
        {
            InitializeComponent();
        }

        private void TraerUnidadesDecenas(object sender, EventArgs e)
        {
            int entero = int.Parse(txtEntero.Text);
            int Decena = entero / 10;
            int Unidad = entero % 10;

            MessageBox.Show("La decena del numero "+entero+" es "+Decena+" y su unidad es "+Unidad);
        }
    }
}
