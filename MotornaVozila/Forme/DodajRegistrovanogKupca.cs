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
using static MotornaVozila.DTOs;

namespace MotornaVozila.Forme
{
    public partial class DodajRegistrovanogKupca : Form
    {
        public DodajRegistrovanogKupca()
        {
            InitializeComponent();
        }

        private void DodajRegistrovanogKupca_Load(object sender, EventArgs e)
        {
            this.PopuniListuKupaca();
        }

        private void PopuniListuKupaca()
        {
            IList<KupacInfo> kupci = DTOManager.VratiKupce();

            foreach (KupacInfo k in kupci)
            {
                ListViewItem item = new ListViewItem(new string[] { k.Id.ToString(), k.Ime, k.Prezime });

                listView1.Items.Add(item);
            }
            listView1.Refresh();
        }

        private void btnSnimi_Click(object sender, EventArgs e)
        {
            try
            {
                if (listView1.SelectedItems.Count > 0)
                {
                    
                    ISession s = DataLayer.GetSession();
                    Kupac k = s.Load<Kupac>(int.Parse(listView1.SelectedItems[0].Text));


                    RegistrovaniKupac r = new RegistrovaniKupac()
                    {
                        Kupac = k
                    };
                    k.RegistrovaniKupci.Add(r);
                    s.Save(r);
                    s.Save(k);
                    s.Flush();

                    s.Close();
                    this.DialogResult = DialogResult.OK;

                }
            }
            catch(Exception ec)
            {
                MessageBox.Show(ec.ToString());
            }
        }
    }
}
