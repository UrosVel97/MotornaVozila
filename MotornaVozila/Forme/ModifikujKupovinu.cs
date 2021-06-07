using MotornaVozila.Entiteti;
using NHibernate;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Globalization;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MotornaVozila.Forme
{
    public partial class ModifikujKupovinu : Form
    {
        private Kupovina k;
        public ModifikujKupovinu()
        {
            InitializeComponent();
            k = null;
        }

        private void ModifikujKupovinu_Load(object sender, EventArgs e)
        {
            this.PopuniListuKupovina();
        }

        private void PopuniListuKupovina()
        {
            try
            {

                ISession s = DataLayer.GetSession();

                IList<Kupovina> z = s.QueryOver<Kupovina>()
                                        .List<Kupovina>();

                foreach (Kupovina k in z)
                {

                        ListViewItem item = new ListViewItem(new string[] { k.Id.ToString(), k.DatumKupovine.ToString()});

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
                    k = s.Load<Kupovina>(int.Parse(listView2.SelectedItems[0].Text));

                    dtDatumKupovine.Value = (k.DatumKupovine == null ? DateTime.Now : (DateTime)k.DatumKupovine);

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

                k.DatumKupovine = DateTime.ParseExact(dtDatumKupovine.Value.ToString("dd-MM-yyyy"), "dd-MM-yyyy", CultureInfo.InvariantCulture);

                s.SaveOrUpdate(k);
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
