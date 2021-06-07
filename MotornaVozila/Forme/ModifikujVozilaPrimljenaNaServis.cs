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
    public partial class ModifikujVozilaPrimljenaNaServis : Form
    {
        private VozilaPrimljenaNaServis ne;
        public ModifikujVozilaPrimljenaNaServis()
        {
            InitializeComponent();
            ne = null;
        }

        private void ModifikujVozilaPrimljenaNaServis_Load(object sender, EventArgs e)
        {
            this.PopuniListuVozila();
        }

        private void PopuniListuVozila()
        {
            try
            {
                ISession s = DataLayer.GetSession();

                IList<VozilaPrimljenaNaServis> vozilaPrimljenaNaServis = s.QueryOver<VozilaPrimljenaNaServis>()
                                                     .List<VozilaPrimljenaNaServis>();


                foreach (VozilaPrimljenaNaServis vozila in vozilaPrimljenaNaServis)
                {
                    ListViewItem item = new ListViewItem(new string[] { vozila.RegistarskiBroj.ToString(), vozila.ModelVozila, vozila.GodinaProizvodnje.ToString(), vozila.DatumPrijema.ToString(), vozila.OpisProblema });

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
                    ne = s.Load<VozilaPrimljenaNaServis>(int.Parse(listView2.SelectedItems[0].Text));

                    txtRegistarskiBroj.Text = ne.RegistarskiBroj.ToString();
                    txtModelVozila.Text = ne.ModelVozila;
                    txtGodinaProizvodnje.Text = ne.GodinaProizvodnje.ToString();
                    //dateTimePickerDatumPrijema.Value = (ne.DatumPrijema == null ? DateTime.Now : (DateTime)ne.DatumPrijema);
                    txtOpisProblema.Text = ne.OpisProblema;
                    
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

                ne.ModelVozila = txtModelVozila.Text;
                ne.GodinaProizvodnje = int.Parse(txtGodinaProizvodnje.Text);
                //ne.DatumPrijema = DateTime.ParseExact(dateTimePickerDatumPrijema.Value.ToString("dd-MM-yyyy"), "dd-MM-yyyy", CultureInfo.InvariantCulture);
                ne.OpisProblema = txtOpisProblema.Text;

                DTOManager.AzurirajVozilaPrimljenaNaServis(ne);
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.ToString());
            }
            this.DialogResult = DialogResult.OK;
        }
    }
}
