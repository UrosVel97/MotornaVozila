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
    public partial class ObrisiVoziloKojeJeProdato : Form
    {

        public ObrisiVoziloKojeJeProdato()
        {
            InitializeComponent();
        }

        private void listView2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnSnimi_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void ObrisiVoziloKojeJeProdato_Load(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                IList<VoziloKojeJeProdato> vozila = s.QueryOver<UvezenoVozilo>()
                                                               .Where(x => x.GetType() == typeof(VoziloKojeJeProdato))
                                                               .List<VoziloKojeJeProdato>();


                foreach (VoziloKojeJeProdato vp in vozila)
                {
                    ListViewItem item = new ListViewItem(new string[] { vp.BrojSasije.ToString(), vp.BrojMotora.ToString(), vp.ModelVozila, vp.TipGoriva });

                    listView2.Items.Add(item);
                }
                listView2.Refresh();

                s.Close();
            }
            catch(Exception ec)
            {
                MessageBox.Show(ec.ToString());
            }
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            try
            {
                if (listView2.SelectedItems.Count > 0)
                {
                    DTOManager.ObrisiVoziloKojeJeProdato(int.Parse(listView2.SelectedItems[0].Text));
                }

                
            }
            catch(Exception ec)
            {
                MessageBox.Show(ec.ToString());
            }

            this.DialogResult = DialogResult.OK;
        }
    }
}
