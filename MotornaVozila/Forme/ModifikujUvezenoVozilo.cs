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
    public partial class ModifikujUvezenoVozilo : Form
    {
        public ModifikujUvezenoVozilo()
        {
            InitializeComponent();
        }

        private void btnModifikujProdatoVozilo_Click(object sender, EventArgs e)
        {
            ModifikujVoziloKojeJeProdato forma = new ModifikujVoziloKojeJeProdato();

            this.Visible = false;
            forma.ShowDialog();
            this.Visible = true;

            this.DialogResult = DialogResult.OK;
        }

        private void btnModifikujVoziloKojeNijeProdato_Click(object sender, EventArgs e)
        {
            ModifikujVoziloKojeNijeProdato forma = new ModifikujVoziloKojeNijeProdato();

            this.Visible = false;
            forma.ShowDialog();
            this.Visible = true;

            this.DialogResult = DialogResult.OK;
        }
    }
}
