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
    public partial class ModifikujZaposlenog : Form
    {
        public ModifikujZaposlenog()
        {
            InitializeComponent();
        }

        private void btnModifikujRadnikaTehnickeStruke_Click(object sender, EventArgs e)
        {
            ModifikujRadnikaTehnickeStruke forma = new ModifikujRadnikaTehnickeStruke();

            this.Visible = false;
            forma.ShowDialog();
            this.Visible = true;

            this.DialogResult = DialogResult.OK;
        }

        private void btnModifikujRadnikaEkonomskeStruke_Click(object sender, EventArgs e)
        {
            ModifikujRadnikaEkonomskeStruke forma = new ModifikujRadnikaEkonomskeStruke();

            this.Visible = false;
            forma.ShowDialog();
            this.Visible = true;

            this.DialogResult = DialogResult.OK;
        }

        private void btnModifikujNekogDrugogZaposlenog_Click(object sender, EventArgs e)
        {
            ModifikujDrugogZaposlenog forma = new ModifikujDrugogZaposlenog();

            this.Visible = false;
            forma.ShowDialog();
            this.Visible = true;

            this.DialogResult = DialogResult.OK;
        }
    }
}
