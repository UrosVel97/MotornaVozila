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
    public partial class DodajNezavisnogEkonomistu : Form
    {
        public DodajNezavisnogEkonomistu()
        {
            InitializeComponent();
        }

        private void btnSnimi_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                NezavisniEkonomista n = new NezavisniEkonomista()
                {
                    Jmbg = int.Parse(txtJmbg.Text),
                    Ime = txtIme.Text,
                    Prezime = txtPrezime.Text,
                    Adresa = txtAdresa.Text
                };

                TelefonNezavisniEkonomista tel = new TelefonNezavisniEkonomista();
                tel.BrojTelefona = txtBrTelefona.Text;
                tel.NezavisniEkonomista = n;

                TelefonNezavisniEkonomista tel2 = new TelefonNezavisniEkonomista();
                tel2.BrojTelefona = txtBrTelefona2.Text;
                tel2.NezavisniEkonomista = n;

                n.Telefoni.Add(tel);
                n.Telefoni.Add(tel2);


                s.Save(n);
                s.Save(tel);
                s.Save(tel2);
                s.Flush();
                s.Close();
            }
            catch(Exception ec)
            {
                MessageBox.Show(ec.ToString());
            }


            this.DialogResult = DialogResult.OK;
        }
    }
}
