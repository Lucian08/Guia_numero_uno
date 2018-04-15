namespace Guia_numero_uno.Formularios
{
    partial class CantidadDvd
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
            this.txtGb = new System.Windows.Forms.TextBox();
            this.btnDvd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cantidad Gb:";
            // 
            // txtGb
            // 
            this.txtGb.Location = new System.Drawing.Point(97, 37);
            this.txtGb.Name = "txtGb";
            this.txtGb.Size = new System.Drawing.Size(100, 20);
            this.txtGb.TabIndex = 1;
            // 
            // btnDvd
            // 
            this.btnDvd.Location = new System.Drawing.Point(16, 99);
            this.btnDvd.Name = "btnDvd";
            this.btnDvd.Size = new System.Drawing.Size(256, 23);
            this.btnDvd.TabIndex = 2;
            this.btnDvd.Text = "Calular";
            this.btnDvd.UseVisualStyleBackColor = true;
            this.btnDvd.Click += new System.EventHandler(this.traerCantidadGb);
            // 
            // CantidadDvd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnDvd);
            this.Controls.Add(this.txtGb);
            this.Controls.Add(this.label1);
            this.Name = "CantidadDvd";
            this.Text = "CantidadDvd";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtGb;
        private System.Windows.Forms.Button btnDvd;
    }
}