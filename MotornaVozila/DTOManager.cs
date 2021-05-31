using MotornaVozila.Entiteti;
using NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MotornaVozila
{
    public class DTOManager
    {
        public static void SacuvajNezavinsogEkonomistu(NezavisniEkonomista n, TelefonNezavisniEkonomista tel, TelefonNezavisniEkonomista tel2)
        {
            try
            {
                ISession s = DataLayer.GetSession();


                s.Save(n);
                s.Save(tel);
                s.Save(tel2);
                s.Flush();
                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.ToString());
            }
        }

        public static void AzurirajNezavisnogEkonomistu(NezavisniEkonomista n)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                s.SaveOrUpdate(n);
                s.Flush();
                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.ToString());
            }
        }

        public static void ObrisiNezavisnogEkonomistu(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                NezavisniEkonomista n = s.Load<NezavisniEkonomista>(id);
                n.Saloni = new List<Salon>();
                IList<Salon> saloni = s.QueryOver<Salon>()
                                        .List<Salon>();
                foreach (Salon salon in saloni)
                {
                    salon.NezavisniEkonomisti.Remove(n);
                    s.SaveOrUpdate(salon);
                    s.Flush();
                }
                n.Telefoni = new List<TelefonNezavisniEkonomista>();
                s.SaveOrUpdate(n);
                s.Flush();


                IList<TelefonNezavisniEkonomista> telefoni = s.QueryOver<TelefonNezavisniEkonomista>()
                                .Where(x => x.NezavisniEkonomista == n)
                                .List<TelefonNezavisniEkonomista>();

                foreach (TelefonNezavisniEkonomista t in telefoni)
                {
                    s.Delete(t);
                    s.Flush();
                }




                n = s.Load<NezavisniEkonomista>(n.Jmbg);
                s.Refresh(n);
                s.Delete(n);

                s.Flush();
                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.ToString());
            }
        }

        public static void ObrisiVoziloKojeJeProdato(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                VoziloKojeJeProdato vkp = s.Load<VoziloKojeJeProdato>(id);
                RadnikTehnickeStruke rts = s.Load<RadnikTehnickeStruke>(vkp.RadnikTehnStruke.Jmbg);
                Kupovina k = s.Load<Kupovina>(vkp.Kupovina.Id);




                s.Delete(vkp);

                rts.UvezenaVozila.Remove(vkp);
                k.ProdataVozila.Remove(vkp);
                s.Flush();
                s.SaveOrUpdate(rts);
                s.SaveOrUpdate(k);
                s.Flush();

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.ToString());
            }
        }

        public static void ObrisiVoziloKojeNijeProdato(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                VoziloKojeNijeProdato vknp = s.Load<VoziloKojeNijeProdato>(id);
                RadnikTehnickeStruke rts = s.Load<RadnikTehnickeStruke>(vknp.RadnikTehnStruke.Jmbg);
                Salon salon = s.Load<Salon>(vknp.IzlozenUSalonu.Id);

                s.Delete(vknp);

                rts.UvezenaVozila.Remove(vknp);
                salon.VozilaKojaNisuProdata.Remove(vknp);
                s.Flush();
                s.SaveOrUpdate(rts);
                s.SaveOrUpdate(salon);
                s.Flush();

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.ToString());
            }
        }
    }
}
