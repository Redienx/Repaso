using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tercer_Ejercicio
{
    public partial class fmrEjecicio3 : Form
    {
        double bHipotenusa;
        double bCateto;
        double bCateto2;
        double bResultado;
        public fmrEjecicio3()
        {
            InitializeComponent();
        }

        private void btnCateto_Click(object sender, EventArgs e)
        {
            gbxCateto.Visible = true;
            gbxHipotenusa.Visible = false;
        }

        private void btnHipotenusa_Click(object sender, EventArgs e)
        {
            gbxCateto.Visible = false;
            gbxHipotenusa.Visible = true;
        }

        private void txtHipotenusa_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void txtCateto1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void txtCateto2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void btnMandarCateto_Click(object sender, EventArgs e)
        {
            bHipotenusa = double.Parse(txtHipotenusa.Text);
            bCateto = double.Parse(txtCateto.Text);

            bCateto2 = (Math.Pow(bHipotenusa, 2)) - (Math.Pow(bCateto, 2));
            bResultado = Math.Sqrt(bCateto2);
            lblResultadoCateto.Visible = true;
            lblResultadoCateto.Text = "El cateto vale " + bResultado.ToString();

        }

        private void btnMandarHipotenusa_Click(object sender, EventArgs e)
        {
            bCateto = double.Parse(txtCateto1.Text);
            bCateto2 = double.Parse(txtCateto2.Text);

            bHipotenusa = Math.Pow(bCateto, 2) + Math.Pow(bCateto2, 2);
            bResultado = Math.Sqrt(bHipotenusa);
            lblResultadoHipotenusa.Visible = true;
            lblResultadoHipotenusa.Text = "La hipotenusa vale " + bResultado.ToString();
        }
    }
}
