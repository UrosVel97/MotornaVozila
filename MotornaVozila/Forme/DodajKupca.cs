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
    public partial class DodajKupca : Form
    {
        public DodajKupca()
        {
            InitializeComponent();
        }

        private void btnDodajPravnoLice_Click(object sender, EventArgs e)
        {
            DodajPravnoLice forma = new DodajPravnoLice();
            this.Visible = false;
            forma.ShowDialog();
            this.Visible = true;
            this.DialogResult = DialogResult.OK;
        }

        private void btnDodajFizickoLice_Click(object sender, EventArgs e)
        {
            DodajFizikoLice forma = new DodajFizikoLice();
            this.Visible = false;
            forma.ShowDialog();
            this.Visible = true;
            this.DialogResult = DialogResult.OK;
        }
    }
}
