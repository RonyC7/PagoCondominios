namespace PagoCondominios
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.buttonPropietario = new System.Windows.Forms.Button();
            this.buttonPropiedad = new System.Windows.Forms.Button();
            this.buttonDatosPropietario = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonPropietario
            // 
            this.buttonPropietario.BackColor = System.Drawing.Color.LightSkyBlue;
            this.buttonPropietario.Location = new System.Drawing.Point(102, 37);
            this.buttonPropietario.Name = "buttonPropietario";
            this.buttonPropietario.Size = new System.Drawing.Size(116, 42);
            this.buttonPropietario.TabIndex = 0;
            this.buttonPropietario.Text = "Agregar Propietario";
            this.buttonPropietario.UseVisualStyleBackColor = false;
            this.buttonPropietario.Click += new System.EventHandler(this.buttonPropietario_Click);
            // 
            // buttonPropiedad
            // 
            this.buttonPropiedad.BackColor = System.Drawing.Color.LightGreen;
            this.buttonPropiedad.Location = new System.Drawing.Point(438, 37);
            this.buttonPropiedad.Name = "buttonPropiedad";
            this.buttonPropiedad.Size = new System.Drawing.Size(112, 42);
            this.buttonPropiedad.TabIndex = 1;
            this.buttonPropiedad.Text = "Agregar Propiedad";
            this.buttonPropiedad.UseVisualStyleBackColor = false;
            this.buttonPropiedad.Click += new System.EventHandler(this.buttonPropiedad_Click);
            // 
            // buttonDatosPropietario
            // 
            this.buttonDatosPropietario.BackColor = System.Drawing.Color.PaleVioletRed;
            this.buttonDatosPropietario.Location = new System.Drawing.Point(273, 106);
            this.buttonDatosPropietario.Name = "buttonDatosPropietario";
            this.buttonDatosPropietario.Size = new System.Drawing.Size(117, 52);
            this.buttonDatosPropietario.TabIndex = 2;
            this.buttonDatosPropietario.Text = "Mostrar Datos Propietario";
            this.buttonDatosPropietario.UseVisualStyleBackColor = false;
            this.buttonDatosPropietario.Click += new System.EventHandler(this.buttonDatosPropietario_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(678, 246);
            this.Controls.Add(this.buttonDatosPropietario);
            this.Controls.Add(this.buttonPropiedad);
            this.Controls.Add(this.buttonPropietario);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Formulario Principal";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonPropietario;
        private System.Windows.Forms.Button buttonPropiedad;
        private System.Windows.Forms.Button buttonDatosPropietario;
    }
}

