namespace Ejemplo1
{
    partial class FormPrincipal
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
            this.btnAgregarNumero = new System.Windows.Forms.Button();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnListar = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.rbBinaria = new System.Windows.Forms.RadioButton();
            this.rbSecuencial = new System.Windows.Forms.RadioButton();
            this.tbBusqueda = new System.Windows.Forms.TextBox();
            this.btnBusqueda = new System.Windows.Forms.Button();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAgregarNumero
            // 
            this.btnAgregarNumero.Location = new System.Drawing.Point(10, 14);
            this.btnAgregarNumero.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAgregarNumero.Name = "btnAgregarNumero";
            this.btnAgregarNumero.Size = new System.Drawing.Size(88, 52);
            this.btnAgregarNumero.TabIndex = 2;
            this.btnAgregarNumero.Text = "Agregar Número";
            this.btnAgregarNumero.UseVisualStyleBackColor = true;
            this.btnAgregarNumero.Click += new System.EventHandler(this.btnAgregarNumero_Click);
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(116, 14);
            this.btnCalcular.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(85, 52);
            this.btnCalcular.TabIndex = 3;
            this.btnCalcular.Text = "Mostrar Promedio";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnListar
            // 
            this.btnListar.Location = new System.Drawing.Point(224, 14);
            this.btnListar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(90, 52);
            this.btnListar.TabIndex = 8;
            this.btnListar.Text = "Ver listado";
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.groupBox5);
            this.groupBox4.Controls.Add(this.tbBusqueda);
            this.groupBox4.Controls.Add(this.btnBusqueda);
            this.groupBox4.Location = new System.Drawing.Point(13, 74);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox4.Size = new System.Drawing.Size(318, 189);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Búsqueda de número";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.rbBinaria);
            this.groupBox5.Controls.Add(this.rbSecuencial);
            this.groupBox5.Location = new System.Drawing.Point(20, 79);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox5.Size = new System.Drawing.Size(183, 100);
            this.groupBox5.TabIndex = 5;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Método de búsqueda";
            // 
            // rbBinaria
            // 
            this.rbBinaria.AutoSize = true;
            this.rbBinaria.Location = new System.Drawing.Point(28, 65);
            this.rbBinaria.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rbBinaria.Name = "rbBinaria";
            this.rbBinaria.Size = new System.Drawing.Size(76, 24);
            this.rbBinaria.TabIndex = 6;
            this.rbBinaria.TabStop = true;
            this.rbBinaria.Text = "Binaria";
            this.rbBinaria.UseVisualStyleBackColor = true;
            // 
            // rbSecuencial
            // 
            this.rbSecuencial.AutoSize = true;
            this.rbSecuencial.Location = new System.Drawing.Point(28, 29);
            this.rbSecuencial.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rbSecuencial.Name = "rbSecuencial";
            this.rbSecuencial.Size = new System.Drawing.Size(105, 24);
            this.rbSecuencial.TabIndex = 5;
            this.rbSecuencial.TabStop = true;
            this.rbSecuencial.Text = "Secuencial";
            this.rbSecuencial.UseVisualStyleBackColor = true;
            // 
            // tbBusqueda
            // 
            this.tbBusqueda.Location = new System.Drawing.Point(20, 42);
            this.tbBusqueda.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbBusqueda.Name = "tbBusqueda";
            this.tbBusqueda.Size = new System.Drawing.Size(148, 26);
            this.tbBusqueda.TabIndex = 4;
            // 
            // btnBusqueda
            // 
            this.btnBusqueda.Location = new System.Drawing.Point(203, 29);
            this.btnBusqueda.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnBusqueda.Name = "btnBusqueda";
            this.btnBusqueda.Size = new System.Drawing.Size(98, 52);
            this.btnBusqueda.TabIndex = 7;
            this.btnBusqueda.Text = "Búsqueda";
            this.btnBusqueda.UseVisualStyleBackColor = true;
            this.btnBusqueda.Click += new System.EventHandler(this.btnBusqueda_Click);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 270);
            this.Controls.Add(this.btnAgregarNumero);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.btnListar);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormPrincipal";
            this.Text = "Ejercicio1";
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAgregarNumero;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox tbBusqueda;
        private System.Windows.Forms.Button btnBusqueda;
        private System.Windows.Forms.RadioButton rbBinaria;
        private System.Windows.Forms.RadioButton rbSecuencial;
        private System.Windows.Forms.GroupBox groupBox5;
    }
}

