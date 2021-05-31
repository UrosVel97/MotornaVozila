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
    public partial class ObrisiVoziloKojeNijeProdato : Form
    {
        private VoziloKojeNijeProdato vknp;
        public ObrisiVoziloKojeNijeProdato()
        {
            InitializeComponent();
            vknp = null;
        }

        private void listView2_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (listView2.SelectedItems.Count > 0)
                {
                    ISession s = DataLayer.GetSession();
                    vknp = s.Load<VoziloKojeNijeProdato>(int.Parse(listView2.SelectedItems[0].Text));
                    vknp.Kubikaza++;
                    vknp.Kubikaza--;

                    s.Close();
                }
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.ToString());
            }
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                RadnikTehnickeStruke rts = s.Load<RadnikTehnickeStruke>(vknp.RadnikTehnStruke.Jmbg);
                Salon salon = s.Load<Salon>(vknp.IzlozenUSalonu.Id);

                s.Delete(vknp);

                rts.UvezenaVozila.Remove(vknp);
                salon.VozilaKojaNisuProdata.Remove(vknp);
                s.Flush();
                s.SaveOrUpdate(rts);
                s.SaveOrUpdate(salon);
                s.Flush();

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.ToString());
            }

            this.DialogResult = DialogResult.OK;
        }

        private void ObrisiVoziloKojeNijeProdato_Load(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                IList<VoziloKojeNijeProdato> vozila = s.QueryOver<UvezenoVozilo>()
                                                               .Where(x => x.GetType() == typeof(VoziloKojeNijeProdato))
                                                               .List<VoziloKojeNijeProdato>();


                foreach (VoziloKojeNijeProdato vp in vozila)
                {
                    ListViewItem item = new ListViewItem(new string[] { vp.BrojSasije.ToString(), vp.BrojMotora.ToString(), vp.ModelVozila, vp.TipGoriva });

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
