﻿namespace Guia_numero_uno.Formularios
{
    partial class MetasVenta
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtMonto = new System.Windows.Forms.TextBox();
            this.btnBonificacion = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Monto generado:";
            // 
            // txtMonto
            // 
            this.txtMonto.Location = new System.Drawing.Point(107, 34);
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.Size = new System.Drawing.Size(100, 20);
            this.txtMonto.TabIndex = 1;
            // 
            // btnBonificacion
            // 
            this.btnBonificacion.Location = new System.Drawing.Point(12, 101);
            this.btnBonificacion.Name = "btnBonificacion";
            this.btnBonificacion.Size = new System.Drawing.Size(301, 23);
            this.btnBonificacion.TabIndex = 2;
            this.btnBonificacion.Text = "Calcular Bonificacion";
            this.btnBonificacion.UseVisualStyleBackColor = true;
            this.btnBonificacion.Click += new System.EventHandler(this.TraerBonificacion);
            // 
            // MetasVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(325, 153);
            this.Controls.Add(this.btnBonificacion);
            this.Controls.Add(this.txtMonto);
            this.Controls.Add(this.label1);
            this.Name = "MetasVenta";
            this.Text = "MetasVenta";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMonto;
        private System.Windows.Forms.Button btnBonificacion;
    }
}