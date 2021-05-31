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
    public partial class ModifikujNezavisnogEkonomistu : Form
    {
        private NezavisniEkonomista n;
        public ModifikujNezavisnogEkonomistu()
        {
            InitializeComponent();
            n = null;

        }

        private void listView2_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (listView2.SelectedItems.Count > 0)
                {
                    ISession s = DataLayer.GetSession();
                    n = s.Load<NezavisniEkonomista>(int.Parse(listView2.SelectedItems[0].Text));

                    txtIme.Text = n.Ime;
                    txtPrezime.Text = n.Prezime;
                    txtJmbg.Text = n.Jmbg.ToString();
                    txtAdresa.Text = n.Adresa;
                    if (n.Telefoni.Count == 0)
                    {
                        txtBrTelefona.Text = "Nema broj";
                        txtBrTelefona2.Text = "Nema broj";
                    }
                    else if (n.Telefoni.Count == 1)
                    {
                        txtBrTelefona.Text = n.Telefoni[0].BrojTelefona;
                        txtBrTelefona2.Text = "Nema broj";
                    }
                    else
                    {
                        txtBrTelefona.Text = n.Telefoni[0].BrojTelefona; ;
                        txtBrTelefona2.Text = n.Telefoni[1].BrojTelefona; ;
                    }



                    s.Close();
                }
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.ToString());
            }

        }

        private void btnSnimi_Click(object sender, EventArgs e)
        {
            if(n==null)
            {
                MessageBox.Show("Morate da izaberete nezavisnog ekonomistu iz liste!!!");
                return;
            }

            try
            {
                ISession s = DataLayer.GetSession();
                n.Ime = txtIme.Text;
                n.Prezime = txtPrezime.Text;
                n.Adresa = txtAdresa.Text;

                s.SaveOrUpdate(n);
                s.Flush();
                s.Close();
            }
            catch(Exception ec)
            {
                MessageBox.Show(ec.ToString());
            }
            this.DialogResult = DialogResult.OK;
        }

        private void ModifikujNezavisnogEkonomistu_Load(object sender, EventArgs e)
        {
            this.PopuniListuEkonomista();
        }

        private void PopuniListuEkonomista()
        {
            try
            {
                ISession s = DataLayer.GetSession();

                IList<NezavisniEkonomista> ekonomisti = s.QueryOver<NezavisniEkonomista>()
                                                     .List<NezavisniEkonomista>();


                foreach (NezavisniEkonomista n in ekonomisti)
                {
                    ListViewItem item = new ListViewItem(new string[] { n.Jmbg.ToString(), n.Ime, n.Prezime, n.Adresa });

                    listView2.Items.Add(item);
                }
                listView2.Refresh();

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.ToString());
            }
        }
    }
}
