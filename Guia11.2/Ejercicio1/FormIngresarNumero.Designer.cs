namespace Ejemplo1
{
    partial class FormIngresarNumero
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
            this.tbNumero = new System.Windows.Forms.TextBox();
            this.btnAgregarNumero = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbNumero);
            this.groupBox1.Location = new System.Drawing.Point(20, 20);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(6);
            this.groupBox1.Size = new System.Drawing.Size(242, 71);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ingresar número";
            // 
            // tbNumero
            // 
            this.tbNumero.Location = new System.Drawing.Point(21, 31);
            this.tbNumero.Margin = new System.Windows.Forms.Padding(6);
            this.tbNumero.Name = "tbNumero";
            this.tbNumero.Size = new System.Drawing.Size(196, 26);
            this.tbNumero.TabIndex = 1;
            // 
            // btnAgregarNumero
            // 
            this.btnAgregarNumero.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnAgregarNumero.Location = new System.Drawing.Point(79, 99);
            this.btnAgregarNumero.Margin = new System.Windows.Forms.Padding(6);
            this.btnAgregarNumero.Name = "btnAgregarNumero";
            this.btnAgregarNumero.Size = new System.Drawing.Size(127, 48);
            this.btnAgregarNumero.TabIndex = 2;
            this.btnAgregarNumero.Text = "Agregar Número";
            this.btnAgregarNumero.UseVisualStyleBackColor = true;
            // 
            // FormIngresarNumero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(270, 154);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnAgregarNumero);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormIngresarNumero";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormIngresarNumero";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAgregarNumero;
        public System.Windows.Forms.TextBox tbNumero;
    }
}