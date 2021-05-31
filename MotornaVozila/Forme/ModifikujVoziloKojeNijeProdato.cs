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
    public partial class ModifikujVoziloKojeNijeProdato : Form
    {
        private VoziloKojeNijeProdato vknp;

        public ModifikujVoziloKojeNijeProdato()
        {
            InitializeComponent();
            vknp = null;
        }

        private void listView2_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (listView2.SelectedItems.Count > 0)
                {
                    ISession s = DataLayer.GetSession();
                    vknp = s.Load<VoziloKojeNijeProdato>(int.Parse(listView2.SelectedItems[0].Text));

                    txtBrojSasije.Text = vknp.BrojSasije.ToString();
                    txtBrojMotora.Text = vknp.BrojMotora.ToString();
                    txtModel.Text = vknp.ModelVozila;
                    txtTipGoriva.Text = vknp.TipGoriva;
                    txtKubikaza.Text = vknp.Kubikaza.ToString();
                    checkBoxTeretno.Checked = (vknp.FTeretnoVozilo.Equals("Y") ? true : false);
                    checkBoxPutnicko.Checked = (vknp.FPutnickoVozilo.Equals("Y") ? true : false);
                    txtBrojPutnika.Text = vknp.BrojPutnika.ToString();
                    txtNosivost.Text = vknp.Nosivost.ToString();
                    txtTipProstora.Text = vknp.TipProstora;

                    listBoxBojeVozila.Items.Clear();
                    foreach (Boja boja in vknp.Boje)
                    {
                        listBoxBojeVozila.Items.Add(boja.BojaVozila);
                    }
                    listBoxBojeVozila.Refresh();

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
                ISession s = DataLayer.GetSession();

                vknp.BrojSasije = int.Parse(txtBrojSasije.Text);
                vknp.BrojMotora = int.Parse(txtBrojMotora.Text);
                vknp.ModelVozila = txtModel.Text;
                vknp.TipGoriva = txtTipGoriva.Text;
                vknp.Kubikaza = int.Parse(txtKubikaza.Text);
                vknp.FTeretnoVozilo = (checkBoxTeretno.Checked ? "Y" : "N");
                vknp.FPutnickoVozilo = (checkBoxPutnicko.Checked ? "Y" : "N");

                vknp.Nosivost = (checkBoxTeretno.Checked ? int.Parse(txtNosivost.Text) : 0);
                vknp.TipProstora = (checkBoxTeretno.Checked ? txtTipProstora.Text : "");
                vknp.BrojPutnika = (checkBoxPutnicko.Checked ? int.Parse(txtBrojPutnika.Text) : 0);


                s.SaveOrUpdate(vknp);
                s.Flush();

                foreach (string boja in listBoxBojeVozila.Items)
                {
                    if (!this.ProveriBoje(vknp.Boje, boja))
                    {
                        Boja b = new Boja();
                        b.BojaVozila = boja;
                        b.UvezenoVozilo = vknp;
                        vknp.Boje.Add(b);
                        s.Save(b);
                        s.Save(vknp);
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
        private bool ProveriBoje(IList<Boja> boje, string boja)
        {
            foreach (Boja b in boje)
            {
                if (b.BojaVozila.Equals(boja))
                    return true;
            }
            return false;
        }

        private void checkBoxTeretno_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxTeretno.Checked)
            {
                label7.Visible = true;
                txtNosivost.Visible = true;
                label8.Visible = true;
                txtTipProstora.Visible = true;
            }
            else
            {
                label7.Visible = false;
                txtNosivost.Visible = false;
                label8.Visible = false;
                txtTipProstora.Visible = false;
            }
        }

        private void checkBoxPutnicko_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxPutnicko.Checked)
            {
                label10.Visible = true;
                txtBrojPutnika.Visible = true;
            }
            else
            {
                label10.Visible = false;
                txtBrojPutnika.Visible = false;
            }
        }

        private void ModifikujVoziloKojeNijeProdato_Load(object sender, EventArgs e)
        {
            try
            {
                this.PopuniListuVozila();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void PopuniListuVozila()
        {
            ISession s = DataLayer.GetSession();

            IList<VoziloKojeNijeProdato> vozila = s.QueryOver<UvezenoVozilo>()
                                                           .Where(x => x.GetType() == typeof(VoziloKojeNijeProdato))
                                                           .List<VoziloKojeNijeProdato>();


            foreach (VoziloKojeNijeProdato vp in vozila)
            {
                ListViewItem item = new ListViewItem(new string[] { vp.BrojSasije.ToString(), vp.BrojMotora.ToString(), vp.ModelVozila, vp.TipGoriva });

                listView2.Items.Add(item);
            }
            listView2.Refresh();

            s.Close();
        }

        private void btnDodajBoju_Click(object sender, EventArgs e)
        {
            try
            {
                listBoxBojeVozila.Items.Add(txtBojaVozila.Text);
                listBoxBojeVozila.Refresh();
                txtBojaVozila.Text = "";
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.ToString());
            }
        }
    }
}
