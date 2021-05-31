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
using MotornaVozila.Entiteti;
using NHibernate;

namespace MotornaVozila.Forme
{
    public partial class ModifikujDrugogZaposlenog : Form
    {
        NekiDrugiZaposleni res;
        public ModifikujDrugogZaposlenog()
        {
            InitializeComponent();
            res = null;
        }

        private void listView2_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (listView2.SelectedItems.Count > 0)
                {
                    ISession s = DataLayer.GetSession();
                    res = s.Load<NekiDrugiZaposleni>(int.Parse(listView2.SelectedItems[0].Text));

                    txtIme.Text = res.Ime;
                    txtPrezime.Text = res.Prezime;
                    txtJmbg.Text = res.Jmbg.ToString();
                    radioButton2.Checked = (res.FZaposleniZaStalno.Equals("Y") ? true : false);
                    radioButton3.Checked = (res.FZaposleniPoUgovoru.Equals("Y") ? true : false);
                    txtPlata.Text = res.Plata.ToString();
                    dtDatumIstekaUgovora.Value = (res.DatumIstekaUgovora == null ? DateTime.Now : (DateTime)res.DatumIstekaUgovora);
                    txtStrucnaSprema.Text = res.StrucnaSprema;

                    s.Close();
                }
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.ToString());
            }
        }

        private void ModifikujDrugogZaposlenog_Load(object sender, EventArgs e)
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

                IList<NekiDrugiZaposleni> radnici = s.QueryOver<Zaposleni>()
                                                           .Where(x => x.GetType() == typeof(NekiDrugiZaposleni))
                                                           .List<NekiDrugiZaposleni>();


                foreach (NekiDrugiZaposleni radnik in radnici)
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

        private void btnSnimi_Click(object sender, EventArgs e)
        {

            try
            {
                ISession s = DataLayer.GetSession();

                res.Ime = txtIme.Text;
                res.Prezime = txtPrezime.Text;
                res.FZaposleniZaStalno = (radioButton2.Checked ? "Y" : "N");
                res.FZaposleniPoUgovoru = (radioButton3.Checked ? "Y" : "N");
                res.DatumIstekaUgovora = DateTime.ParseExact(dtDatumIstekaUgovora.Value.ToString("dd-MM-yyyy"), "dd-MM-yyyy", CultureInfo.InvariantCulture);
                res.Plata = (radioButton2.Checked ? int.Parse(txtPlata.Text) : 0);
                res.StrucnaSprema = txtStrucnaSprema.Text;

                s.SaveOrUpdate(res);
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
