namespace Guia_numero_uno
{
    partial class Home
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnNumeroReal = new System.Windows.Forms.Button();
            this.btnVenta = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.btnDecenas = new System.Windows.Forms.Button();
            this.btnVocal = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 37);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(146, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Promedio Nota";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.desplegarSumaFactores);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 66);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(146, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Liquidacion de sueldo";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.TraerLiquidacionSueldo);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(12, 95);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(146, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "Hermano";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.traeHermanoMayor);
            // 
            // btnNumeroReal
            // 
            this.btnNumeroReal.Location = new System.Drawing.Point(12, 124);
            this.btnNumeroReal.Name = "btnNumeroReal";
            this.btnNumeroReal.Size = new System.Drawing.Size(146, 23);
            this.btnNumeroReal.TabIndex = 3;
            this.btnNumeroReal.Text = "Numeros Reales";
            this.btnNumeroReal.UseVisualStyleBackColor = true;
            this.btnNumeroReal.Click += new System.EventHandler(this.traerNumerosReales);
            // 
            // btnVenta
            // 
            this.btnVenta.Location = new System.Drawing.Point(12, 153);
            this.btnVenta.Name = "btnVenta";
            this.btnVenta.Size = new System.Drawing.Size(146, 23);
            this.btnVenta.TabIndex = 4;
            this.btnVenta.Text = "Venta";
            this.btnVenta.UseVisualStyleBackColor = true;
            this.btnVenta.Click += new System.EventHandler(this.TraerMetasVenta);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(164, 37);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(146, 23);
            this.button6.TabIndex = 5;
            this.button6.Text = "Puntaje Final";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.DesplegarPuntajeFinal);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(164, 66);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(146, 23);
            this.button7.TabIndex = 6;
            this.button7.Text = "DVD";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.traerCantidadDvd);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(164, 95);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(146, 23);
            this.button8.TabIndex = 7;
            this.button8.Text = "Produccion";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.TraerProduccionTrabajador);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(164, 124);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(146, 23);
            this.button9.TabIndex = 8;
            this.button9.Text = "Triangulos";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.traerTriangulos);
            // 
            // btnDecenas
            // 
            this.btnDecenas.Location = new System.Drawing.Point(164, 153);
            this.btnDecenas.Name = "btnDecenas";
            this.btnDecenas.Size = new System.Drawing.Size(146, 23);
            this.btnDecenas.TabIndex = 9;
            this.btnDecenas.Text = "Unidades Decena";
            this.btnDecenas.UseVisualStyleBackColor = true;
            this.btnDecenas.Click += new System.EventHandler(this.TraerUnidadesDecenas);
            // 
            // btnVocal
            // 
            this.btnVocal.Location = new System.Drawing.Point(12, 182);
            this.btnVocal.Name = "btnVocal";
            this.btnVocal.Size = new System.Drawing.Size(298, 23);
            this.btnVocal.TabIndex = 10;
            this.btnVocal.Text = "Vocales";
            this.btnVocal.UseVisualStyleBackColor = true;
            this.btnVocal.Click += new System.EventHandler(this.TraerVocales);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 244);
            this.Controls.Add(this.btnVocal);
            this.Controls.Add(this.btnDecenas);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.btnVenta);
            this.Controls.Add(this.btnNumeroReal);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Home";
            this.Text = "Fomularios";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnNumeroReal;
        private System.Windows.Forms.Button btnVenta;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button btnDecenas;
        private System.Windows.Forms.Button btnVocal;
    }
}

