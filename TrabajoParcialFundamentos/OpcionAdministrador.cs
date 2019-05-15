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
    public partial class OpcionAdministrador : Form
    {
        public OpcionAdministrador()
        {
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            PAdministrador frm = new PAdministrador();
            frm.Show();
            //AdministradorRegistro frm = new AdministradorRegistro();
            //frm.Show();
           
        }

        private void btnConsultas_Click(object sender, EventArgs e)
        {

        }

        private void pctboxAtras_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
