namespace Guia_numero_uno.Formularios
{
    partial class HermanoMayor
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNombreHermano1 = new System.Windows.Forms.TextBox();
            this.txtEdadHermano1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNombreHermano2 = new System.Windows.Forms.TextBox();
            this.txtEdadHermano2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtEdadHermano1);
            this.groupBox1.Controls.Add(this.txtNombreHermano1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(259, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hermano 1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtEdadHermano2);
            this.groupBox2.Controls.Add(this.txtNombreHermano2);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(13, 119);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(259, 100);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Hermano 2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Edad:";
            // 
            // txtNombreHermano1
            // 
            this.txtNombreHermano1.Location = new System.Drawing.Point(73, 20);
            this.txtNombreHermano1.Name = "txtNombreHermano1";
            this.txtNombreHermano1.Size = new System.Drawing.Size(180, 20);
            this.txtNombreHermano1.TabIndex = 2;
            // 
            // txtEdadHermano1
            // 
            this.txtEdadHermano1.Location = new System.Drawing.Point(73, 46);
            this.txtEdadHermano1.Name = "txtEdadHermano1";
            this.txtEdadHermano1.Size = new System.Drawing.Size(180, 20);
            this.txtEdadHermano1.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Nombre:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Edad:";
            // 
            // txtNombreHermano2
            // 
            this.txtNombreHermano2.Location = new System.Drawing.Point(73, 22);
            this.txtNombreHermano2.Name = "txtNombreHermano2";
            this.txtNombreHermano2.Size = new System.Drawing.Size(180, 20);
            this.txtNombreHermano2.TabIndex = 3;
            // 
            // txtEdadHermano2
            // 
            this.txtEdadHermano2.Location = new System.Drawing.Point(73, 48);
            this.txtEdadHermano2.Name = "txtEdadHermano2";
            this.txtEdadHermano2.Size = new System.Drawing.Size(180, 20);
            this.txtEdadHermano2.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 235);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(259, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Calcular";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.verHermano);
            // 
            // HermanoMayor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(287, 296);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "HermanoMayor";
            this.Text = "HermanoMayor";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtEdadHermano1;
        private System.Windows.Forms.TextBox txtNombreHermano1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtEdadHermano2;
        private System.Windows.Forms.TextBox txtNombreHermano2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
    }
}