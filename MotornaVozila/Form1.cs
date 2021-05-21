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
using MotornaVozila.Entiteti;
using System.Globalization;

namespace MotornaVozila
{
    public partial class btnVratiNezavisnogEkonomistuIAngazovanja : Form
    {
        public btnVratiNezavisnogEkonomistuIAngazovanja()
        {
            InitializeComponent();
        }

        private void btnVratiNezavisnogEkonomistu_Click(object sender, EventArgs e)
        {
            try
            {


                ISession s = DataLayer.GetSession();

                NezavisniEkonomista n = s.Load<NezavisniEkonomista>(1111111);


                MessageBox.Show(n.Adresa);
                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.ToString());
            }

        }

        private void btnKreirajNezavisnogEkonomistu_Click(object sender, EventArgs e)
        {
            try
            {


                ISession s = DataLayer.GetSession();

                NezavisniEkonomista n = new NezavisniEkonomista()
                {
                    Jmbg = 1234567,
                    Ime = "Marija",
                    Prezime = "Rancic",
                    Adresa = "Marka Kraljevica 33"
                };

                s.Save(n);
                s.Flush();
                s.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnVratiZaposlenog_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                Zaposleni t = s.Load<Zaposleni>(1818181);
                IList<Zaposleni> z = s.QueryOver<Zaposleni>()
                                 .List<Zaposleni>();

                foreach (Zaposleni o in z)
                {
                    if (o.GetType() == typeof(RadnikTehnickeStruke))
                    {
                        RadnikTehnickeStruke rts = (RadnikTehnickeStruke)o;
                        MessageBox.Show("Radnik tehnicke struke: " + rts.Ime);

                    }
                    else if (o.GetType() == typeof(RadnikEkonomskeStruke))
                    {
                        RadnikEkonomskeStruke res = (RadnikEkonomskeStruke)o;
                        MessageBox.Show("Radnik ekonomske struke: " + res.Ime);

                    }
                    else
                    {
                        MessageBox.Show("Neki drugi radnik: " + o.Ime);


                    }
                }

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.ToString());
            }
        }

        private void btnDodajZaposlenog_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();


                NekiDrugiZaposleni n = new NekiDrugiZaposleni()
                {
                    Jmbg = 32456713,
                    Ime = "Valentina",
                    Prezime = "Markovic",
                    GodineRadnogStaza = 10,
                    DatumRodjena = DateTime.ParseExact("22-03-1993", "dd-MM-yyyy", CultureInfo.InvariantCulture),
                    DatumZaposlenja = DateTime.ParseExact("22-08-2013", "dd-MM-yyyy", CultureInfo.InvariantCulture),
                    StrucnaSprema = "Ima",
                    FZaposleniZaStalno = "Y",
                    FZaposleniPoUgovoru = "N",
                    Plata = 25000,
                    DatumIstekaUgovora = null
                };


                RadnikTehnickeStruke rts = new RadnikTehnickeStruke()
                {
                    Jmbg = 31456713,
                    Ime = "Vanja",
                    Prezime = "Simonovic",
                    GodineRadnogStaza = 11,
                    DatumRodjena = DateTime.ParseExact("22-03-1995", "dd-MM-yyyy", CultureInfo.InvariantCulture),
                    DatumZaposlenja = DateTime.ParseExact("11-11-2015", "dd-MM-yyyy", CultureInfo.InvariantCulture),
                    StrucnaSprema = "Ima",
                    FZaposleniZaStalno = "N",
                    FZaposleniPoUgovoru = "Y",
                    DatumIstekaUgovora = DateTime.ParseExact("01-01-2029", "dd-MM-yyyy", CultureInfo.InvariantCulture),
                    //TipZaposlenog ="Radnik tehnicke struke"

                };

                RadnikEkonomskeStruke res = new RadnikEkonomskeStruke()
                {
                    Jmbg = 21456713,
                    Ime = "Miljana",
                    Prezime = "Maric",
                    GodineRadnogStaza = 11,
                    DatumRodjena = DateTime.ParseExact("22-03-1991", "dd-MM-yyyy", CultureInfo.InvariantCulture),
                    DatumZaposlenja = DateTime.ParseExact("29-12-2009", "dd-MM-yyyy", CultureInfo.InvariantCulture),
                    StrucnaSprema = "Ima",
                    FZaposleniZaStalno = "N",
                    FZaposleniPoUgovoru = "Y",
                    DatumIstekaUgovora = DateTime.ParseExact("22-03-2030", "dd-MM-yyyy", CultureInfo.InvariantCulture),
                    //TipZaposlenog = "Radnik ekonomske struke"

                };


                s.Save(n);
                s.Save(rts);
                s.Save(res);

                s.Flush();
                s.Close();



            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.ToString());
            }

        }

        private void btnVratiUvezenoVozilo_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                IList<UvezenoVozilo> z = s.QueryOver<UvezenoVozilo>()
                                 .List<UvezenoVozilo>();

                foreach (UvezenoVozilo o in z)
                {
                    if (o.GetType() == typeof(VoziloKojeJeProdato))
                    {
                        VoziloKojeJeProdato vp = (VoziloKojeJeProdato)o;
                        MessageBox.Show("Vozilo koje je prodato: " + vp.BrojSasije);

                    }
                    else if (o.GetType() == typeof(VoziloKojeNijeProdato))
                    {
                        VoziloKojeNijeProdato vnp = (VoziloKojeNijeProdato)o;
                        MessageBox.Show("Vozilo koje nije prodato: " + vnp.BrojSasije);

                    }
                    else
                    {
                        throw new Exception("Greska");


                    }
                }

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.ToString());
            }
        }

        private void btnDodajUvezenoVozilo_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                RadnikTehnickeStruke rts = s.Load<RadnikTehnickeStruke>(31456713);

                VoziloKojeJeProdato vp = new VoziloKojeJeProdato()
                {
                    BrojSasije = 31456713,
                    BrojMotora = 5252342,
                    TipGoriva = "Dizel",
                    Kubikaza = 3000,
                    DatumUvoza = DateTime.ParseExact("22-03-1995", "dd-MM-yyyy", CultureInfo.InvariantCulture),
                    ModelVozila = "Audi",
                    FPutnickoVozilo = "Y",
                    BrojPutnika = 5,
                    FTeretnoVozilo = "Y",
                    Nosivost = 100,
                    TipProstora = "Prostrano",
                    RadnikTehnStruke = rts


                };

                VoziloKojeNijeProdato vnp = new VoziloKojeNijeProdato()
                {
                    BrojSasije = 39456713,
                    BrojMotora = 5252342,
                    TipGoriva = "Dizel",
                    Kubikaza = 3000,
                    DatumUvoza = DateTime.ParseExact("22-03-1995", "dd-MM-yyyy", CultureInfo.InvariantCulture),
                    ModelVozila = "Audi",
                    FPutnickoVozilo = "N",

                    FTeretnoVozilo = "Y",
                    Nosivost = 100,
                    TipProstora = "Prostrano",
                    RadnikTehnStruke = rts

                };




                s.Save(vp);
                s.Save(vnp);

                rts.UvezenaVozila.Add(vp);
                rts.UvezenaVozila.Add(vnp);

                s.Save(rts);


                s.Flush();
                s.Close();



            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.ToString());
            }
        }

        private void btnVratiSalon_Click(object sender, EventArgs e)
        {
            try
            {

                ISession s = DataLayer.GetSession();

                Salon n = s.Load<Salon>(1);


                MessageBox.Show(n.Grad);
                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.ToString());
            }
        }

        private void btnDodajSalon_Click(object sender, EventArgs e)
        {
            try
            {

                ISession s = DataLayer.GetSession();

                Salon n = new Salon()
                {
                    Grad = "Pancevo",
                    Adresa = "Marka Kraljevica 99",
                    StepenOpremljenostiServisa = "Cetvrti",
                    SefSalona = "Miodrag",
                    SefServisa = "Nevena",
                    FServis = "N"

                };

                s.Save(n);
                s.Flush();
                s.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnVratiServis_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                IList<Salon> salon = s.QueryOver<Salon>()
                 .List<Salon>();

                foreach (Salon ns in salon)
                {
                    if (ns.FServis == "Y")
                    {
                        foreach (TipRadova t in ns.TipoviRadova)
                        {
                            MessageBox.Show("Salon id: " + ns.Id + " pruza radove: " + t.Tip_Radova);
                        }
                    }
                }


                s.Close();
            }

            catch (Exception ec)
            {
                MessageBox.Show(ec.ToString());
            }
        }

        private void btnDodajServis_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                IList<TipRadova> tipRadova = s.QueryOver<TipRadova>()
                 .List<TipRadova>();

                Salon novi = new Salon();
                novi.Adresa = "Hisarska 10";
                novi.Grad = "Prokuplje";
                novi.SefSalona = "Natasa";
                novi.SefServisa = "Borivoje";
                novi.StepenOpremljenostiServisa = "Drugi";
                novi.FServis = "Y";




                foreach (TipRadova ns in tipRadova)
                {
                    novi.TipoviRadova.Add(ns);
                    ns.Servis.Add(novi);

                }

                s.Save(novi);
                s.Flush();


                s.Close();
            }

            catch (Exception ec)
            {
                MessageBox.Show(ec.ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                IList<NezavisniEkonomista> ne = s.QueryOver<NezavisniEkonomista>()
                 .List<NezavisniEkonomista>();

                foreach (NezavisniEkonomista ns in ne)
                {
                    if (ns.Saloni.Count() > 0)
                    {
                        foreach (Salon t in ns.Saloni)
                        {
                            MessageBox.Show("Salon id: " + t.Id + " je angazovao nezavisnog ekonomistu: " + ns.Jmbg);
                        }
                    }
                }


                s.Close();
            }

            catch (Exception ec)
            {
                MessageBox.Show(ec.ToString());
            }
        }

        private void btnKreirajNezEkonomistuIAnga_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                IList<Salon> saloni = s.QueryOver<Salon>()
                 .List<Salon>();

                NezavisniEkonomista ne = new NezavisniEkonomista()
                {
                    Jmbg = 5555555,
                    Ime = "Jovana",
                    Prezime = "Djokovic",
                    Adresa = "Vuka Karandzica 33"


                };

                foreach (Salon salon in saloni)
                {
                    ne.Saloni.Add(salon);
                    salon.NezavisniEkonomisti.Add(ne);

                }

                //Cuvamo prvo NezavisnogEkonomistu
                s.Save(ne);
                s.Flush();


                s.Close();
            }

            catch (Exception ec)
            {
                MessageBox.Show(ec.ToString());
            }
        }

        private void btnVratiVozilaKojaNisuProdataiNjihoveSalone_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                IList<UvezenoVozilo> uv = s.QueryOver<UvezenoVozilo>()
                                       .List<UvezenoVozilo>();

                IList<Salon> saloni = s.QueryOver<Salon>()
                       .List<Salon>();


                foreach (UvezenoVozilo v in uv)
                {
                    if (v.GetType() == typeof(VoziloKojeNijeProdato))
                    {
                        VoziloKojeNijeProdato np = (VoziloKojeNijeProdato)v;
                        MessageBox.Show("Vozilo koje nije prodato broj sasije: " + np.BrojSasije + " je izlozen u salonu: " + np.IzlozenUSalonu.Id);
                    }
                }


                foreach (Salon salon in saloni)
                {
                    if (salon.VozilaKojaNisuProdata.Count() > 0)
                    {
                        foreach (VoziloKojeNijeProdato np in salon.VozilaKojaNisuProdata)
                            MessageBox.Show("Vozilo koje nije prodato broj sasije: " + np.BrojSasije + " je izlozen u salonu: " + salon.Id);
                    }
                }


                s.Close();

            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.ToString());
            }
        }

        private void btnKreirajVoziloKojeNijeProdato_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                Salon salon = s.Load<Salon>(3);

                RadnikTehnickeStruke rts = s.Load<RadnikTehnickeStruke>(1313131);

                VoziloKojeNijeProdato np = new VoziloKojeNijeProdato()
                {
                    BrojSasije = 43242345,
                    DatumUvoza = DateTime.ParseExact("22-03-2020", "dd-MM-yyyy", CultureInfo.InvariantCulture),
                    BrojMotora = 96473435,
                    TipGoriva = "Dizel",
                    Kubikaza = 2000,
                    ModelVozila = "Mercedes",
                    FPutnickoVozilo = "Y",
                    BrojPutnika = 5,
                    FTeretnoVozilo = "N",
                    RadnikTehnStruke = rts,
                    IzlozenUSalonu = salon

                };

                rts.UvezenaVozila.Add(np);
                salon.VozilaKojaNisuProdata.Add(np);
                s.Save(np);
                s.Save(rts);
                s.Save(salon);

                s.Flush();
                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.ToString());
            }
        }

        private void btnVratiKupce_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                IList<Kupac> k = s.QueryOver<Kupac>()
                                 .List<Kupac>();

                foreach (Kupac o in k)
                {
                    if (o.GetType() == typeof(FizickoLice))
                    {
                        FizickoLice fl = (FizickoLice)o;
                        MessageBox.Show("Naziv fizickog lica: " + fl.LicnoIme + ", PIB:" + fl.Pib);

                    }
                    else if (o.GetType() == typeof(PravnoLice))
                    {
                        PravnoLice pl = (PravnoLice)o;
                        MessageBox.Show("Naziv pravnog lica: " + pl.LicnoIme + ", JMBG:" + pl.Jmbg);

                    }
                    else
                    {
                        throw new Exception("Greska");


                    }
                }

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.ToString());
            }
        }

        private void btnDodajKupce_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                FizickoLice fl = new FizickoLice()
                {
                    LicnoIme = "kristina",
                    Prezime = "Dimitrijevic",
                    Pib = 404040
                };

                PravnoLice pl = new PravnoLice()
                {
                    LicnoIme = "Djordje",
                    Prezime = "Stanic",
                    Jmbg = 9783421

                };

                s.Save(fl);
                s.Save(pl);
                s.Flush();


                s.Close();
            }

            catch (Exception ec)
            {
                MessageBox.Show(ec.ToString());
            }
        }

        private void btnVratiKupovine_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                IList<Kupovina> k = s.QueryOver<Kupovina>()
                 .List<Kupovina>();

                foreach (Kupovina kup in k)
                {
                    MessageBox.Show("Id kupovine: " + kup.Id + ", Ime kupca: " + kup.IdKupca.LicnoIme + ", grad salona: " + kup.IdSalona.Grad);
                }


                s.Close();

            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.ToString());
            }
        }

        private void btnDodajKupovinu_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                Salon salon = s.Load<Salon>(30);
                Kupac k = s.Load<Kupac>(11);

                Kupovina kupovina = new Kupovina()
                {
                    DatumKupovine = DateTime.ParseExact("11-12-2020", "dd-MM-yyyy", CultureInfo.InvariantCulture),
                    IdSalona = salon,
                    IdKupca = k
                };

                salon.Kupovine.Add(kupovina);

                k.Kupovine.Add(kupovina);

                s.Save(kupovina);
                s.Save(salon);
                s.Save(k);

                s.Flush();



                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.ToString());
            }
        }

        private void btnVratiProdataVozila_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                IList<UvezenoVozilo> k = s.QueryOver<UvezenoVozilo>()
                                    .List<UvezenoVozilo>();

                foreach (UvezenoVozilo o in k)
                {
                    if (o.GetType() == typeof(VoziloKojeJeProdato))
                    {
                        VoziloKojeJeProdato vp = (VoziloKojeJeProdato)o;
                        MessageBox.Show("Vozilo koje je prodato: " + vp.BrojSasije + " id kupovine: " + vp.Kupovina.Id + ", Kupac: " + vp.Kupovina.IdKupca.LicnoIme + ", Grad salona:" + vp.Kupovina.IdSalona.Grad);

                    }
                }




                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.ToString());
            }
        }

        private void btnDodajVoziloKupovini_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                Kupovina k = s.Load<Kupovina>(1);

                RadnikTehnickeStruke rts = s.Load<RadnikTehnickeStruke>(1414141);

                VoziloKojeJeProdato vp = new VoziloKojeJeProdato()
                {
                    BrojSasije = 32561264,
                    BrojMotora = 5632624,
                    DatumUvoza = DateTime.ParseExact("11-12-2020", "dd-MM-yyyy", CultureInfo.InvariantCulture),
                    TipGoriva = "Benzinac",
                    Kubikaza = 5000,
                    ModelVozila = "Masserati",
                    FPutnickoVozilo = "Y",
                    BrojPutnika = 5,
                    FTeretnoVozilo = "Y",
                    Nosivost = 15000,
                    TipProstora = "Prostoran",
                    RadnikTehnStruke = rts,
                    Kupovina = k,



                };

                rts.UvezenaVozila.Add(vp);
                k.ProdataVozila.Add(vp);

                s.Save(vp);
                s.Save(rts);
                s.Save(k);
                s.Flush();
                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.ToString());
            }
        }

        private void btnVracanjeVozilaPrimljenaNaServis_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                VozilaPrimljenaNaServis vp = s.Load<VozilaPrimljenaNaServis>(6666666);
                MessageBox.Show("Vozilo sa registarskim brojem " + vp.RegistarskiBroj + " zaposleni koji je primio vozilo je: " + vp.Zaposleni.Ime);
                Zaposleni z = s.Load<Zaposleni>(1616161);
                MessageBox.Show("Zaposleni " + z.Ime + "prvo vozilo koje je primio na servis " + z.PrimioVoziloNaServis[0].RegistarskiBroj);
                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.ToString());
            }
        }

        private void btnDodajVoziloPrimljenoNaServis_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Zaposleni z = s.Load<Zaposleni>(1313131);

                VozilaPrimljenaNaServis vp = new VozilaPrimljenaNaServis()
                {
                    ModelVozila = "Opel",
                    GodinaProizvodnje = 2000,
                    OpisProblema = "Ne rade brisaci",
                    DatumPrijema = DateTime.ParseExact("04-05-2018", "dd-MM-yyyy", CultureInfo.InvariantCulture),
                    DatumZavrsetkaRadova = DateTime.ParseExact("15-07-2018", "dd-MM-yyyy", CultureInfo.InvariantCulture),
                    Zaposleni = z
                };

                z.PrimioVoziloNaServis.Add(vp);

                s.Save(vp);
                s.Save(z);
                s.Flush();

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.ToString());
            }
        }

        private void btnVratiVlasnikeIVozila_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                IList<Vlasnik> k = s.QueryOver<Vlasnik>()
                                    .List<Vlasnik>();

                foreach (Vlasnik v in k)
                {
                    foreach (VozilaPrimljenaNaServis vp in v.JePoslaoVoziloNaServis)
                    {
                        if (v.GetType() == typeof(RegistrovaniKupac))
                        {
                            RegistrovaniKupac rk = (RegistrovaniKupac)v;
                            MessageBox.Show("Id vlasnika: " + v.Id + " je registrovani kupac, Ime mu je " + rk.Kupac.LicnoIme + " je poslao vozilo na servis " + vp.RegistarskiBroj);
                        }
                        else
                        {
                            NeregistrovaniKupac nk = (NeregistrovaniKupac)v;
                            MessageBox.Show("Id vlasnika: " + v.Id + " ime vlasnika " + nk.Ime + " je poslao vozilo na servis " + vp.RegistarskiBroj);
                        }
                    }
                }

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.ToString());
            }
        }

        private void btnDodavanjeVozilaNaServis_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                RegistrovaniKupac rk = s.Load<RegistrovaniKupac>(2);
                Zaposleni z = s.Load<Zaposleni>(21456713);

                VozilaPrimljenaNaServis v = new VozilaPrimljenaNaServis()
                {
                    ModelVozila = "Karavan",
                    GodinaProizvodnje = 2001,
                    OpisProblema = "Ne rade kocnice",
                    DatumPrijema = DateTime.ParseExact("20-10-2005", "dd-MM-yyyy", CultureInfo.InvariantCulture),
                    DatumZavrsetkaRadova = DateTime.ParseExact("25-12-2005", "dd-MM-yyyy", CultureInfo.InvariantCulture),
                    Zaposleni = z,
                    Vlasnik = rk,
                };

                rk.JePoslaoVoziloNaServis.Add(v);
                z.PrimioVoziloNaServis.Add(v);

                s.Save(v);
                s.Save(z);
                s.Save(rk);
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
