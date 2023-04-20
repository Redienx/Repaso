namespace Tercer_Ejercicio
{
    partial class fmrEjecicio3
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
            this.btnHipotenusa = new System.Windows.Forms.Button();
            this.btnCateto = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblHipotenusa = new System.Windows.Forms.Label();
            this.txtHipotenusa = new System.Windows.Forms.TextBox();
            this.txtCateto = new System.Windows.Forms.TextBox();
            this.lblCateto = new System.Windows.Forms.Label();
            this.btnMandarCateto = new System.Windows.Forms.Button();
            this.lblResultadoCateto = new System.Windows.Forms.Label();
            this.lblResultadoHipotenusa = new System.Windows.Forms.Label();
            this.btnMandarHipotenusa = new System.Windows.Forms.Button();
            this.txtCateto2 = new System.Windows.Forms.TextBox();
            this.lblCateto2 = new System.Windows.Forms.Label();
            this.txtCateto1 = new System.Windows.Forms.TextBox();
            this.lblCateto1 = new System.Windows.Forms.Label();
            this.lblTituloCateto = new System.Windows.Forms.Label();
            this.lblTituloHipotenusa = new System.Windows.Forms.Label();
            this.gbxCateto = new System.Windows.Forms.GroupBox();
            this.gbxHipotenusa = new System.Windows.Forms.GroupBox();
            this.gbxCateto.SuspendLayout();
            this.gbxHipotenusa.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnHipotenusa
            // 
            this.btnHipotenusa.Location = new System.Drawing.Point(382, 55);
            this.btnHipotenusa.Name = "btnHipotenusa";
            this.btnHipotenusa.Size = new System.Drawing.Size(97, 41);
            this.btnHipotenusa.TabIndex = 0;
            this.btnHipotenusa.Text = "Hipotenusa";
            this.btnHipotenusa.UseVisualStyleBackColor = true;
            this.btnHipotenusa.Click += new System.EventHandler(this.btnHipotenusa_Click);
            // 
            // btnCateto
            // 
            this.btnCateto.Location = new System.Drawing.Point(257, 55);
            this.btnCateto.Name = "btnCateto";
            this.btnCateto.Size = new System.Drawing.Size(97, 41);
            this.btnCateto.TabIndex = 1;
            this.btnCateto.Text = "Cateto";
            this.btnCateto.UseVisualStyleBackColor = true;
            this.btnCateto.Click += new System.EventHandler(this.btnCateto_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(230, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(277, 29);
            this.lblTitulo.TabIndex = 2;
            this.lblTitulo.Text = "¿Qué quieres encontrar?";
            // 
            // lblHipotenusa
            // 
            this.lblHipotenusa.AutoSize = true;
            this.lblHipotenusa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHipotenusa.Location = new System.Drawing.Point(0, 83);
            this.lblHipotenusa.Name = "lblHipotenusa";
            this.lblHipotenusa.Size = new System.Drawing.Size(178, 20);
            this.lblHipotenusa.TabIndex = 3;
            this.lblHipotenusa.Text = "Ingresar la Hipotenusa";
            // 
            // txtHipotenusa
            // 
            this.txtHipotenusa.Location = new System.Drawing.Point(197, 83);
            this.txtHipotenusa.Name = "txtHipotenusa";
            this.txtHipotenusa.Size = new System.Drawing.Size(126, 22);
            this.txtHipotenusa.TabIndex = 4;
            this.txtHipotenusa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtHipotenusa_KeyPress);
            // 
            // txtCateto
            // 
            this.txtCateto.Location = new System.Drawing.Point(197, 113);
            this.txtCateto.Name = "txtCateto";
            this.txtCateto.Size = new System.Drawing.Size(126, 22);
            this.txtCateto.TabIndex = 6;
            this.txtCateto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // lblCateto
            // 
            this.lblCateto.AutoSize = true;
            this.lblCateto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.lblCateto.Location = new System.Drawing.Point(40, 113);
            this.lblCateto.Name = "lblCateto";
            this.lblCateto.Size = new System.Drawing.Size(142, 20);
            this.lblCateto.TabIndex = 5;
            this.lblCateto.Text = "Ingresar el Cateto\r\n";
            // 
            // btnMandarCateto
            // 
            this.btnMandarCateto.Location = new System.Drawing.Point(100, 152);
            this.btnMandarCateto.Name = "btnMandarCateto";
            this.btnMandarCateto.Size = new System.Drawing.Size(117, 44);
            this.btnMandarCateto.TabIndex = 8;
            this.btnMandarCateto.Text = "Mandar Valores";
            this.btnMandarCateto.UseVisualStyleBackColor = true;
            this.btnMandarCateto.Click += new System.EventHandler(this.btnMandarCateto_Click);
            // 
            // lblResultadoCateto
            // 
            this.lblResultadoCateto.AutoSize = true;
            this.lblResultadoCateto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultadoCateto.Location = new System.Drawing.Point(82, 213);
            this.lblResultadoCateto.Name = "lblResultadoCateto";
            this.lblResultadoCateto.Size = new System.Drawing.Size(147, 25);
            this.lblResultadoCateto.TabIndex = 10;
            this.lblResultadoCateto.Text = "El cateto vale X";
            this.lblResultadoCateto.Visible = false;
            // 
            // lblResultadoHipotenusa
            // 
            this.lblResultadoHipotenusa.AutoSize = true;
            this.lblResultadoHipotenusa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultadoHipotenusa.Location = new System.Drawing.Point(103, 213);
            this.lblResultadoHipotenusa.Name = "lblResultadoHipotenusa";
            this.lblResultadoHipotenusa.Size = new System.Drawing.Size(195, 25);
            this.lblResultadoHipotenusa.TabIndex = 16;
            this.lblResultadoHipotenusa.Text = "La hipotenusa vale X";
            this.lblResultadoHipotenusa.Visible = false;
            // 
            // btnMandarHipotenusa
            // 
            this.btnMandarHipotenusa.Location = new System.Drawing.Point(152, 152);
            this.btnMandarHipotenusa.Name = "btnMandarHipotenusa";
            this.btnMandarHipotenusa.Size = new System.Drawing.Size(117, 44);
            this.btnMandarHipotenusa.TabIndex = 15;
            this.btnMandarHipotenusa.Text = "Mandar Valores";
            this.btnMandarHipotenusa.UseVisualStyleBackColor = true;
            this.btnMandarHipotenusa.Click += new System.EventHandler(this.btnMandarHipotenusa_Click);
            // 
            // txtCateto2
            // 
            this.txtCateto2.Location = new System.Drawing.Point(244, 109);
            this.txtCateto2.Name = "txtCateto2";
            this.txtCateto2.Size = new System.Drawing.Size(135, 22);
            this.txtCateto2.TabIndex = 14;
            this.txtCateto2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCateto2_KeyPress);
            // 
            // lblCateto2
            // 
            this.lblCateto2.AutoSize = true;
            this.lblCateto2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.lblCateto2.Location = new System.Drawing.Point(6, 111);
            this.lblCateto2.Name = "lblCateto2";
            this.lblCateto2.Size = new System.Drawing.Size(210, 20);
            this.lblCateto2.TabIndex = 13;
            this.lblCateto2.Text = "Ingresar el segundo Cateto\r\n";
            // 
            // txtCateto1
            // 
            this.txtCateto1.Location = new System.Drawing.Point(244, 85);
            this.txtCateto1.Name = "txtCateto1";
            this.txtCateto1.Size = new System.Drawing.Size(135, 22);
            this.txtCateto1.TabIndex = 12;
            this.txtCateto1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCateto1_KeyPress);
            // 
            // lblCateto1
            // 
            this.lblCateto1.AutoSize = true;
            this.lblCateto1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.lblCateto1.Location = new System.Drawing.Point(23, 85);
            this.lblCateto1.Name = "lblCateto1";
            this.lblCateto1.Size = new System.Drawing.Size(195, 20);
            this.lblCateto1.TabIndex = 11;
            this.lblCateto1.Text = "Ingresar el primer Cateto";
            // 
            // lblTituloCateto
            // 
            this.lblTituloCateto.AutoSize = true;
            this.lblTituloCateto.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloCateto.Location = new System.Drawing.Point(43, 27);
            this.lblTituloCateto.Name = "lblTituloCateto";
            this.lblTituloCateto.Size = new System.Drawing.Size(192, 29);
            this.lblTituloCateto.TabIndex = 17;
            this.lblTituloCateto.Text = "Encontrar Cateto";
            // 
            // lblTituloHipotenusa
            // 
            this.lblTituloHipotenusa.AutoSize = true;
            this.lblTituloHipotenusa.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloHipotenusa.Location = new System.Drawing.Point(88, 27);
            this.lblTituloHipotenusa.Name = "lblTituloHipotenusa";
            this.lblTituloHipotenusa.Size = new System.Drawing.Size(244, 29);
            this.lblTituloHipotenusa.TabIndex = 18;
            this.lblTituloHipotenusa.Text = "Encontrar Hipotenusa\r\n";
            // 
            // gbxCateto
            // 
            this.gbxCateto.Controls.Add(this.txtHipotenusa);
            this.gbxCateto.Controls.Add(this.lblTituloCateto);
            this.gbxCateto.Controls.Add(this.lblHipotenusa);
            this.gbxCateto.Controls.Add(this.lblCateto);
            this.gbxCateto.Controls.Add(this.txtCateto);
            this.gbxCateto.Controls.Add(this.btnMandarCateto);
            this.gbxCateto.Controls.Add(this.lblResultadoCateto);
            this.gbxCateto.Location = new System.Drawing.Point(12, 114);
            this.gbxCateto.Name = "gbxCateto";
            this.gbxCateto.Size = new System.Drawing.Size(329, 254);
            this.gbxCateto.TabIndex = 19;
            this.gbxCateto.TabStop = false;
            this.gbxCateto.Visible = false;
            // 
            // gbxHipotenusa
            // 
            this.gbxHipotenusa.Controls.Add(this.txtCateto2);
            this.gbxHipotenusa.Controls.Add(this.txtCateto1);
            this.gbxHipotenusa.Controls.Add(this.lblTituloHipotenusa);
            this.gbxHipotenusa.Controls.Add(this.lblResultadoHipotenusa);
            this.gbxHipotenusa.Controls.Add(this.lblCateto1);
            this.gbxHipotenusa.Controls.Add(this.btnMandarHipotenusa);
            this.gbxHipotenusa.Controls.Add(this.lblCateto2);
            this.gbxHipotenusa.Location = new System.Drawing.Point(376, 114);
            this.gbxHipotenusa.Name = "gbxHipotenusa";
            this.gbxHipotenusa.Size = new System.Drawing.Size(385, 254);
            this.gbxHipotenusa.TabIndex = 20;
            this.gbxHipotenusa.TabStop = false;
            this.gbxHipotenusa.Visible = false;
            // 
            // fmrEjecicio3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.btnCateto);
            this.Controls.Add(this.btnHipotenusa);
            this.Controls.Add(this.gbxCateto);
            this.Controls.Add(this.gbxHipotenusa);
            this.Name = "fmrEjecicio3";
            this.Text = "Ejercicio 3";
            this.gbxCateto.ResumeLayout(false);
            this.gbxCateto.PerformLayout();
            this.gbxHipotenusa.ResumeLayout(false);
            this.gbxHipotenusa.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnHipotenusa;
        private System.Windows.Forms.Button btnCateto;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblHipotenusa;
        private System.Windows.Forms.TextBox txtHipotenusa;
        private System.Windows.Forms.TextBox txtCateto;
        private System.Windows.Forms.Label lblCateto;
        private System.Windows.Forms.Button btnMandarCateto;
        private System.Windows.Forms.Label lblResultadoCateto;
        private System.Windows.Forms.Label lblResultadoHipotenusa;
        private System.Windows.Forms.Button btnMandarHipotenusa;
        private System.Windows.Forms.TextBox txtCateto2;
        private System.Windows.Forms.Label lblCateto2;
        private System.Windows.Forms.TextBox txtCateto1;
        private System.Windows.Forms.Label lblCateto1;
        private System.Windows.Forms.Label lblTituloCateto;
        private System.Windows.Forms.Label lblTituloHipotenusa;
        public System.Windows.Forms.GroupBox gbxCateto;
        public System.Windows.Forms.GroupBox gbxHipotenusa;
    }
}

