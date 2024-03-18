namespace PagoCondominios
{
    partial class DatosPropietarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DatosPropietarios));
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridViewDatosGenerales = new System.Windows.Forms.DataGridView();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonMDatos = new System.Windows.Forms.Button();
            this.buttonOrden = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDatosGenerales)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Salmon;
            this.button1.Location = new System.Drawing.Point(26, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 29);
            this.button1.TabIndex = 0;
            this.button1.Text = "Regresar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridViewDatosGenerales
            // 
            this.dataGridViewDatosGenerales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDatosGenerales.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dataGridViewDatosGenerales.Location = new System.Drawing.Point(26, 82);
            this.dataGridViewDatosGenerales.Name = "dataGridViewDatosGenerales";
            this.dataGridViewDatosGenerales.RowHeadersWidth = 51;
            this.dataGridViewDatosGenerales.RowTemplate.Height = 24;
            this.dataGridViewDatosGenerales.Size = new System.Drawing.Size(679, 203);
            this.dataGridViewDatosGenerales.TabIndex = 1;
            this.dataGridViewDatosGenerales.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDatosGenerales_CellContentClick);
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.MinimumWidth = 6;
            this.Nombre.Name = "Nombre";
            this.Nombre.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Apellido";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Numero casa";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Cuota Mantenimiento";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 125;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Datos Generales";
            // 
            // buttonMDatos
            // 
            this.buttonMDatos.Location = new System.Drawing.Point(356, 19);
            this.buttonMDatos.Name = "buttonMDatos";
            this.buttonMDatos.Size = new System.Drawing.Size(114, 23);
            this.buttonMDatos.TabIndex = 3;
            this.buttonMDatos.Text = "Mostrar Datos";
            this.buttonMDatos.UseVisualStyleBackColor = true;
            this.buttonMDatos.Click += new System.EventHandler(this.buttonMDatos_Click);
            // 
            // buttonOrden
            // 
            this.buttonOrden.Location = new System.Drawing.Point(576, 18);
            this.buttonOrden.Name = "buttonOrden";
            this.buttonOrden.Size = new System.Drawing.Size(129, 23);
            this.buttonOrden.TabIndex = 4;
            this.buttonOrden.Text = "Orden Mayor Cuota";
            this.buttonOrden.UseVisualStyleBackColor = true;
            this.buttonOrden.Click += new System.EventHandler(this.buttonOrden_Click);
            // 
            // DatosPropietarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonOrden);
            this.Controls.Add(this.buttonMDatos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewDatosGenerales);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DatosPropietarios";
            this.Text = "DatosPropietarios";
            this.Load += new System.EventHandler(this.DatosPropietarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDatosGenerales)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridViewDatosGenerales;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonMDatos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.Button buttonOrden;
    }
}