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
    public partial class LoginContribuyente : Form
    {
        
          
        public LoginContribuyente()
        {
            InitializeComponent();
            
        }

        private void LoginContribuyente_Load(object sender, EventArgs e)
        {
            lblFecha.Text = DateTime.Now.ToLongDateString();
            lblHora.Text = DateTime.Now.ToLongTimeString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToLongTimeString();
        }

        private void pctboxAtras_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void pcboxIniciarSesion_Click(object sender, EventArgs e)
        {
            Cregistrotramites objges = new Cregistrotramites();   
            Ccontribuyente objContri = new Ccontribuyente();
            //foreach(Cmunicipalidad item in municipalidades)
            
            if (objges.verificar_dni( txboxDNI.Text))
            {
                if (objContri.DNI == "")
                {
                    MessageBox.Show("Ingrese Datos");

                }
                else
                {
                    MessageBox.Show("Datos ingresados invalidos");
                }
             
            }
            else
            {
                Hide();
                MessageBox.Show("Bienvenido ....");
                Close();
                RegistrarTramiteContribuyente frm = new RegistrarTramiteContribuyente();
                frm.Show();
            }
        }
    }
}
