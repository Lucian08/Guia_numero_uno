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
    public partial class Vocales : Form
    {
        public Vocales()
        {
            InitializeComponent();
        }

        private void TraerVocal(object sender, KeyPressEventArgs e)
        {
            string letra = txtVocal.Text;

            if (letra == "a" || letra == "e" || letra == "i" || letra == "o" || letra == "u")
            {
                MessageBox.Show("Se a ingresado una vocal ");

            }
        }
    }
}
