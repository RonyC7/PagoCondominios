﻿namespace PagoCondominios
{
    partial class Propiedad
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Propiedad));
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxNCasa = new System.Windows.Forms.TextBox();
            this.textBoxCuotaMan = new System.Windows.Forms.TextBox();
            this.comboBoxDPI = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Salmon;
            this.button1.Location = new System.Drawing.Point(33, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 29);
            this.button1.TabIndex = 0;
            this.button1.Text = "Regresar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Numero de casa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "DPI Dueño";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Cuota Mantenimiento";
            // 
            // textBoxNCasa
            // 
            this.textBoxNCasa.Location = new System.Drawing.Point(179, 65);
            this.textBoxNCasa.Name = "textBoxNCasa";
            this.textBoxNCasa.Size = new System.Drawing.Size(375, 22);
            this.textBoxNCasa.TabIndex = 4;
            // 
            // textBoxCuotaMan
            // 
            this.textBoxCuotaMan.Location = new System.Drawing.Point(179, 163);
            this.textBoxCuotaMan.Name = "textBoxCuotaMan";
            this.textBoxCuotaMan.Size = new System.Drawing.Size(375, 22);
            this.textBoxCuotaMan.TabIndex = 5;
            // 
            // comboBoxDPI
            // 
            this.comboBoxDPI.FormattingEnabled = true;
            this.comboBoxDPI.Location = new System.Drawing.Point(179, 114);
            this.comboBoxDPI.Name = "comboBoxDPI";
            this.comboBoxDPI.Size = new System.Drawing.Size(375, 24);
            this.comboBoxDPI.TabIndex = 6;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.PaleGreen;
            this.button2.Location = new System.Drawing.Point(608, 103);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(106, 45);
            this.button2.TabIndex = 7;
            this.button2.Text = "Guardar Propiedad";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Propiedad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(754, 227);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.comboBoxDPI);
            this.Controls.Add(this.textBoxCuotaMan);
            this.Controls.Add(this.textBoxNCasa);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Propiedad";
            this.Text = "Propiedad";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxNCasa;
        private System.Windows.Forms.TextBox textBoxCuotaMan;
        private System.Windows.Forms.ComboBox comboBoxDPI;
        private System.Windows.Forms.Button button2;
    }
}