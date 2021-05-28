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
    public partial class DodajVoziloKojeNijeProdato : Form
    {
        public DodajVoziloKojeNijeProdato()
        {
            InitializeComponent();
        }

        private void btnSnimi_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                
                RadnikTehnickeStruke rts = s.Load<RadnikTehnickeStruke>(int.Parse(listView2.SelectedItems[0].Text));
                Salon salon= s.Load<Salon>(int.Parse(listView1.SelectedItems[0].Text));



                VoziloKojeNijeProdato vnp = new VoziloKojeNijeProdato();

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
                vnp.IzlozenUSalonu = salon;

                


                s.Save(vnp);


                rts.UvezenaVozila.Add(vnp);
                salon.VozilaKojaNisuProdata.Add(vnp);
                s.Save(rts);
                s.Save(salon);
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

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void DodajVoziloKojeNijeProdato_Load(object sender, EventArgs e)
        {
            this.PopuniListuSalona();
            this.PopuniListuRadnikaTehnickeStruke();

            label6.Visible = false;
            label7.Visible = false;
            label8.Visible = false;
            txtBrojPutnika.Visible = false;
            txtTipProstora.Visible = false;
            txtNosivost.Visible = false;
        }

        private void PopuniListuRadnikaTehnickeStruke()
        {
            try
            {
                listView2.Items.Clear();

                ISession s = DataLayer.GetSession();

                IList<RadnikTehnickeStruke> rts = s.QueryOver<Zaposleni>()
                                .Where(x => x.GetType()==typeof(RadnikTehnickeStruke))
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


        private void PopuniListuSalona()
        {
            try
            {
                listView1.Items.Clear();

                ISession s = DataLayer.GetSession();

                IList<Salon> saloni = s.QueryOver<Salon>()
                                 .List<Salon>();

                
                foreach (Salon salon in saloni)
                {
                    ListViewItem item = new ListViewItem(new string[] { salon.Id.ToString(), salon.Grad, salon.Adresa });

                    listView1.Items.Add(item);
                }
                listView1.Refresh();

                s.Close();
            }
            catch(Exception ec)
            {
                MessageBox.Show(ec.ToString());
            }
        }

        private void checkPutnicko_CheckedChanged(object sender, EventArgs e)
        {
            if(checkPutnicko.Checked)
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

        private void listView2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnDodajBoju_Click(object sender, EventArgs e)
        {
            listBoxBoje.Items.Add(txtUnesiBoju.Text);
            listBoxBoje.Refresh();
            txtUnesiBoju.Text = "";
        }
    }
}
