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
    public partial class ModifikujVlasnika : Form
    {
        public ModifikujVlasnika()
        {
            InitializeComponent();
        }

        private void btnModifikujNeregistrovanogKupca_Click(object sender, EventArgs e)
        {
            ModifikujNeregistrovanogKupca forma = new ModifikujNeregistrovanogKupca();
            this.Visible = false;
            forma.ShowDialog();
            this.Visible = true;
        }

        private void btnModifikujRegistrovanogKupca_Click(object sender, EventArgs e)
        {
            ModifikujRegistrovanogKupca forma = new ModifikujRegistrovanogKupca();
            this.Visible = false;
            forma.ShowDialog();
            this.Visible = true;
        }
    }
}
