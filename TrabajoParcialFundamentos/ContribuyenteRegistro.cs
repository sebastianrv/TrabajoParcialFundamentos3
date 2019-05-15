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
    public partial class ContribuyenteRegistro : Form
    {
        Cregistrotramites objRegistro = new Cregistrotramites();
        public ContribuyenteRegistro()
        {
            InitializeComponent();
        }

        private void cmBoxMunicipalidad_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmBoxMunicipalidad.SelectedIndex == -1)
            {
                pctBoxMunicipalidad.BackgroundImage = Properties.Resources.logoMunicipalidad;
                pctBoxMunicipalidad.BackgroundImageLayout = ImageLayout.Stretch;
                pctBoxMunicipalidad.BackColor = Color.Transparent;

            }
            if (cmBoxMunicipalidad.Text=="Chorrillos")
            {
                pctBoxMunicipalidad.BackgroundImage = Properties.Resources.Escudo_chorrillos;
                pctBoxMunicipalidad.BackgroundImageLayout = ImageLayout.Stretch;
            }
            if (cmBoxMunicipalidad.Text=="Santiago de Surco")
            {
                pctBoxMunicipalidad.BackgroundImage = Properties.Resources.Escudo_de_Santiago_de_Surco;
                pctBoxMunicipalidad.BackgroundImageLayout = ImageLayout.Stretch;
            }
            if (cmBoxMunicipalidad.Text=="San Juan Miraflores")
            {
                pctBoxMunicipalidad.BackgroundImage = Properties.Resources.Escudo_SJM;
                pctBoxMunicipalidad.BackgroundImageLayout = ImageLayout.Stretch;
            }
            if (cmBoxMunicipalidad.Text=="San Isidro")
            {
                pctBoxMunicipalidad.BackgroundImage = Properties.Resources.Escudo_Distrito_San_Isidro;
                pctBoxMunicipalidad.BackgroundImageLayout = ImageLayout.Stretch;
                cmBoxDomicilio.Items.Add("Av. Dos de mayo");
            }
        }

        private void ContribuyenteRegistro_Load(object sender, EventArgs e)
        {
            cmBoxMunicipalidad.DisplayMember = "nombre";
            cmBoxMunicipalidad.ValueMember = "nombre";
            cmBoxMunicipalidad.DataSource = Cregistrotramites.Municipalidades;//lista
           cmBoxMunicipalidad.SelectedIndex = -1;
      
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            Ccontribuyente objContribuyente = new Ccontribuyente();
            objContribuyente.nombreCon = txboxNombre.Text;
            objContribuyente.domicilioCon = cmBoxDomicilio.Text;
            objContribuyente.DNI = txboxDNI.Text;
            objRegistro.registrar_contribu_en_muni(((Cmunicipalidad)cmBoxMunicipalidad.SelectedItem).nombre, objContribuyente);
            //////
            txboxNombre.Clear();
            txboxDNI.Clear();
            cmBoxMunicipalidad.SelectedIndex = -1;

            //LoginContribuyente flogin= new LoginContribuyente();
            //flogin.txboxDNI.Text = txboxDNI.Text;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
