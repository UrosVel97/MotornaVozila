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
    public partial class DodajVlasnika : Form
    {
        public DodajVlasnika()
        {
            InitializeComponent();
        }

        private void btnDodajRegistrovanogKupca_Click(object sender, EventArgs e)
        {
            DodajRegistrovanogKupca forma = new DodajRegistrovanogKupca();
            this.Visible = false;
            forma.ShowDialog();
            this.Visible = true;
            this.DialogResult = DialogResult.OK;
        }

        private void btnDodajNeregistrovanogKupca_Click(object sender, EventArgs e)
        {
            DodajNergistrovanogKupca forma = new DodajNergistrovanogKupca();
            this.Visible = false;
            forma.ShowDialog();
            this.Visible = true;
            this.DialogResult = DialogResult.OK;
        }
    }
}
