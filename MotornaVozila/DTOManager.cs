using MotornaVozila.Entiteti;
using NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static MotornaVozila.DTOs;

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

        public static void KreirajTipRadova(TipRadova t)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                s.Save(t);
                s.Flush();
                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.ToString());
            }
        }

        public static IList<SalonZaBrisanje> VratiSaloneZaBrisanjeDTO()
        {
            try
            {
                IList<SalonZaBrisanje> saloni = new List<SalonZaBrisanje>();
                ISession s = DataLayer.GetSession();
                IList<Salon> sal = s.QueryOver<Salon>()
                                .List<Salon>();

                foreach(Salon salon in sal)
                {
                    saloni.Add(new SalonZaBrisanje(salon.Id, salon.Grad, salon.Adresa));
                }



                s.Close();

                return saloni;

            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.ToString());
                return null;
            }

            
        }

        public static void IzbrisiVoziloKojeNijeProdatoZaSalon(int idSalona)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                Salon salonZaBrisanje = s.Load<Salon>(idSalona);
                IList<VoziloKojeNijeProdato> nisuProdata = salonZaBrisanje.VozilaKojaNisuProdata;
                salonZaBrisanje.VozilaKojaNisuProdata = new List<VoziloKojeNijeProdato>();
                foreach (VoziloKojeNijeProdato v in nisuProdata)
                {
                    VoziloKojeNijeProdato vknp = s.Load<VoziloKojeNijeProdato>(v.BrojSasije);
                    RadnikTehnickeStruke rts = s.Load<RadnikTehnickeStruke>(vknp.RadnikTehnStruke.Jmbg);
                    

                    rts.UvezenaVozila.Remove(vknp);
                    
                    s.SaveOrUpdate(rts);
                    s.Flush();
                    s.Delete(vknp);
                    s.Flush();

                }
                s.SaveOrUpdate(salonZaBrisanje);
                s.Flush();
                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.ToString());
            }
        }

        public static void ObrisiKupovinuZaSalon(int idSalona)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                Salon salonZaBrisanje = s.Load<Salon>(idSalona);
                IList<Kupovina> kup = salonZaBrisanje.Kupovine;
                salonZaBrisanje.Kupovine = new List<Kupovina>();
                foreach (Kupovina kupovina in kup)
                {
                    Kupovina k = s.Load<Kupovina>(kupovina.Id);
                    Kupac kupac = s.Load<Kupac>(k.IdKupca.Id);
                    
                    kupac.Kupovine.Remove(k);
                    s.SaveOrUpdate(kupac);
                    
                    s.Flush();

                    IList<VoziloKojeJeProdato> prodata = k.ProdataVozila;
                    k.ProdataVozila = new List<VoziloKojeJeProdato>();
                    foreach (VoziloKojeJeProdato vkp in prodata)
                    {
                        
                        RadnikTehnickeStruke rts = s.Load<RadnikTehnickeStruke>(vkp.RadnikTehnStruke.Jmbg);
                        rts.UvezenaVozila.Remove(vkp);
                        s.SaveOrUpdate(rts);

                        s.Delete(vkp);
                        s.Flush();

                    }
                    s.SaveOrUpdate(k);
                    s.Flush();
                    s.Delete(k);
                    s.Flush();
                    
                }

                s.SaveOrUpdate(salonZaBrisanje);
                s.Flush();
                s.Close();
            }

            catch(Exception ec)
            {
                MessageBox.Show(ec.ToString());
            }
        }

    }
}
