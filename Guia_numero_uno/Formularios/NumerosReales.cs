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
    public partial class NumerosReales : Form
    {
        public NumerosReales()
        {
            InitializeComponent();
        }

        private void traerMenor(object sender, EventArgs e)
        {
            int n1 = int.Parse(txtN1.Text);
            int n2 = int.Parse(txtN2.Text);
            int n3 = int.Parse(txtN3.Text);

            if (n1<n2 && n2<n3)
            {
                MessageBox.Show("El numero menor es "+n1);

            }
            else
            {
                if(n2 < n1 && n2 < n3)
                {
                    MessageBox.Show("El numero menor es: " + n2);

                }
                else
                {
                    MessageBox.Show("El numero menor es: " + n3);
                }
            }
        }
    }
}
