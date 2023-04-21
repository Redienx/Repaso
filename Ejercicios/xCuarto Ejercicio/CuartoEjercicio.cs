using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace xCuarto_Ejercicio
{
    public partial class fmrCuartoEjercicio : Form
    {
        int nX = 0;
        public fmrCuartoEjercicio()
        {
            InitializeComponent();
        }

        private void btnComenzar_Click(object sender, EventArgs e)
        {
            tmr1.Start();
        }

        private void tmr1_Tick(object sender, EventArgs e)
            {
                nX++;
                lblContador.Text = nX.ToString();
            if (nX == 100)
            {
                tmr1.Stop();
        }
        }
    }
}
