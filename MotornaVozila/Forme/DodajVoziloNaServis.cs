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
using MotornaVozila.Entiteti;

namespace MotornaVozila.Forme
{
    public partial class DodajVoziloNaServis : Form
    {
        public DodajVoziloNaServis()
        {
            InitializeComponent();
        }

        private void DodajVoziloNaServis_Load(object sender, EventArgs e)
        {
            this.PopuniListuVlasnika();
            this.PopuniListuZaposlenih();
        }

        private void PopuniListuZaposlenih()
        {

            IList<ZaposleniInfo> zaposleni = DTOManager.VratiZaposlene();

            foreach (ZaposleniInfo zapos in zaposleni)
            {
                ListViewItem item = new ListViewItem(new string[] { zapos.Jmbg.ToString(), zapos.Ime, zapos.Prezime });

                listView2.Items.Add(item);
            }
            listView2.Refresh();

        }

        private void PopuniListuVlasnika()
        {
            IList<VlasnikInfo> vlasnici = DTOManager.VratiVlasnike();

            foreach (VlasnikInfo vlasnik in vlasnici)
            {
                ListViewItem item = new ListViewItem(new string[] { vlasnik.Id.ToString(), vlasnik.Ime, vlasnik.Prezime });

                listView1.Items.Add(item);
            }
            listView1.Refresh();
        }

        private void btnSnimi_Click(object sender, EventArgs e)
        {
            try
            {
                if(listView1.SelectedItems.Count>0 && listView2.SelectedItems.Count > 0) {
                    VozilaPrimljenaNaServis v = new VozilaPrimljenaNaServis()
                    {
                        ModelVozila = txtModel.Text,
                        GodinaProizvodnje = int.Parse(txtGodinaProizvodnje.Text),
                        OpisProblema = txtOpisProblema.Text

                    };

                    DTOManager.DodajVoziloPrimljenoNaServis(v, int.Parse(listView1.SelectedItems[0].Text), int.Parse(listView2.SelectedItems[0].Text));
                    this.DialogResult = DialogResult.OK;
                }


            }
            catch(Exception ec)
            {
                MessageBox.Show(ec.ToString());
            }
        }
    }
}
