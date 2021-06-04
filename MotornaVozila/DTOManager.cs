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

        public static IList<SalonZaModifikovanje> VratiSaloneZaModifikovanjeDTO()
        {
            try
            {
                IList<SalonZaModifikovanje> salonZaModifikovanjes = new List<SalonZaModifikovanje>();
                ISession s = DataLayer.GetSession();
                IList<Salon> sa = s.QueryOver<Salon>()
                                .List<Salon>();

                foreach (Salon salon in sa)
                {
                    salonZaModifikovanjes.Add(new SalonZaModifikovanje(salon.Id, salon.Grad, salon.Adresa, salon.SefSalona, salon.SefServisa));
                }

                s.Close();

                return salonZaModifikovanjes;

            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.ToString());
                return null;
            }
        }

        public static IList<KupacInfo> VratiKupce()
        {

            ISession s = DataLayer.GetSession();
            IList<Kupac> kupci = s.QueryOver<Kupac>()
                            .List<Kupac>();

            IList<KupacInfo> kupciInfo = new List<KupacInfo>(); 
            foreach (Kupac k in kupci)
            {
                kupciInfo.Add(new KupacInfo(k.Id, k.LicnoIme, k.Prezime));
            }

            s.Close();

            return kupciInfo;

            
        }


        public static IList<KupovinaInfo> VratiKupovine()
        {

            ISession s = DataLayer.GetSession();
            IList<Kupovina> kupovine= s.QueryOver<Kupovina>()
                            .List<Kupovina>();

            IList<KupovinaInfo> kupovineInfo = new List<KupovinaInfo>();
            foreach (Kupovina k in kupovine)
            {
                kupovineInfo.Add(new KupovinaInfo(k.Id, k.DatumKupovine));
            }

            s.Close();

            return kupovineInfo;


        }

        public static void ObrisiKupovinu(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                Kupovina k = s.Load<Kupovina>(id);
                Salon salon = s.Load<Salon>(k.IdSalona.Id);
                Kupac kupac = s.Load<Kupac>(k.IdKupca.Id);

                salon.Kupovine.Remove(k);
                kupac.Kupovine.Remove(k);
                s.SaveOrUpdate(salon);
                s.SaveOrUpdate(kupac);

                s.Flush();
                IList<VoziloKojeJeProdato> vozila = k.ProdataVozila;
                k.ProdataVozila = new List<VoziloKojeJeProdato>();
                

                foreach(VoziloKojeJeProdato vkp in vozila)
                {
                    RadnikTehnickeStruke rts = s.Load<RadnikTehnickeStruke>(vkp.RadnikTehnStruke.Jmbg);
                    rts.UvezenaVozila.Remove(vkp);
                    s.SaveOrUpdate(rts);
                    s.Flush();
                    s.Delete(vkp);
                    s.Flush();
                }

                s.Delete(k);
                s.Flush();

                s.Close();
            }
            catch(Exception ec)
            {
                MessageBox.Show(ec.ToString());
            }
        }

        public static IList<PravnoLiceInfo> VratiPravnaLica()
        {

            ISession s = DataLayer.GetSession();
            IList<PravnoLice> kupci = s.QueryOver<Kupac>()
                                        .Where(x=>x.GetType()==typeof(PravnoLice))    
                                        .List<PravnoLice>();

            IList<PravnoLiceInfo> kupciInfo = new List<PravnoLiceInfo>();
            foreach (PravnoLice p in kupci)
            {
                kupciInfo.Add(new PravnoLiceInfo(p.Id, p.LicnoIme,p.Prezime,p.Pib));
            }

            s.Close();

            return kupciInfo;


        }


        public static IList<FizickoLiceInfo> VratiFizickaLica()
        {

            ISession s = DataLayer.GetSession();
            IList<FizickoLice> kupci = s.QueryOver<Kupac>()
                                        .Where(x => x.GetType() == typeof(FizickoLice))
                                        .List<FizickoLice>();

            IList<FizickoLiceInfo> kupciInfo = new List<FizickoLiceInfo>();
            foreach (FizickoLice f in kupci)
            {
                kupciInfo.Add(new FizickoLiceInfo(f.Id, f.LicnoIme, f.Prezime, f.Jmbg));
            }

            s.Close();

            return kupciInfo;


        }

    }
}
