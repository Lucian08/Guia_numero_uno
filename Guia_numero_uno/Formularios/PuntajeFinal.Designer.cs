namespace Guia_numero_uno.Formularios
{
    partial class PuntajeFinal
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtRespuestaCorrecta = new System.Windows.Forms.TextBox();
            this.txtRespuestaIncorrecta = new System.Windows.Forms.TextBox();
            this.txtRespuestaEnBlanco = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.txtRespuestaEnBlanco);
            this.groupBox1.Controls.Add(this.txtRespuestaIncorrecta);
            this.groupBox1.Controls.Add(this.txtRespuestaCorrecta);
            this.groupBox1.Controls.Add(this.txtNombre);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(363, 205);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Respuestas correctas:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Respuesta incorrectas:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Respuesta en blanco:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(149, 29);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(192, 20);
            this.txtNombre.TabIndex = 4;
            // 
            // txtRespuestaCorrecta
            // 
            this.txtRespuestaCorrecta.Location = new System.Drawing.Point(149, 55);
            this.txtRespuestaCorrecta.Name = "txtRespuestaCorrecta";
            this.txtRespuestaCorrecta.Size = new System.Drawing.Size(192, 20);
            this.txtRespuestaCorrecta.TabIndex = 5;
            // 
            // txtRespuestaIncorrecta
            // 
            this.txtRespuestaIncorrecta.Location = new System.Drawing.Point(149, 81);
            this.txtRespuestaIncorrecta.Name = "txtRespuestaIncorrecta";
            this.txtRespuestaIncorrecta.Size = new System.Drawing.Size(192, 20);
            this.txtRespuestaIncorrecta.TabIndex = 6;
            // 
            // txtRespuestaEnBlanco
            // 
            this.txtRespuestaEnBlanco.Location = new System.Drawing.Point(149, 107);
            this.txtRespuestaEnBlanco.Name = "txtRespuestaEnBlanco";
            this.txtRespuestaEnBlanco.Size = new System.Drawing.Size(192, 20);
            this.txtRespuestaEnBlanco.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 158);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Puntaje";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // PuntajeFinal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 230);
            this.Controls.Add(this.groupBox1);
            this.Name = "PuntajeFinal";
            this.Text = "PuntajeFinal";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtRespuestaEnBlanco;
        private System.Windows.Forms.TextBox txtRespuestaIncorrecta;
        private System.Windows.Forms.TextBox txtRespuestaCorrecta;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label4;
    }
}