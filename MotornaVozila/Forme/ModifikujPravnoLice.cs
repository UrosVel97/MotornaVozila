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
using static MotornaVozila.DTOs;

namespace MotornaVozila.Forme
{
    public partial class ModifikujPravnoLice : Form
    {
        int id;
        public ModifikujPravnoLice()
        {
            InitializeComponent();
        }

        private void ModifikujPravnoLice_Load(object sender, EventArgs e)
        {
            this.PopuniListuKupaca();
        }

        private void PopuniListuKupaca()
        {

            IList<PravnoLiceInfo> kupci = DTOManager.VratiPravnaLica();


            foreach (PravnoLiceInfo p in kupci)
            {
                ListViewItem item = new ListViewItem(new string[] { p.Id.ToString(), p.Ime, p.Prezime, p.Pib.ToString() });

                listView1.Items.Add(item);
            }
            listView1.Refresh();


        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                try
                {
                    ISession s = DataLayer.GetSession();

                    PravnoLice p = s.Load<PravnoLice>(int.Parse(listView1.SelectedItems[0].Text));
                    txtIme.Text = p.LicnoIme;
                    txtPrezime.Text = p.Prezime;
                    txtPib.Text = p.Pib.ToString();
                    this.id = p.Id;



                    s.Close();
                }

                catch (Exception ec)
                {
                    MessageBox.Show(ec.ToString());
                }
            }
        }

        private void btnSnimi_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                PravnoLice p = s.Load<PravnoLice>(this.id);
                p.LicnoIme = txtIme.Text;
                p.Prezime = txtPrezime.Text;
                p.Pib = int.Parse(txtPib.Text);

                s.SaveOrUpdate(p);
                s.Flush();

                s.Close();

                this.DialogResult = DialogResult.OK;
            }
            catch(Exception ec)
            {
                MessageBox.Show(ec.ToString());
            }
        }
    }
}
