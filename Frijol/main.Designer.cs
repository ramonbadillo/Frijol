namespace Frijol
{
    partial class main
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
            this.btnAddNota = new System.Windows.Forms.Button();
            this.btnEntradas = new System.Windows.Forms.Button();
            this.btnSalidas = new System.Windows.Forms.Button();
            this.btnTotales = new System.Windows.Forms.Button();
            this.btnTerminar = new System.Windows.Forms.Button();
            this.btnEmpleados = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAddNota
            // 
            this.btnAddNota.Location = new System.Drawing.Point(10, 12);
            this.btnAddNota.Name = "btnAddNota";
            this.btnAddNota.Size = new System.Drawing.Size(82, 75);
            this.btnAddNota.TabIndex = 0;
            this.btnAddNota.Text = "Agregar Nota";
            this.btnAddNota.UseVisualStyleBackColor = true;
            this.btnAddNota.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnEntradas
            // 
            this.btnEntradas.Location = new System.Drawing.Point(10, 93);
            this.btnEntradas.Name = "btnEntradas";
            this.btnEntradas.Size = new System.Drawing.Size(82, 75);
            this.btnEntradas.TabIndex = 1;
            this.btnEntradas.Text = "Entradas";
            this.btnEntradas.UseVisualStyleBackColor = true;
            this.btnEntradas.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnSalidas
            // 
            this.btnSalidas.Location = new System.Drawing.Point(10, 174);
            this.btnSalidas.Name = "btnSalidas";
            this.btnSalidas.Size = new System.Drawing.Size(82, 75);
            this.btnSalidas.TabIndex = 2;
            this.btnSalidas.Text = "Salidas";
            this.btnSalidas.UseVisualStyleBackColor = true;
            this.btnSalidas.Click += new System.EventHandler(this.btnSalidas_Click);
            // 
            // btnTotales
            // 
            this.btnTotales.Location = new System.Drawing.Point(10, 255);
            this.btnTotales.Name = "btnTotales";
            this.btnTotales.Size = new System.Drawing.Size(82, 75);
            this.btnTotales.TabIndex = 3;
            this.btnTotales.Text = "Revisar Totales";
            this.btnTotales.UseVisualStyleBackColor = true;
            this.btnTotales.Click += new System.EventHandler(this.btnTotales_Click);
            // 
            // btnTerminar
            // 
            this.btnTerminar.Location = new System.Drawing.Point(10, 417);
            this.btnTerminar.Name = "btnTerminar";
            this.btnTerminar.Size = new System.Drawing.Size(82, 75);
            this.btnTerminar.TabIndex = 4;
            this.btnTerminar.Text = "Terminar Turno";
            this.btnTerminar.UseVisualStyleBackColor = true;
            this.btnTerminar.Click += new System.EventHandler(this.btnTerminar_Click);
            // 
            // btnEmpleados
            // 
            this.btnEmpleados.Location = new System.Drawing.Point(10, 336);
            this.btnEmpleados.Name = "btnEmpleados";
            this.btnEmpleados.Size = new System.Drawing.Size(82, 75);
            this.btnEmpleados.TabIndex = 5;
            this.btnEmpleados.Text = "Entrada Empleados";
            this.btnEmpleados.UseVisualStyleBackColor = true;
            this.btnEmpleados.Click += new System.EventHandler(this.btnEmpleados_Click);
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(104, 505);
            this.Controls.Add(this.btnEmpleados);
            this.Controls.Add(this.btnTerminar);
            this.Controls.Add(this.btnTotales);
            this.Controls.Add(this.btnSalidas);
            this.Controls.Add(this.btnEntradas);
            this.Controls.Add(this.btnAddNota);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "main";
            this.Text = "Frijol";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.main_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAddNota;
        private System.Windows.Forms.Button btnEntradas;
        private System.Windows.Forms.Button btnSalidas;
        private System.Windows.Forms.Button btnTotales;
        private System.Windows.Forms.Button btnTerminar;
        private System.Windows.Forms.Button btnEmpleados;
    }
}