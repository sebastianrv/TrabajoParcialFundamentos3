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
    public partial class AdministradorRegistro : Form
    {
        Cregistrotramites objRegistro = new Cregistrotramites();

        public AdministradorRegistro()
        {
            InitializeComponent();
        }

        private void buttonRegistrar_Click(object sender, EventArgs e)
        {

            if (comboBoxDistrito.Text != "")
                if (!objRegistro.existe_municipalidad(comboBoxDistrito.Text))
                {
                    Cmunicipalidad objMuni = new Cmunicipalidad();

                    objMuni.nombre = comboBoxDistrito.Text;
                    objMuni.tipo[0] = checkBoxLIndeterminada.Text;
                    objMuni.tipo[1] = checkBoxLTemporal.Text;
                    objRegistro.registrar_muni(objMuni);
                }
            comboBoxDistrito.Items.Remove(comboBoxDistrito.SelectedItem);
                checkBoxLIndeterminada.Checked = false;
                checkBoxLTemporal.Checked = false;

            
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
