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
    public partial class PCarga : Form
    {
        public PCarga()
        {
            InitializeComponent();
        }
        PictureBox[] circulos;
        int cont = 0;

        private void PCarga_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            circulos = new PictureBox[5] { pctBoxCirc1,pctBoxCircle2,pctBoxCircle3,pctBoxCircle4,pctBoxCircle5 };

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (cont < 1)
            {
                circulos[cont].BackgroundImage = TrabajoParcialFundamentos.Properties.Resources.Circle2;
                cont++;
                labelPorcentaje.Text = (cont * 20) + "%";
            }
            else
            {
                timer1.Enabled = false;
                PPrincipal frm = new PPrincipal();
                frm.Show();
            }
        }
    }
}
