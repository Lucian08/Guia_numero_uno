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
    public partial class MetasVenta : Form
    {
        public MetasVenta()
        {
            InitializeComponent();
        }

        private void TraerBonificacion(object sender, EventArgs e)
        {
            int monto = int.Parse(txtMonto.Text);

            if (monto >= 0 && monto <= 500000)
            {
                MessageBox.Show("con una venta de " + monto + " tiene una bonificacion de 0%");

            }
            else
            {
                if (monto >= 500001 && monto <= 1500000)
                {
                    MessageBox.Show("con una venta de " + monto + " tiene una bonificacion de 3%");

                }
                else
                {
                    if (monto >= 1500001 && monto <= 2500000)
                    {
                        MessageBox.Show("con una venta de " + monto + " tiene una bonificacion de 8%");

                    }
                    else
                    {
                        MessageBox.Show("con una venta de " + monto + " tiene una bonificacion de 12%");

                    }
                }
            }
        }
    }
}
