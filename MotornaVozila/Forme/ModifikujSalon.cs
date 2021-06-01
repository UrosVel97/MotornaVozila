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
                    checkObavlja.Checked = (szm.FServis.Equals("Y") ? true : false);

                    listBoxTipRadova.Items.Clear();
                    foreach (TipRadova tip in szm.TipoviRadova)
                    {
                        listBoxTipRadova.Items.Add(tip.Tip_Radova);
                    }
                    listBoxTipRadova.Refresh();

                    s.Close();
                }
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.ToString());
            }
        }

        private void checkBoxTeretno_CheckedChanged(object sender, EventArgs e)
        {
            if (checkObavlja.Checked)
            {
                label12.Visible = true;
                label13.Visible = true;
                txtTipRadova.Visible = true;
                listBoxTipRadova.Visible = true;
                btnDodajTipRadova.Visible = true;
            }
            else
            {
                label12.Visible = false;
                label13.Visible = false;
                txtTipRadova.Visible = false;
                listBoxTipRadova.Visible = false;
                btnDodajTipRadova.Visible = false;
            }
        }

        private void btnDodajTipRadova_Click(object sender, EventArgs e)
        {
            try
            {
                listBoxTipRadova.Items.Add(txtTipRadova.Text);
                listBoxTipRadova.Refresh();
                txtTipRadova.Text = "";
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

                szm.Grad = txtGrad.Text;
                szm.Adresa = txtAdresa.Text;
                szm.SefSalona = txtSefSalona.Text;
                szm.SefServisa = txtSefServisa.Text;
                szm.FServis = (checkObavlja.Checked ? "Y" : "N");

                s.SaveOrUpdate(szm);
                s.Flush();

                //foreach (string tip in listBoxTipRadova.Items)
                //{
                //    if (!this.ProveriTip(szm.TipoviRadova, tip))
                //    {
                //        TipRadova t = new TipRadova();
                //        t.Tip_Radova = tip;
                //        t.Servis = (IList<Salon>)szm;
                //        szm.TipoviRadova.Add(t);
                //        s.Save(t);
                //        s.Save(szm);
                //        s.Flush();
                //    }
                //}
                s.Close();
            }

            catch (Exception ec)
            {
                MessageBox.Show(ec.ToString());
            }

            this.DialogResult = DialogResult.OK;
        }

        private bool ProveriTip(IList<TipRadova> tipRadovas, string tip)
        {
            foreach (TipRadova t in tipRadovas)
            {
                if (t.Tip_Radova.Equals(tip))
                    return true;
            }
            return false;
        }
    }
}
