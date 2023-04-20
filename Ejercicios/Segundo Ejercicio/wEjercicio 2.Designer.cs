namespace Segundo_Ejercicio
{
    partial class fmrEjercicio2
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
            this.lblResultado = new System.Windows.Forms.Label();
            this.lblIngresarNumero = new System.Windows.Forms.Label();
            this.txtIngresarNumero = new System.Windows.Forms.TextBox();
            this.btnEvaluar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(308, 299);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(135, 16);
            this.lblResultado.TabIndex = 7;
            this.lblResultado.Text = "El numero es positivo";
            this.lblResultado.Visible = false;
            // 
            // lblIngresarNumero
            // 
            this.lblIngresarNumero.AutoSize = true;
            this.lblIngresarNumero.Location = new System.Drawing.Point(195, 184);
            this.lblIngresarNumero.Name = "lblIngresarNumero";
            this.lblIngresarNumero.Size = new System.Drawing.Size(110, 16);
            this.lblIngresarNumero.TabIndex = 6;
            this.lblIngresarNumero.Text = "Ingresar Numero:";
            // 
            // txtIngresarNumero
            // 
            this.txtIngresarNumero.Location = new System.Drawing.Point(311, 181);
            this.txtIngresarNumero.Name = "txtIngresarNumero";
            this.txtIngresarNumero.Size = new System.Drawing.Size(125, 22);
            this.txtIngresarNumero.TabIndex = 5;
            this.txtIngresarNumero.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIngresarNumero_KeyPress);
            // 
            // btnEvaluar
            // 
            this.btnEvaluar.Location = new System.Drawing.Point(326, 240);
            this.btnEvaluar.Name = "btnEvaluar";
            this.btnEvaluar.Size = new System.Drawing.Size(85, 30);
            this.btnEvaluar.TabIndex = 4;
            this.btnEvaluar.Text = "Evaluar";
            this.btnEvaluar.UseVisualStyleBackColor = true;
            this.btnEvaluar.Click += new System.EventHandler(this.btnEvaluar_Click);
            // 
            // fmrEjercicio2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.lblIngresarNumero);
            this.Controls.Add(this.txtIngresarNumero);
            this.Controls.Add(this.btnEvaluar);
            this.Name = "fmrEjercicio2";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Label lblIngresarNumero;
        private System.Windows.Forms.TextBox txtIngresarNumero;
        private System.Windows.Forms.Button btnEvaluar;
    }
}

