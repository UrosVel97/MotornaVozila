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
    public partial class DodajUvezenoVozilo : Form
    {
        public DodajUvezenoVozilo()
        {
            InitializeComponent();
        }

        private void btnDodajVoziloKojeNijeProdato_Click(object sender, EventArgs e)
        {
            DodajVoziloKojeNijeProdato forma = new DodajVoziloKojeNijeProdato();

            this.Visible = false;
            forma.ShowDialog();
            this.Visible = true;

            this.DialogResult = DialogResult.OK;
        }

        private void btnDodajVoziloKojeJeProdato_Click(object sender, EventArgs e)
        {
            DodajVoziloKojeJeProdato forma = new DodajVoziloKojeJeProdato();

            this.Visible = false;
            forma.ShowDialog();
            this.Visible = true;
            this.DialogResult = DialogResult.OK;
        }
    }
}
