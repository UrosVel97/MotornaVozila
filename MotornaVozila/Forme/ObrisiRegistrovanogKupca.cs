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
    public partial class ObrisiRegistrovanogKupca : Form
    {
        public ObrisiRegistrovanogKupca()
        {
            InitializeComponent();
        }

        private void ObrisiRegistrovanogKupca_Load(object sender, EventArgs e)
        {
            this.PopuniListuKupaca();
        }

        private void PopuniListuKupaca()
        {
            IList<KupacInfo> kupci = DTOManager.VratiRegistrovaneKupce();

            foreach (KupacInfo nk in kupci)
            {
                ListViewItem item = new ListViewItem(new string[] { nk.Id.ToString(), nk.Ime, nk.Prezime });

                listView1.Items.Add(item);
            }
            listView1.Refresh();
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            try
            {
                if (listView1.SelectedItems.Count > 0)
                {
                    DTOManager.ObrisiRegistrovanogKupca(int.Parse(listView1.SelectedItems[0].Text));
                    this.DialogResult = DialogResult.OK;
                }
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.ToString());
            }
        }
    }
}
