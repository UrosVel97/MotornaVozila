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
    public partial class DodajNezavisnogEkonomistu : Form
    {
        public DodajNezavisnogEkonomistu()
        {
            InitializeComponent();
        }

        private void btnSnimi_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
