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
    public partial class DodajDrugogZaposlenog : Form
    {
        public DodajDrugogZaposlenog()
        {
            InitializeComponent();
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

        private void DodajDrugogZaposlenog_Load(object sender, EventArgs e)
        {
            label10.Visible = false;
            label11.Visible = false;
            txtPlata.Visible = false;
            dtDatumIstekaUgovora.Visible = false;
        }

        private void btnSnimi_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();


                NekiDrugiZaposleni rts = new NekiDrugiZaposleni()
                {
                    Jmbg = int.Parse(txtJmbg.Text),
                    Ime = txtIme.Text,
                    Prezime = txtPrezime.Text,
                    GodineRadnogStaza = int.Parse(txtGodineRadnogStaza.Text),
                    DatumRodjena = DateTime.ParseExact(dtDatumRodjenja.Value.ToString("dd-MM-yyyy"), "dd-MM-yyyy", CultureInfo.InvariantCulture),
                    DatumZaposlenja = DateTime.ParseExact(dtDatumZaposlenja.Value.ToString("dd-MM-yyyy"), "dd-MM-yyyy", CultureInfo.InvariantCulture),
                    StrucnaSprema = txtStrucnaSprema.Text,
                    FZaposleniZaStalno = (radioButton2.Checked ? "Y" : "N"),
                    FZaposleniPoUgovoru = (radioButton3.Checked ? "Y" : "N"),
                    DatumIstekaUgovora = DateTime.ParseExact(dtDatumIstekaUgovora.Value.ToString("dd-MM-yyyy"), "dd-MM-yyyy", CultureInfo.InvariantCulture),
                    Plata = (radioButton2.Checked ? int.Parse(txtPlata.Text) : 0)


                };

                s.Save(rts);
                s.Flush();

                s.Close();

                this.DialogResult = DialogResult.OK;

            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.ToString());
            }
        }
    }
}
