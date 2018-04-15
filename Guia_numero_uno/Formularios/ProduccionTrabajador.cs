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
    public partial class ProduccionTrabajador : Form
    {
        public ProduccionTrabajador()
        {
            InitializeComponent();
        }

        private void TraerProduccion(object sender, EventArgs e)
        {
            int lunes = int.Parse(txtLunes.Text);
            int martes = int.Parse(txtMartes.Text);
            int miercoles = int.Parse(txtMiercoles.Text);
            int jueves = int.Parse(txtJueves.Text);
            int viernes = int.Parse(txtViernes.Text);
            int savado = int.Parse(txtSavado.Text);

            int diario = lunes + martes + miercoles + jueves + viernes + savado;
            int produccion = diario / 6;

            if(produccion>500){

                MessageBox.Show("Su total de produccion diaria es de "+produccion+" %");

            }
            else
            {
                MessageBox.Show("ERROR","Produccion mala",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

        }
        
    }
}
