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
    public partial class ObrisiSalon : Form
    {
        public ObrisiSalon()
        {
            InitializeComponent();
        }

        private void ObrisiSalon_Load(object sender, EventArgs e)
        {
            this.PopuniListuSalona();
        }

        private void PopuniListuSalona()
        {
            IList<SalonZaBrisanje> saloni = DTOManager.VratiSaloneZaBrisanjeDTO();

            foreach(SalonZaBrisanje salon in saloni)
            {
                ListViewItem item = new ListViewItem(new string[] { salon.Id.ToString(), salon.Grad, salon.Adresa });

                listView1.Items.Add(item);
            }
            listView1.Refresh();
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            if(listView1.SelectedItems.Count>0)
            {
                DTOManager.IzbrisiVoziloKojeNijeProdatoZaSalon(int.Parse(listView1.SelectedItems[0].Text));
                DTOManager.ObrisiKupovinuZaSalon(int.Parse(listView1.SelectedItems[0].Text));

                try
                {
                    ISession s = DataLayer.GetSession();
                    Salon salon=s.Load<Salon>(int.Parse(listView1.SelectedItems[0].Text));
                    foreach (TipRadova t in salon.TipoviRadova)
                    {
                        t.Servis.Remove(salon);
                        
                        s.SaveOrUpdate(t);
                        
                    }
                    salon.TipoviRadova = new List<TipRadova>();
                    s.SaveOrUpdate(salon);
                    foreach (NezavisniEkonomista n in salon.NezavisniEkonomisti)
                    {
                        n.Saloni.Remove(salon);
                        
                        s.SaveOrUpdate(n);
                        

                    }
                    salon.NezavisniEkonomisti = new List<NezavisniEkonomista>();
                    s.SaveOrUpdate(salon);

                    s.Flush();
                    s.Delete(salon);
                    s.Flush();

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
}
