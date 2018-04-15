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
    public partial class PuntajeFinal : Form
    {
        public PuntajeFinal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            int Pcorrecta = int.Parse(txtRespuestaCorrecta.Text);
            int Pincorrecta = int.Parse(txtRespuestaIncorrecta.Text);
            int Pblanco = int.Parse(txtRespuestaEnBlanco.Text);
           
            int Puntaje10 = Pcorrecta*10;
            int Puntaje5 = Pincorrecta *-5;
            int PuntajeBlanco = Pblanco * 0;

            int PuntajeTotal = Puntaje10 + Puntaje5+PuntajeBlanco;

            MessageBox.Show("Sr: "+nombre+" Su puntaje final es: "+PuntajeTotal);
        }
    }
}
