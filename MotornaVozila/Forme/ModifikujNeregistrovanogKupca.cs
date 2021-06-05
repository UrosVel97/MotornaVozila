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
    public partial class ModifikujNeregistrovanogKupca : Form
    {
        private NeregistrovaniKupac nk;
        public ModifikujNeregistrovanogKupca()
        {
            InitializeComponent();
            nk = null;
        }

        private void ModifikujNeregistrovanogKupca_Load(object sender, EventArgs e)
        {
            this.PopuniListuNezavisnihKupaca();
        }

        private void PopuniListuNezavisnihKupaca()
        {
            ISession s = DataLayer.GetSession();

            IList<NeregistrovaniKupac> vozila = s.QueryOver<Vlasnik>()
                                                           .Where(x => x.GetType() == typeof(NeregistrovaniKupac))
                                                           .List<NeregistrovaniKupac>();


            foreach (NeregistrovaniKupac nk in vozila)
            {
                ListViewItem item = new ListViewItem(new string[] { nk.Id.ToString(), nk.Ime, nk.Prezime });

                listView2.Items.Add(item);
            }
            listView2.Refresh();

            s.Close();
        }

        private void listView2_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (listView2.SelectedItems.Count > 0)
                {
                    ISession s = DataLayer.GetSession();
                    nk = s.Load<NeregistrovaniKupac>(int.Parse(listView2.SelectedItems[0].Text));

                    txtIme.Text = nk.Ime;
                    txtPrezime.Text = nk.Prezime;

                    listBoxTelefoni.Items.Clear();
                    foreach(TelefonNeregistrovaniKupac telefon in nk.Telefoni)
                    {
                        listBoxTelefoni.Items.Add(telefon.BrojTelefona);
                    }
                    listBoxTelefoni.Refresh();

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
            try
            {
                ISession s = DataLayer.GetSession();

                nk.Ime = txtIme.Text;
                nk.Prezime = txtPrezime.Text;

                s.SaveOrUpdate(nk);
                s.Flush();
                s.Close();
            }

            catch (Exception ec)
            {
                MessageBox.Show(ec.ToString());
            }

            this.DialogResult = DialogResult.OK;
        }
    }
}
