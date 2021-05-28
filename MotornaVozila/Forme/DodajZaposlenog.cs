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
    public partial class DodajZaposlenog : Form
    {
        public DodajZaposlenog()
        {
            InitializeComponent();
        }

        private void btnDodajRadnikeTehnickeStruke_Click(object sender, EventArgs e)
        {
            DodajRadnikaTehnickeStruke forma = new DodajRadnikaTehnickeStruke();

            this.Visible = false;
            forma.ShowDialog();
            this.Visible = true;
            this.DialogResult = DialogResult.OK;
        }

        private void btnDodajRadnikaEkonomskeStruke_Click(object sender, EventArgs e)
        {
            DodajRadnikaEkonomskeStruke forma = new DodajRadnikaEkonomskeStruke();

            this.Visible = false;
            forma.ShowDialog();
            this.Visible = true;
            this.DialogResult = DialogResult.OK;
        }

        private void btnDodajDrugogZaposlenog_Click(object sender, EventArgs e)
        {
            DodajDrugogZaposlenog forma = new DodajDrugogZaposlenog();

            this.Visible = false;
            forma.ShowDialog();
            this.Visible = true;
            this.DialogResult = DialogResult.OK;
        }
    }
}
