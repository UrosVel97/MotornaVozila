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

namespace MotornaVozila.Forme
{
    public partial class DodajSalon : Form
    {
        public DodajSalon()
        {
            InitializeComponent();
        }

        private void DodajSalon_Load(object sender, EventArgs e)
        {
            this.PopuniListuTipovaRadova();
            this.PopuniListuNezavisnihEkonomista();
        }

        private void PopuniListuNezavisnihEkonomista()
        {
            ISession s = DataLayer.GetSession();

            IList<NezavisniEkonomista> ekonomisti = s.QueryOver<NezavisniEkonomista>()                                                      
                                                       .List<NezavisniEkonomista>();


            foreach (NezavisniEkonomista n in ekonomisti)
            {
                ListViewItem item = new ListViewItem(new string[] { n.Jmbg.ToString(), n.Ime, n.Prezime, n.Adresa });

                listView1.Items.Add(item);
            }
            listView1.Refresh();

            s.Close();
        }

        private void PopuniListuTipovaRadova()
        {
           try
            {
                ISession s = DataLayer.GetSession();

                IList<TipRadova> tipRadova = s.QueryOver<TipRadova>()
                                              .List<TipRadova>();

                checkedListBoxTipRadova.Items.Clear();
                foreach(TipRadova t in tipRadova)
                {
                    checkedListBoxTipRadova.Items.Add(t.Tip_Radova);
                }
                checkedListBoxTipRadova.Refresh();


                s.Close();

            }
            catch(Exception ec)
            {
                MessageBox.Show(ec.ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if(txtTipRadova.Text!="")
                {
                    TipRadova t = new TipRadova();
                    t.Tip_Radova = txtTipRadova.Text;
                    DTOManager.KreirajTipRadova(t);
                    this.PopuniListuTipovaRadova();

                }
            }
            catch(Exception ec)
            {
                MessageBox.Show(ec.ToString());
            }
        }

        private void checkBoxServis_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBoxServis.Checked)
            {
                label8.Visible = true;
                txtTipRadova.Visible = true;
                btnDodajTipRadova.Visible = true;
                checkedListBoxTipRadova.Visible = true;
                label7.Visible = true;
            }
            else
            {
                label8.Visible = false;
                txtTipRadova.Visible = false;
                btnDodajTipRadova.Visible = false;
                checkedListBoxTipRadova.Visible = false;
                label7.Visible = false;
            }
        }

        private void btnDodajSalon_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                Salon salon = new Salon()
                {
                    Grad = txtGrad.Text,
                    Adresa = txtAdresa.Text,
                    StepenOpremljenostiServisa = txtStepenOpremljenosti.Text,
                    SefSalona = txtSefSalona.Text,
                    SefServisa = txtSefServisa.Text,
                    FServis = (checkBoxServis.Checked ? "Y" : "N"),
                };


                s.Save(salon);
                s.Flush();

                foreach(var c in checkedListBoxTipRadova.CheckedItems)
                {
                    TipRadova tip = s.Load<TipRadova>(c);
                    salon.TipoviRadova.Add(tip);
                    tip.Servis.Add(salon);
                    s.Save(salon);
                    s.Save(tip);
                    s.Flush();
                }

                foreach(ListViewItem c in listView1.SelectedItems)
                {
                    NezavisniEkonomista n = s.Load<NezavisniEkonomista>(int.Parse(c.Text));
                    salon.NezavisniEkonomisti.Add(n);
                    n.Saloni.Add(salon);
                    s.Save(salon);
                    s.Save(n);
                    s.Flush();

                }

                s.Close();
            }
            catch(Exception ec)
            {
                MessageBox.Show(ec.ToString());
            }
            this.DialogResult = DialogResult.OK;
        }
    }
}
