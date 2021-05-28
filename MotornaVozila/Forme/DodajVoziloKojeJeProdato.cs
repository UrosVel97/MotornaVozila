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

namespace MotornaVozila.Forme
{
    public partial class DodajVoziloKojeJeProdato : Form
    {
        public DodajVoziloKojeJeProdato()
        {
            InitializeComponent();
        }

        private void DodajVoziloKojeJeProdato_Load(object sender, EventArgs e)
        {
            this.PopuniListuKupovina();
            this.PopuniListuRadnikaTehnickeStruke();

            label6.Visible = false;
            label7.Visible = false;
            label8.Visible = false;
            txtBrojPutnika.Visible = false;
            txtTipProstora.Visible = false;
            txtNosivost.Visible = false;
        }

        private void PopuniListuKupovina()
        {
            try
            {
                listView1.Items.Clear();

                ISession s = DataLayer.GetSession();

                IList<Kupovina> kupovine = s.QueryOver<Kupovina>()
                                          .List<Kupovina>();


                foreach (Kupovina k in kupovine)
                {
                    ListViewItem item = new ListViewItem(new string[] { k.Id.ToString(), k.DatumKupovine.ToString() });

                    listView1.Items.Add(item);
                }
                listView1.Refresh();

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.ToString());
            }
        }

        private void PopuniListuRadnikaTehnickeStruke()
        {
            try
            {
                listView2.Items.Clear();

                ISession s = DataLayer.GetSession();

                IList<RadnikTehnickeStruke> rts = s.QueryOver<Zaposleni>()
                                .Where(x => x.GetType() == typeof(RadnikTehnickeStruke))
                                .List<RadnikTehnickeStruke>();



                foreach (RadnikTehnickeStruke r in rts)
                {
                    ListViewItem item = new ListViewItem(new string[] { r.Jmbg.ToString(), r.Ime, r.Prezime });

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

        private void btnDodajBoju_Click(object sender, EventArgs e)
        {
            listBoxBoje.Items.Add(txtUnesiBoju.Text);
            listBoxBoje.Refresh();
            txtUnesiBoju.Text = "";
        }

        private void btnSnimi_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                RadnikTehnickeStruke rts = s.Load<RadnikTehnickeStruke>(int.Parse(listView2.SelectedItems[0].Text));
                Kupovina kupovina = s.Load<Kupovina>(int.Parse(listView1.SelectedItems[0].Text));



                VoziloKojeJeProdato vnp = new VoziloKojeJeProdato();

                vnp.BrojSasije = int.Parse(txtBrojSasije.Text);
                vnp.BrojMotora = int.Parse(txtBrojMotora.Text);
                vnp.TipGoriva = txtTipGoriva.Text;
                vnp.Kubikaza = int.Parse(txtKubikaza.Text);
                vnp.DatumUvoza = DateTime.ParseExact(dtDatumUvoza.Value.ToString("dd-MM-yyyy"), "dd-MM-yyyy", CultureInfo.InvariantCulture);
                vnp.ModelVozila = txtModel.Text;
                vnp.FPutnickoVozilo = (checkPutnicko.Checked ? "Y" : "N");
                vnp.FTeretnoVozilo = (checkTeretno.Checked ? "Y" : "N");
                vnp.Nosivost = (checkTeretno.Checked ? int.Parse(txtNosivost.Text) : 0);
                vnp.TipProstora = (checkTeretno.Checked ? txtTipProstora.Text : null);
                vnp.BrojPutnika = (checkPutnicko.Checked ? int.Parse(txtBrojPutnika.Text) : 0);
                vnp.RadnikTehnStruke = rts;
                vnp.Kupovina = kupovina;




                s.Save(vnp);


                rts.UvezenaVozila.Add(vnp);
                kupovina.ProdataVozila.Add(vnp);
                s.Save(rts);
                s.Save(kupovina);
                s.Flush();

                foreach (string boja in listBoxBoje.Items)
                {
                    Boja b = new Boja()
                    {
                        BojaVozila = boja
                    };

                    b.UvezenoVozilo = vnp;
                    vnp.Boje.Add(b);
                    s.Save(b);
                    s.Save(vnp);


                }

                s.Flush();
                s.Close();

            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.ToString());
            }
            this.DialogResult = DialogResult.OK;
        }

        private void checkPutnicko_CheckedChanged(object sender, EventArgs e)
        {
            if (checkPutnicko.Checked)
            {
                label6.Visible = true;
                txtBrojPutnika.Visible = true;
            }
            else
            {
                label6.Visible = false;
                txtBrojPutnika.Visible = false;
            }
        }

        private void checkTeretno_CheckedChanged(object sender, EventArgs e)
        {
            if (checkTeretno.Checked)
            {
                label7.Visible = true;
                label8.Visible = true;
                txtNosivost.Visible = true;
                txtTipProstora.Visible = true;
            }
            else
            {
                label7.Visible = false;
                label8.Visible = false;
                txtNosivost.Visible = false;
                txtTipProstora.Visible = false;
            }
        }
    }
}
