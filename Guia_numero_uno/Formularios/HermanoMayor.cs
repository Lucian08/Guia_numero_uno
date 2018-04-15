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
    public partial class HermanoMayor : Form
    {
        public HermanoMayor()
        {
            InitializeComponent();
        }

        private void verHermano(object sender, EventArgs e)
        {
            //Primer hermno//
            string nombreHermano1 = txtNombreHermano1.Text;
            int edadHermano1 = int.Parse(txtEdadHermano1.Text);
            //Segundo Hermano//
            string nombreHermano2 = txtNombreHermano2.Text;
            int edadHermano2 = int.Parse(txtEdadHermano2.Text);

            if(edadHermano1>edadHermano2){
                int mayor = edadHermano1 - edadHermano2;
                MessageBox.Show(nombreHermano1 + " es mayor por "+mayor+" años que " + nombreHermano2);
            }
            else
            {
                if(edadHermano1==edadHermano2)
                {
                    
                    MessageBox.Show("Ambos tienen la misma edad");

                }
                else
                {
                    int mayor2 = edadHermano2 - edadHermano1;
                    MessageBox.Show(nombreHermano2 + " es mayor por " + mayor2 + " años que " + nombreHermano1);

                }
                

            }

        }
    }
}
