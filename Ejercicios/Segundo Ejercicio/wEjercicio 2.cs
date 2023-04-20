using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Segundo_Ejercicio
{ 
    public partial class fmrEjercicio2 : Form
    {
        int X;
        public fmrEjercicio2()
        {
            InitializeComponent();
        }

        private void txtIngresarNumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '-'))
            {
                e.Handled = true;
            }
        }

        private void btnEvaluar_Click(object sender, EventArgs e)
        {
            X = int.Parse(txtIngresarNumero.Text);

            if (X%2 == 0)
            {
                lblResultado.Visible = true;
                lblResultado.Text = "El número " + X + " es par";
            }
            else
            {
                lblResultado.Visible = true;
                lblResultado.Text = "El número " + X + " es impar";
            }
        }
    }
}
