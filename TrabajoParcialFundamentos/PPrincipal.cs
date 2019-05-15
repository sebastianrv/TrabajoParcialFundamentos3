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
    public partial class PPrincipal : Form
    {
        public PPrincipal()
        {
            InitializeComponent();
        }

        private void pctBoxAdministrador_Click(object sender, EventArgs e)
        {
            OpcionAdministrador frm = new OpcionAdministrador();
            frm.Show();
            //PAdministrador frm = new PAdministrador();
            //frm.Show();
        }

        private void pctBoxAdministrador_MouseHover(object sender, EventArgs e)
        {
      //      pctBoxAdministrador.Size = new Size(201,250);
            pctBoxAdministrador.BackgroundImage = Properties.Resources.AdministradorImage2;
            pctBoxAdministrador.BackgroundImageLayout = ImageLayout.Stretch;

        }

        private void pctBoxAdministrador_MouseLeave(object sender, EventArgs e)
        {
    //     pctBoxAdministrador.Size = new Size(201,250);
            pctBoxAdministrador.BackgroundImage = Properties.Resources.AdministradorImage;
            pctBoxAdministrador.BackgroundImageLayout = ImageLayout.Stretch;
        }
        /////////////////////////
        private void pctBoxContribuyente_Click(object sender, EventArgs e)
        {
            OpcionContribuyente frm = new OpcionContribuyente();
            frm.Show();
            //ContribuyenteRegistro frm = new ContribuyenteRegistro();
            //frm.Show();
        }

        private void pctBoxContribuyente_MouseHover(object sender, EventArgs e)
        {
            pctBoxContribuyente.BackgroundImage = Properties.Resources.ContribuyenteImagen2;
            pctBoxContribuyente.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void pctBoxContribuyente_MouseLeave(object sender, EventArgs e)
        {
            pctBoxContribuyente.BackgroundImage = Properties.Resources.ContribuyenteImagen;
            pctBoxContribuyente.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void PPrincipal_Load(object sender, EventArgs e)
        {

        }
    }
}
