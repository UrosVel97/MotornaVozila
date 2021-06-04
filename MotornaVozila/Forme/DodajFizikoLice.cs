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
    public partial class DodajFizikoLice : Form
    {
        public DodajFizikoLice()
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
                FizickoLice p = new FizickoLice()
                {
                    LicnoIme = txtIme.Text,
                    Prezime = txtPrezime.Text,
                    Jmbg = int.Parse(txtJmbg.Text)
                };

                s.Save(p);
                s.Flush();

                foreach (string i in listBox1.Items)
                {
                    TelefonKupac tel = new TelefonKupac()
                    {
                        Telefon = i,
                        Kupac = p
                    };

                    s.Save(tel);
                    s.Flush();
                    p.Telefoni.Add(tel);
                    s.Save(p);
                    s.Flush();
                }



                s.Close();
                this.DialogResult = DialogResult.OK;
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.ToString());
            }
        }
    }
}
