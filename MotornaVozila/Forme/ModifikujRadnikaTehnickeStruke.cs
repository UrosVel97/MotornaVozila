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
    public partial class ModifikujRadnikaTehnickeStruke : Form
    {
        private RadnikTehnickeStruke rts;
        public ModifikujRadnikaTehnickeStruke()
        {
            InitializeComponent();
            rts = null;
        }

        private void listView2_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (listView2.SelectedItems.Count > 0)
                {
                    ISession s = DataLayer.GetSession();
                    rts = s.Load<RadnikTehnickeStruke>(int.Parse(listView2.SelectedItems[0].Text));

                    txtIme.Text = rts.Ime;
                    txtPrezime.Text = rts.Prezime;
                    txtJmbg.Text = rts.Jmbg.ToString();
                    radioButton2.Checked = (rts.FZaposleniZaStalno.Equals("Y") ? true : false);
                    radioButton3.Checked = (rts.FZaposleniPoUgovoru.Equals("Y") ? true : false);
                    txtPlata.Text = rts.Plata.ToString();
                    dtDatumIstekaUgovora.Value = (rts.DatumIstekaUgovora == null ? DateTime.Now : (DateTime)rts.DatumIstekaUgovora);

                    listBoxSpecijalnosti.Items.Clear();
                    foreach (Specijalnost spec in rts.Specijalnosti)
                    {
                        listBoxSpecijalnosti.Items.Add(spec.SpecijalnostRadnika);
                    }
                    listBoxSpecijalnosti.Refresh();

                    s.Close();
                }
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.ToString());
            }
        }

        private void ModifikujRadnikaTehnickeStruke_Load(object sender, EventArgs e)
        {
            label10.Visible = false;
            txtPlata.Visible = false;
            label11.Visible = false;
            dtDatumIstekaUgovora.Visible = false;
            this.PopuniListuRadnika();

        }

        private void PopuniListuRadnika()
        {
            try
            {
                ISession s = DataLayer.GetSession();

                IList<RadnikTehnickeStruke> radnici = s.QueryOver<Zaposleni>()
                                                           .Where(x => x.GetType() == typeof(RadnikTehnickeStruke))
                                                           .List<RadnikTehnickeStruke>();


                foreach (RadnikTehnickeStruke radnik in radnici)
                {
                    ListViewItem item = new ListViewItem(new string[] { radnik.Jmbg.ToString(), radnik.Ime, radnik.Prezime, radnik.DatumZaposlenja.ToString() });

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

        private void btnSnimi_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                rts.Ime = txtIme.Text;
                rts.Prezime = txtPrezime.Text;
                rts.FZaposleniZaStalno = (radioButton2.Checked ? "Y" : "N");
                rts.FZaposleniPoUgovoru = (radioButton3.Checked ? "Y" : "N");
                rts.DatumIstekaUgovora = DateTime.ParseExact(dtDatumIstekaUgovora.Value.ToString("dd-MM-yyyy"), "dd-MM-yyyy", CultureInfo.InvariantCulture);
                rts.Plata = (radioButton2.Checked ? int.Parse(txtPlata.Text) : 0);

                s.SaveOrUpdate(rts);
                s.Flush();

                foreach (string specijalnost in listBoxSpecijalnosti.Items)
                {

                    if (!this.ProveriSpecijalnost(rts.Specijalnosti, specijalnost))
                    {
                        Specijalnost spec = new Specijalnost();
                        spec.SpecijalnostRadnika = specijalnost;
                        spec.RadnikTehnickeStruke = rts;
                        rts.Specijalnosti.Add(spec);
                        s.Save(spec);
                        s.Save(rts);
                        s.Flush();
                    }
                }
                s.Close();
            }

            catch (Exception ec)
            {
                MessageBox.Show(ec.ToString());
            }

            this.DialogResult = DialogResult.OK;
        }

        private bool ProveriSpecijalnost(IList<Specijalnost> specijalnosti, string specijalnost)
        {
            foreach (Specijalnost spec in specijalnosti)
            {
                if (spec.SpecijalnostRadnika.Equals(specijalnost))
                    return true;
            }
            return false;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                label10.Visible = true;
                txtPlata.Visible = true;
            }
            else
            {
                label10.Visible = false;
                txtPlata.Visible = false;
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

            if (radioButton3.Checked)
            {
                label11.Visible = true;
                dtDatumIstekaUgovora.Visible = true;
            }
            else
            {
                label11.Visible = false;
                dtDatumIstekaUgovora.Visible = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                listBoxSpecijalnosti.Items.Add(txtSpecijalnost.Text);
                listBoxSpecijalnosti.Refresh();
                txtSpecijalnost.Text = "";
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.ToString());
            }
        }
    }
}
