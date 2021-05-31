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

    public partial class ModifikujVoziloKojeJeProdato : Form
    {
        private VoziloKojeJeProdato vkp;

        public ModifikujVoziloKojeJeProdato()
        {
            InitializeComponent();
            vkp = null;
        }

        private void listView2_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (listView2.SelectedItems.Count > 0)
                {
                    ISession s = DataLayer.GetSession();
                    vkp = s.Load<VoziloKojeJeProdato>(int.Parse(listView2.SelectedItems[0].Text));

                    txtBrojSasije.Text = vkp.BrojSasije.ToString();
                    txtBrojMotora.Text = vkp.BrojMotora.ToString();
                    txtModel.Text = vkp.ModelVozila;
                    txtTipGoriva.Text = vkp.TipGoriva;
                    txtKubikaza.Text = vkp.Kubikaza.ToString();
                    checkBoxTeretno.Checked = (vkp.FTeretnoVozilo.Equals("Y") ? true : false);
                    checkBoxPutnicko.Checked = (vkp.FPutnickoVozilo.Equals("Y") ? true : false);
                    txtBrojPutnika.Text = vkp.BrojPutnika.ToString();
                    txtNosivost.Text = vkp.Nosivost.ToString();
                    txtTipProstora.Text = vkp.TipProstora;

                    listBoxBojeVozila.Items.Clear();
                    foreach (Boja boja in vkp.Boje)
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

                vkp.BrojSasije = int.Parse(txtBrojSasije.Text);
                vkp.BrojMotora = int.Parse(txtBrojMotora.Text);
                vkp.ModelVozila = txtModel.Text;
                vkp.TipGoriva = txtTipGoriva.Text;
                vkp.Kubikaza = int.Parse(txtKubikaza.Text);
                vkp.FTeretnoVozilo = (checkBoxTeretno.Checked ? "Y" : "N");
                vkp.FPutnickoVozilo = (checkBoxPutnicko.Checked ? "Y" : "N");

                vkp.Nosivost = (checkBoxTeretno.Checked ? int.Parse(txtNosivost.Text) : 0);
                vkp.TipProstora = (checkBoxTeretno.Checked ? txtTipProstora.Text : "");
                vkp.BrojPutnika = (checkBoxPutnicko.Checked ? int.Parse(txtBrojPutnika.Text) : 0);


                s.SaveOrUpdate(vkp);
                s.Flush();

                foreach (string boja in listBoxBojeVozila.Items)
                {
                    if (!this.ProveriBoje(vkp.Boje, boja))
                    {
                        Boja b = new Boja();
                        b.BojaVozila = boja;
                        b.UvezenoVozilo = vkp;
                        vkp.Boje.Add(b);
                        s.Save(b);
                        s.Save(vkp);
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

        private void ModifikujVoziloKojeJeProdato_Load(object sender, EventArgs e)
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

            IList<VoziloKojeJeProdato> vozila = s.QueryOver<UvezenoVozilo>()
                                                           .Where(x => x.GetType() == typeof(VoziloKojeJeProdato))
                                                           .List<VoziloKojeJeProdato>();


            foreach (VoziloKojeJeProdato vp in vozila)
            {
                ListViewItem item = new ListViewItem(new string[] { vp.BrojSasije.ToString(), vp.BrojMotora.ToString(), vp.ModelVozila, vp.TipGoriva});

                listView2.Items.Add(item);
            }
            listView2.Refresh();

            s.Close();
        }

        private void checkBoxPutnicko_CheckedChanged(object sender, EventArgs e)
        {
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
