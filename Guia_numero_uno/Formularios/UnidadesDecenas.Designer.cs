namespace Guia_numero_uno.Formularios
{
    partial class UnidadesDecenas
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
            this.txtEntero = new System.Windows.Forms.TextBox();
            this.btnUnidadesDecenas = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese numero entero:";
            // 
            // txtEntero
            // 
            this.txtEntero.Location = new System.Drawing.Point(135, 29);
            this.txtEntero.Name = "txtEntero";
            this.txtEntero.Size = new System.Drawing.Size(100, 20);
            this.txtEntero.TabIndex = 1;
            // 
            // btnUnidadesDecenas
            // 
            this.btnUnidadesDecenas.Location = new System.Drawing.Point(13, 106);
            this.btnUnidadesDecenas.Name = "btnUnidadesDecenas";
            this.btnUnidadesDecenas.Size = new System.Drawing.Size(266, 23);
            this.btnUnidadesDecenas.TabIndex = 2;
            this.btnUnidadesDecenas.Text = "Calcular Unidades y decenas";
            this.btnUnidadesDecenas.UseVisualStyleBackColor = true;
            this.btnUnidadesDecenas.Click += new System.EventHandler(this.TraerUnidadesDecenas);
            // 
            // UnidadesDecenas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(291, 269);
            this.Controls.Add(this.btnUnidadesDecenas);
            this.Controls.Add(this.txtEntero);
            this.Controls.Add(this.label1);
            this.Name = "UnidadesDecenas";
            this.Text = "UnidadesDecenas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEntero;
        private System.Windows.Forms.Button btnUnidadesDecenas;
    }
}