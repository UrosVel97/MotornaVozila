using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MotornaVozila.Forme
{
    public partial class ObrisiVlasnika : Form
    {
        public ObrisiVlasnika()
        {
            InitializeComponent();
        }

        private void btnObrisiRegisrovanog_Click(object sender, EventArgs e)
        {
            ObrisiRegistrovanogKupca forma = new ObrisiRegistrovanogKupca();
            this.Visible = false;
            forma.ShowDialog();
            this.Visible = true;
            this.DialogResult = DialogResult.OK;
        }

        private void btnObrisiNeregistrovanog_Click(object sender, EventArgs e)
        {
            ObrisiNeregistrovanogKupca forma = new ObrisiNeregistrovanogKupca();
            this.Visible = false;
            forma.ShowDialog();
            this.Visible = true;
            this.DialogResult = DialogResult.OK;
        }
    }
}
