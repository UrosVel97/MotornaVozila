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
using MotornaVozila.Forme;

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

                IList<NezavisniEkonomista> nezavisniEkonomista = s.QueryOver<NezavisniEkonomista>()
                                 .List<NezavisniEkonomista>();

                foreach (NezavisniEkonomista n in nezavisniEkonomista)
                {
                    foreach (Salon salon in n.Saloni)
                    {
                        MessageBox.Show("Nezavisni ekonomista: " + n.Ime + " " + n.Prezime + " je angazovao Salon sa id-jem: " + salon.Id);
                    }

                    foreach (TelefonNezavisniEkonomista t in n.Telefoni)
                    {
                        MessageBox.Show("Nezavisni ekonomista: " + n.Ime + " " + n.Prezime + " ima broj: " + t.BrojTelefona);
                    }
                }


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

                DodajNezavisnogEkonomistu forma = new DodajNezavisnogEkonomistu();

                this.Visible = false;
                forma.ShowDialog();
                this.Visible = true;




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


                        foreach (Specijalnost spec in rts.Specijalnosti)
                        {
                            MessageBox.Show("Radnik tehnicke struke sa jmbg: " + rts.Jmbg + ", ima specijalnost: " + spec.SpecijalnostRadnika);

                        }
                        if (rts.Specijalnosti.Count == 0)
                        {
                            MessageBox.Show("Radnik tehnicke struke sa jmbg: " + rts.Jmbg + " nema specijalnosti");
                        }

                        foreach (UvezenoVozilo uv in rts.UvezenaVozila)
                        {
                            MessageBox.Show("Radnik tehnicke struke sa jmbg: " + rts.Jmbg + ", je uvezo vozilo sa brojem sasije " + uv.BrojSasije + ", model: " + uv.ModelVozila);
                        }
                        if (rts.UvezenaVozila.Count == 0)
                        {
                            MessageBox.Show("Radnik tehnicke struke sa jmbg: " + rts.Jmbg + " nije vrsio prijem uvezenog vozila");
                        }

                        foreach (VozilaPrimljenaNaServis vps in rts.PrimioVoziloNaServis)
                        {
                            MessageBox.Show("Radnik tehnicke struke sa jmbg: " + rts.Jmbg + ", je primio vozilo na servis sa registrskim brojem" + vps.RegistarskiBroj + ", opis problema: " + vps.OpisProblema);
                        }
                        if (rts.PrimioVoziloNaServis.Count == 0)
                        {
                            MessageBox.Show("Radnik tehnicke struke sa jmbg: " + rts.Jmbg + " nije primio nijedno vozilo na servis");
                        }

                        if (rts.FZaposleniZaStalno.Equals("Y"))
                        {
                            MessageBox.Show("Radnik tehnicke struke sa jmbg: " + rts.Jmbg + " je zaposlen za stalno i ima platu " + rts.Plata + "din");
                        }
                        else
                        {
                            MessageBox.Show("Radnik tehnicke struke sa jmbg: " + rts.Jmbg + " je zaposlen po ugovoru do datuma: " + rts.DatumIstekaUgovora.ToString());

                        }


                    }
                    else if (o.GetType() == typeof(RadnikEkonomskeStruke))
                    {
                        RadnikEkonomskeStruke res = (RadnikEkonomskeStruke)o;


                        MessageBox.Show("Radnik ekonomske struke ima jmbg: " + res.Jmbg + ", ime: " + res.Ime + ", prezime: " + res.Prezime + ", datum zaposljenja: " + res.DatumZaposlenja.ToString());

                        foreach (VozilaPrimljenaNaServis vps in res.PrimioVoziloNaServis)
                        {
                            MessageBox.Show("Radnik ekonomske struke sa jmbg: " + res.Jmbg + ", je primio vozilo na servis sa registrskim brojem: " + vps.RegistarskiBroj + ", opis problema: " + vps.OpisProblema);
                        }
                        if (res.PrimioVoziloNaServis.Count == 0)
                        {
                            MessageBox.Show("Radnik ekonomske struke sa jmbg: " + res.Jmbg + " nije primio nijedno vozilo na servis");
                        }

                        if (res.FZaposleniZaStalno.Equals("Y"))
                        {
                            MessageBox.Show("Radnik ekonomske struke sa jmbg: " + res.Jmbg + " je zaposlen za stalno i ima platu " + res.Plata + "din");
                        }
                        else
                        {
                            MessageBox.Show("Radnik ekonomske struke sa jmbg: " + res.Jmbg + " je zaposlen po ugovoru do datuma: " + res.DatumIstekaUgovora.ToString());

                        }

                    }
                    else
                    {

                        MessageBox.Show("Neki drugi zaposleni sa jmbg: " + o.Jmbg + ", ime: " + o.Ime + ", strucna sprema: " + o.StrucnaSprema);

                        foreach (VozilaPrimljenaNaServis vps in o.PrimioVoziloNaServis)
                        {
                            MessageBox.Show("Neki drugi zaposleni sa jmbg: " + o.Jmbg + ", je primio vozilo na servis sa registrskim brojem: " + vps.RegistarskiBroj + ", opis problema: " + vps.OpisProblema);
                        }
                        if (o.PrimioVoziloNaServis.Count == 0)
                        {
                            MessageBox.Show("Neki drugi zaposleni sa jmbg: " + o.Jmbg + " nije primio nijedno vozilo na servis");
                        }

                        if (o.FZaposleniZaStalno.Equals("Y"))
                        {
                            MessageBox.Show("Neki drugi zaposleni sa jmbg: " + o.Jmbg + " je zaposlen za stalno i ima platu: " + o.Plata + "din");
                        }
                        else
                        {
                            MessageBox.Show("Neki drugi zaposleni sa jmbg: " + o.Jmbg + " je zaposlen po ugovoru do datuma: " + o.DatumIstekaUgovora.ToString());

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

        private void btnDodajZaposlenog_Click(object sender, EventArgs e)
        {

            DodajZaposlenog forma = new DodajZaposlenog();

            this.Visible = false;
            forma.ShowDialog();
            this.Visible = true;




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
                        MessageBox.Show("Vozilo koje je prodato ima broj sasije " + vp.BrojSasije + ", model vozila je: " + vp.ModelVozila + ". Id kupovine: " + vp.Kupovina.Id + ", kupljeno datuma: " + vp.Kupovina.DatumKupovine.ToString());
                        if (vp.FPutnickoVozilo.Equals("Y") && vp.FTeretnoVozilo.Equals("Y"))
                        {
                            MessageBox.Show("Vozilo koje je prodato ima broj sasije " + vp.BrojSasije + ", vozilo je i putnicko i teretno vozilo. Broj putnika: " + vp.BrojPutnika + ", Nosivost: " + vp.Nosivost + ", Tip prostora: " + vp.TipProstora);

                        }
                        else if (vp.FPutnickoVozilo.Equals("Y") && vp.FTeretnoVozilo.Equals("N"))
                        {
                            MessageBox.Show("Vozilo koje je prodato ima broj sasije " + vp.BrojSasije + ", vozilo je putnicko. Broj putnika: " + vp.BrojPutnika);
                        }
                        else
                        {
                            MessageBox.Show("Vozilo koje je prodato ima broj sasije " + vp.BrojSasije + ", vozilo je teretno. Nosivost: " + vp.Nosivost + ", Tip prostora: " + vp.TipProstora);
                        }

                        foreach (Boja b in vp.Boje)
                        {
                            MessageBox.Show("Vozilo koje je prodato ima broj sasije " + vp.BrojSasije + " je boje " + b.BojaVozila);
                        }

                        if (vp.Boje.Count == 0)
                        {
                            MessageBox.Show("Vozilo koje je prodato ima broj sasije " + vp.BrojSasije + " nema boju");
                        }
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


            DodajUvezenoVozilo forma = new DodajUvezenoVozilo();

            this.Visible = false;
            forma.ShowDialog();
            this.Visible = true;

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
            catch (Exception ec)
            {
                MessageBox.Show(ec.ToString());
            }
        }

        private void btnModifikujNezavisnogEkonomistu_Click(object sender, EventArgs e)
        {
            try
            {

                ModifikujNezavisnogEkonomistu forma = new ModifikujNezavisnogEkonomistu();

                this.Visible = false;
                forma.ShowDialog();
                this.Visible = true;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnObrisiNezavisnogEkonomistu_Click(object sender, EventArgs e)
        {
            try
            {

                ObrisiNezavisnogEkonomistu forma = new ObrisiNezavisnogEkonomistu();

                this.Visible = false;
                forma.ShowDialog();
                this.Visible = true;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnModifikujZaposlenog_Click(object sender, EventArgs e)
        {

            ModifikujZaposlenog forma = new ModifikujZaposlenog();
            this.Visible = false;
            forma.ShowDialog();
            this.Visible = true;


        }

        private void btnModifikujUvezenoVozilo_Click(object sender, EventArgs e)
        {
            ModifikujUvezenoVozilo forma = new ModifikujUvezenoVozilo();
            this.Visible = false;
            forma.ShowDialog();
            this.Visible = true;
        }

        private void btnObrisiUvezenoVozilo_Click(object sender, EventArgs e)
        {
            try
            {
                ObrisiUvezenoVozilo forma = new ObrisiUvezenoVozilo();

                this.Visible = false;
                forma.ShowDialog();
                this.Visible = true;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnVratiNezavisnogEkonomistuIAngazovanja_Load(object sender, EventArgs e)
        {

        }

        private void btnDodajSaloon_Click(object sender, EventArgs e)
        {
            try
            {
                DodajSalon forma = new DodajSalon();

                this.Visible = false;
                forma.ShowDialog();
                this.Visible = true;
                this.DialogResult = DialogResult.OK;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnIzbrisiSalon_Click(object sender, EventArgs e)
        {
            try
            {
                ObrisiSalon forma = new ObrisiSalon();

                this.Visible = false;
                forma.ShowDialog();
                this.Visible = true;
                this.DialogResult = DialogResult.OK;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            this.DialogResult = DialogResult.OK;
        }

        private void btnModifikujSalon_Click(object sender, EventArgs e)
        {
            ModifikujSalon forma = new ModifikujSalon();
            this.Visible = false;
            forma.ShowDialog();
            this.Visible = true;
        }

        private void btnVratiSalone_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                IList<Salon> m = s.QueryOver<Salon>()
                                 .List<Salon>();

                ISession t = DataLayer.GetSession();

                IList<UvezenoVozilo> z = t.QueryOver<UvezenoVozilo>()
                                 .List<UvezenoVozilo>();

                foreach (Salon o in m)
                {
                    foreach (NezavisniEkonomista ne in o.NezavisniEkonomisti)
                    {
                        foreach (TelefonNezavisniEkonomista tne in ne.Telefoni)
                        {
                            MessageBox.Show("Salon: " + o.Id + " je angazovao nezavisnog ekonomistu " + ne.Ime + " " + ne.Prezime + " kontakt telefon " + tne.BrojTelefona);
                        }
                    }

                    foreach (TipRadova tp in o.TipoviRadova)
                    {
                        if (o.FServis == "Y")
                        {
                            MessageBox.Show("Salon " + o.Id + ", sef salona je " + o.SefSalona + " ima servis ciji je sef " + o.SefServisa + " i servis obavlja: " + tp.Tip_Radova);
                        }
                        else
                        {
                            MessageBox.Show("Salon " + o.Id + " u gradu: " + o.Grad + " " + o.Adresa + ", sef salona je " + o.SefSalona + " i stepen opremljenosti salona je: " + o.StepenOpremljenostiServisa);
                        }
                    }

                    foreach (Kupovina k in o.Kupovine)
                    {
                        MessageBox.Show("Salon: " + o.Id + " je " + k.DatumKupovine + " izvrsion kupovinu.");
                    }

                    foreach (UvezenoVozilo u in z)
                    {
                        if(u.GetType() == typeof(VoziloKojeNijeProdato))
                        {
                            VoziloKojeNijeProdato vknp = (VoziloKojeNijeProdato)u;
                            MessageBox.Show("Vozilo " + vknp.BrojSasije + " " + vknp.ModelVozila + " je izlozeno u salonu? " /*+ vknp.IzlozenUSalonu*/);
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
    }
}
