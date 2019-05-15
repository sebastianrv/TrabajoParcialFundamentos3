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
    public partial class PAdministrador : Form
    {
        string id = "a";//Admin1234
        string pass = "7";//71517267
        public PAdministrador()
        {
            InitializeComponent();
            textBoxPassword.PasswordChar = '*';
            textBoxPassword.MaxLength = 7;
            textBoxID.MaxLength = 10;
        }

        private void pctBtnLogin_Click(object sender, EventArgs e)
        {
            //nooo borrar
        }

        private void PAdministrador_Load(object sender, EventArgs e)
        {
            lblFecha.Text = DateTime.Now.ToLongDateString();
            lblHora.Text = DateTime.Now.ToLongTimeString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToLongTimeString();

        }

        private void pctBtnLogin_Click_1(object sender, EventArgs e)
        {
            if (textBoxID.Text == id && textBoxPassword.Text == pass)
            {
                Hide();
                MessageBox.Show("Bienvenido ....");
                Close();
                AdministradorRegistro frm = new AdministradorRegistro();
                frm.Show();


            }
            else
            {
                if (textBoxID.Text == "" && textBoxPassword.Text == "")
                {
                    MessageBox.Show("Ingrese Datos");
                    textBoxID.Focus();
                }
                else
                {
                    MessageBox.Show("Datos ingresados invalidos");
                    textBoxID.Clear();
                    textBoxPassword.Clear();
                    textBoxID.Focus();
                }
            }
        }

        private void pctboxAtras_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
