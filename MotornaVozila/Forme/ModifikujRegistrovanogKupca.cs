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
    public partial class ModifikujRegistrovanogKupca : Form
    {
        private RegistrovaniKupac rk;
        public ModifikujRegistrovanogKupca()
        {
            InitializeComponent();
            rk = null;
        }

        private void ModifikujRegistrovanogKupca_Load(object sender, EventArgs e)
        {
            this.PopuniListuVlasnika();
        }

        private void PopuniListuVlasnika()
        {
            try
            {

                ISession s = DataLayer.GetSession();

                IList<RegistrovaniKupac> z = s.QueryOver<Vlasnik>()
                                              .Where(x=>x.GetType()==typeof(RegistrovaniKupac))
                                        .List<RegistrovaniKupac>();

                foreach (RegistrovaniKupac rk in z)
                {
                    ListViewItem item = new ListViewItem(new string[] { rk.Id.ToString(), rk.Kupac.LicnoIme, rk.Kupac.Prezime, });

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

        private void listView2_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (listView2.SelectedItems.Count > 0)
                {
                    ISession s = DataLayer.GetSession();
                    rk = s.Load<RegistrovaniKupac>(int.Parse(listView2.SelectedItems[0].Text));
                  

                    if (rk.Kupac.GetType() == typeof(FizickoLice))
                    {
                        label3.Visible = true;

                    }
                    else if (rk.Kupac.GetType() == typeof(PravnoLice))
                    {
                        label3.Visible = true;

                    }

                    s.Close();
                }
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.ToString());
            }
        }
    }
}
