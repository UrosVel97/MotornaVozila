using MotornaVozila.Entiteti;
using NHibernate;
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
    public partial class DodajNergistrovanogKupca : Form
    {
        public DodajNergistrovanogKupca()
        {
            InitializeComponent();
        }

        private void btnDodajBroj_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(txtBroj.Text);

            txtBroj.Text = "";
        }

        private void btnSnimi_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                NeregistrovaniKupac n = new NeregistrovaniKupac()
                {
                    Ime = txtIme.Text,
                    Prezime = txtPrezime.Text
                };

                s.Save(n);
                s.Flush();

                foreach(String broj in listBox1.Items)
                {
                    TelefonNeregistrovaniKupac tel = new TelefonNeregistrovaniKupac()
                    {
                        BrojTelefona = broj,
                        NeregistrovaniKupac = n

                    };

                    n.Telefoni.Add(tel);
                    s.Save(tel);
                    s.Save(n);
                    s.Flush();
                }


                
                s.Close();
                this.DialogResult = DialogResult.OK;

            }
            catch(Exception ec)
            {
                MessageBox.Show(ec.ToString());
            }
        }
    }
}
