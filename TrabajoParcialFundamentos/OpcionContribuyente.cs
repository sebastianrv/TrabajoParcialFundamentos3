using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrabajoParcialFundamentos
{
    public partial class OpcionContribuyente : Form
    {
        public OpcionContribuyente()
        {
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            ContribuyenteRegistro frm = new ContribuyenteRegistro();
            frm.Show();
        }

        private void btnConsultas_Click(object sender, EventArgs e)
        {

        }

        private void pctboxAtras_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            LoginContribuyente frm = new LoginContribuyente();
            frm.Show();
        }
    }
}
