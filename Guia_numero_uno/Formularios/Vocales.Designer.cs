namespace Guia_numero_uno.Formularios
{
    partial class Vocales
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
            this.txtVocal = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Escriba en el cuadro:";
            // 
            // txtVocal
            // 
            this.txtVocal.Location = new System.Drawing.Point(126, 35);
            this.txtVocal.Name = "txtVocal";
            this.txtVocal.Size = new System.Drawing.Size(100, 20);
            this.txtVocal.TabIndex = 1;
            this.txtVocal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TraerVocal);
            // 
            // Vocales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 100);
            this.Controls.Add(this.txtVocal);
            this.Controls.Add(this.label1);
            this.Name = "Vocales";
            this.Text = "Vocales";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtVocal;
    }
}