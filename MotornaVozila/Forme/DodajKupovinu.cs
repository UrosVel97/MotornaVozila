using MotornaVozila.Entiteti;
using NHibernate;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static MotornaVozila.DTOs;

namespace MotornaVozila.Forme
{
    public partial class DodajKupovinu : Form
    {
        public DodajKupovinu()
        {
            InitializeComponent();
        }

        private void DodajKupovinu_Load(object sender, EventArgs e)
        {
            this.PopuniListuSalona();
            this.PopuniListuKupaca();
        }

        private void PopuniListuKupaca()
        {
            IList<KupacInfo> kupci = DTOManager.VratiKupce();

            foreach (KupacInfo k in kupci)
            {
                ListViewItem item = new ListViewItem(new string[] { k.Id.ToString(), k.Ime, k.Prezime});

                listView1.Items.Add(item);
            }
            listView1.Refresh();
        }

        private void PopuniListuSalona()
        {
            IList<SalonZaModifikovanje> saloni = DTOManager.VratiSaloneZaModifikovanjeDTO();

            foreach (SalonZaModifikovanje salon in saloni)
            {
                ListViewItem item = new ListViewItem(new string[] { salon.Id.ToString(), salon.Grad, salon.Adresa });

                listView2.Items.Add(item);
            }
            listView2.Refresh();
        }

        private void btnSnimi_Click(object sender, EventArgs e)
        {
            if(listView1.SelectedItems.Count>0 && listView2.SelectedItems.Count>0)
            {
                try
                {
                    ISession s = DataLayer.GetSession();
                    Salon salon = s.Load<Salon>(int.Parse(listView2.SelectedItems[0].Text));
                    Kupac kupac = s.Load<Kupac>(int.Parse(listView1.SelectedItems[0].Text));


                    Kupovina k = new Kupovina()
                    {
                        DatumKupovine = DateTime.ParseExact(dtDatumKupovine.Value.ToString("dd-MM-yyyy"), "dd-MM-yyyy", CultureInfo.InvariantCulture),
                        IdSalona = salon,
                        IdKupca = kupac
                    };
                    salon.Kupovine.Add(k);
                    kupac.Kupovine.Add(k);
                    s.Save(k);
                    s.Flush();
                    s.Save(salon);
                    s.Save(kupac);
                    s.Flush();

                    s.Close();



                    this.DialogResult = DialogResult.OK;
                }
                catch(Exception ec)
                {
                    MessageBox.Show(ec.ToString());
                }
            }
            else
            {
                MessageBox.Show("Morate da izaberete salon i kupca!!!");
            }

            
        }
    }
}
