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
    public partial class ObrisiKupovinu : Form
    {
        public ObrisiKupovinu()
        {
            InitializeComponent();
        }

        private void ObrisiKupovinu_Load(object sender, EventArgs e)
        {
            this.PopuniListuKupovina();
        }

        private void PopuniListuKupovina()
        {
            IList<KupovinaInfo> kupovine = DTOManager.VratiKupovine();

            foreach (KupovinaInfo k in kupovine)
            {
                ListViewItem item = new ListViewItem(new string[] { k.Id.ToString(), k.Datum.ToString() });

                listView2.Items.Add(item);
            }
            listView2.Refresh();
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            if(listView2.SelectedItems.Count>0)
            {
                DTOManager.ObrisiKupovinu(int.Parse(listView2.SelectedItems[0].Text));
                this.DialogResult = DialogResult.OK;
            }
        }
    }
}
