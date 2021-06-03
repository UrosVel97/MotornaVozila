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
    public partial class ModifikujSalon : Form
    {
        private Salon szm;
        public ModifikujSalon()
        {
            InitializeComponent();
            szm = null;
        }

        private void ModifikujSalon_Load(object sender, EventArgs e)
        {
            try
            {
                this.PopuniListuSalona();
                this.PopuniListuTipovaRadova();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void PopuniListuSalona()
        {
            IList<SalonZaModifikovanje> saloni = DTOManager.VratiSaloneZaModifikovanjeDTO();

            foreach (SalonZaModifikovanje salon in saloni)
            {
                ListViewItem item = new ListViewItem(new string[] { salon.Id.ToString(), salon.Grad, salon.Adresa, salon.SefSalona, salon.SefServisa });

                listView2.Items.Add(item);
            }
            listView2.Refresh();
        }

        private void listView2_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (listView2.SelectedItems.Count > 0)
                {
                    ISession s = DataLayer.GetSession();
                    szm = s.Load<Salon>(int.Parse(listView2.SelectedItems[0].Text));

                    txtGrad.Text = szm.Grad;
                    txtAdresa.Text = szm.Adresa;
                    txtSefSalona.Text = szm.SefSalona;
                    txtSefServisa.Text = szm.SefServisa;
                    

                    s.Close();
                }
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.ToString());
            }
        }

        private void PopuniListuTipovaRadova()
        {
            try
            {
                ISession s = DataLayer.GetSession();

                IList<TipRadova> tipRadova = s.QueryOver<TipRadova>()
                                              .List<TipRadova>();

                

                s.Close();

            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.ToString());
            }
        }

        private void checkBoxTeretno_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void btnSnimi_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                szm.Grad = txtGrad.Text;
                szm.Adresa = txtAdresa.Text;
                szm.SefSalona = txtSefSalona.Text;
                szm.SefServisa = txtSefServisa.Text;
                

                s.SaveOrUpdate(szm);
                s.Flush();

                s.Close();
            }

            catch (Exception ec)
            {
                MessageBox.Show(ec.ToString());
            }

            this.DialogResult = DialogResult.OK;
        }

        private void checkedListBoxListaTipRadova_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
