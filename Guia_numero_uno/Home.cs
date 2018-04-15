using Guia_numero_uno.Formularios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Guia_numero_uno
{
    public partial class Home : Form


    {
        public Home()
        {
            InitializeComponent();

        }

        private void desplegarSumaFactores(object sender, EventArgs e)
        {
            PrimerEjercicio nombre = new PrimerEjercicio();
            nombre.Show();
        }

        private void DesplegarPuntajeFinal(object sender, EventArgs e)
        {
            PuntajeFinal nombre = new PuntajeFinal();
            nombre.Show();
        }

        private void TraerLiquidacionSueldo(object sender, EventArgs e)
        {
            LiquidacionDeSueldo nombre = new LiquidacionDeSueldo();
            nombre.Show();
        }

        private void traerCantidadDvd(object sender, EventArgs e)
        {
            CantidadDvd nombre = new CantidadDvd();
            nombre.Show();
        }

        private void traeHermanoMayor(object sender, EventArgs e)
        {
            HermanoMayor nombre = new HermanoMayor();
            nombre.Show();
        }

        private void TraerProduccionTrabajador(object sender, EventArgs e)
        {
            ProduccionTrabajador nombre = new ProduccionTrabajador();
            nombre.Show();
        }

        private void traerNumerosReales(object sender, EventArgs e)
        {
            NumerosReales nombre = new NumerosReales();
            nombre.Show();
        }

        private void traerTriangulos(object sender, EventArgs e)
        {
            Triangulos nombre = new Triangulos();
            nombre.Show();
        }

        private void TraerMetasVenta(object sender, EventArgs e)
        {
            MetasVenta nombre = new MetasVenta();
            nombre.Show();
        }

        private void TraerUnidadesDecenas(object sender, EventArgs e)
        {
            UnidadesDecenas nombre = new UnidadesDecenas();
            nombre.Show();
        }

        private void TraerVocales(object sender, EventArgs e)
        {
            Vocales nombre = new Vocales();
            nombre.Show();
        }
    }
}
