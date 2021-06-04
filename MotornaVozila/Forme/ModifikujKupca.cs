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
    public partial class ModifikujKupca : Form
    {
        public ModifikujKupca()
        {
            InitializeComponent();
        }

        private void btnModifikujPravnoLice_Click(object sender, EventArgs e)
        {
            ModifikujPravnoLice forma = new ModifikujPravnoLice();
            this.Visible = false;
            forma.ShowDialog();
            this.Visible = true;
            this.DialogResult = DialogResult.OK;
        }

        private void btnModifikujFizickoLice_Click(object sender, EventArgs e)
        {
            ModifikujFizickoLice forma = new ModifikujFizickoLice();
            this.Visible = false;
            forma.ShowDialog();
            this.Visible = true;
            this.DialogResult = DialogResult.OK;
        }
    }
}
