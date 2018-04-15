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
    public partial class PrimerEjercicio : Form
    {
        public PrimerEjercicio()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            int nota1 = int.Parse(txtNota1.Text);
            int nota2 = int.Parse(txtNota2.Text);
            int nota3 = int.Parse(txtNota3.Text);
            int nota4 = int.Parse(txtNota4.Text);

            int Suma = nota1 + nota2 + nota3 + nota4;
            int Promedio = Suma / 4;

            MessageBox.Show("Sr: "+nombre+" Su promedio de nota es "+Promedio);

        }
    }
}


