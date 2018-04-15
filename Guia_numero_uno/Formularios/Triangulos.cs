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
    public partial class Triangulos : Form
    {
        public Triangulos()
        {
            InitializeComponent();
        }

        private void traerTriangulo(object sender, EventArgs e)
        {
            int lado1 = int.Parse(txtLado1.Text);
            int lado2 = int.Parse(txtLado2.Text);
            int lado3 = int.Parse(txtLado3.Text);

            if(lado1==lado2&&lado1==lado3){
                MessageBox.Show("Es un triangulo equilatero");
            }
            else { 
          
            if(lado1==lado2||lado1==lado3||lado2==lado3){

                    MessageBox.Show("Es un triangulo isosceles ");
            }
            
            else 
            {
                MessageBox.Show("Es un Triangulo escaleno");
            }


            }


        }
    }
}
