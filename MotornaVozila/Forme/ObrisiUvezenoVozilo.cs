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
    public partial class ObrisiUvezenoVozilo : Form
    {
        public ObrisiUvezenoVozilo()
        {
            InitializeComponent();
        }

        private void btnObrisiVoziloKojeJeProdato_Click(object sender, EventArgs e)
        {
            try
            {
                ObrisiVoziloKojeJeProdato forma = new ObrisiVoziloKojeJeProdato();

                this.Visible = false;
                forma.ShowDialog();
                this.Visible = true;
                this.DialogResult = DialogResult.OK;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnObrisiVoziloKojeNijeProdato_Click(object sender, EventArgs e)
        {
            try
            {
                ObrisiVoziloKojeNijeProdato forma = new ObrisiVoziloKojeNijeProdato();

                this.Visible = false;
                forma.ShowDialog();
                this.Visible = true;
                this.DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
