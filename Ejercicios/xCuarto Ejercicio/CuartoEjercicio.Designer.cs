namespace xCuarto_Ejercicio
{
    partial class fmrCuartoEjercicio
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
            this.components = new System.ComponentModel.Container();
            this.tmr1 = new System.Windows.Forms.Timer(this.components);
            this.lblContador = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnComenzar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tmr1
            // 
            this.tmr1.Tick += new System.EventHandler(this.tmr1_Tick);
            // 
            // lblContador
            // 
            this.lblContador.AutoSize = true;
            this.lblContador.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContador.Location = new System.Drawing.Point(324, 165);
            this.lblContador.Name = "lblContador";
            this.lblContador.Size = new System.Drawing.Size(124, 135);
            this.lblContador.TabIndex = 0;
            this.lblContador.Text = "0";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(165, 82);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(436, 52);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "Numeros del 0 al 100";
            // 
            // btnComenzar
            // 
            this.btnComenzar.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnComenzar.Location = new System.Drawing.Point(258, 328);
            this.btnComenzar.Name = "btnComenzar";
            this.btnComenzar.Size = new System.Drawing.Size(253, 79);
            this.btnComenzar.TabIndex = 2;
            this.btnComenzar.Text = "Comenzar";
            this.btnComenzar.UseVisualStyleBackColor = true;
            this.btnComenzar.Click += new System.EventHandler(this.btnComenzar_Click);
            // 
            // fmrCuartoEjercicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnComenzar);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.lblContador);
            this.Name = "fmrCuartoEjercicio";
            this.Text = "Cuarto Ejercicio";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer tmr1;
        private System.Windows.Forms.Label lblContador;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnComenzar;
    }
}

