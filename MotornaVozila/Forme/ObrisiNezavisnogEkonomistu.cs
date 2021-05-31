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
    public partial class ObrisiNezavisnogEkonomistu : Form
    {
        public ObrisiNezavisnogEkonomistu()
        {
            InitializeComponent();
        }

        private void ObrisiNezavisnogEkonomistu_Load(object sender, EventArgs e)
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

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            if (listView2.SelectedItems.Count==0)
            {
                MessageBox.Show("Morate da izaberete nezavisnog ekonomistu iz liste!!!");
                return;
            }


            try
            {
                
                DTOManager.ObrisiNezavisnogEkonomistu(int.Parse(listView2.SelectedItems[0].Text));
                
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.ToString());
            }
            this.DialogResult = DialogResult.OK;
        }
    }
}
