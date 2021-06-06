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

                    else if (o.GetType() == typeof(VoziloKojeNijeProdato))
                    {
                        VoziloKojeNijeProdato vnp = (VoziloKojeNijeProdato)o;
                        MessageBox.Show("Vozilo koje nije prodato ima broj sasije " + vnp.BrojSasije + ", model vozila je: " + vnp.ModelVozila + ". Vozilo je izlozeno u salonu sa id-jem: " + vnp.IzlozenUSalonu.Id + ", Salon se nalazi u gradu: " + vnp.IzlozenUSalonu.Grad);
                        if (vnp.FPutnickoVozilo.Equals("Y") && vnp.FTeretnoVozilo.Equals("Y"))
                        {
                            MessageBox.Show("Vozilo koje nije prodato ima broj sasije " + vnp.BrojSasije + ", vozilo je i putnicko i teretno vozilo. Broj putnika: " + vnp.BrojPutnika + ", Nosivost: " + vnp.Nosivost + ", Tip prostora: " + vnp.TipProstora);

                        }
                        else if (vnp.FPutnickoVozilo.Equals("Y") && vnp.FTeretnoVozilo.Equals("N"))
                        {
                            MessageBox.Show("Vozilo koje nije prodato ima broj sasije " + vnp.BrojSasije + ", vozilo je putnicko. Broj putnika: " + vnp.BrojPutnika);
                        }
                        else
                        {
                            MessageBox.Show("Vozilo koje nije prodato ima broj sasije " + vnp.BrojSasije + ", vozilo je teretno. Nosivost: " + vnp.Nosivost + ", Tip prostora: " + vnp.TipProstora);
                        }

                        foreach (Boja b in vnp.Boje)
                        {
                            MessageBox.Show("Vozilo koje nije prodato ima broj sasije " + vnp.BrojSasije + " je boje " + b.BojaVozila);
                        }

                        if (vnp.Boje.Count == 0)
                        {
                            MessageBox.Show("Vozilo koje nije prodato ima broj sasije " + vnp.BrojSasije + " nema boju");
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
                        MessageBox.Show("Salon: " + o.Id + " je datuma: " + k.DatumKupovine + " izvrsio kupovinu.");
                    }

                    foreach (VoziloKojeNijeProdato vknp in o.VozilaKojaNisuProdata)
                    {


                        MessageBox.Show("Vozilo " + vknp.BrojSasije + " " + vknp.ModelVozila + " je izlozeno u salonu: " + o.Grad);

                    }
                }

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.ToString());
            }
        }


        private void btnModifikujKupovinu_Click(object sender, EventArgs e)
        {
            ModifikujKupovinu forma = new ModifikujKupovinu();
            this.Visible = false;
            forma.ShowDialog();
            this.Visible = true;
        }

        private void btnVratiKupovine_Click_1(object sender, EventArgs e)
        {
            try
            {

                ISession i = DataLayer.GetSession();

                IList<Kupovina> z = i.QueryOver<Kupovina>()
                                 .List<Kupovina>();

                foreach (Kupovina o in z)
                {
                    MessageBox.Show("Kupac " + o.IdKupca.LicnoIme + " " + o.IdKupca.Prezime + " je datuma " + o.DatumKupovine + " izvrsio kupovinu");

                    MessageBox.Show("Salon " + o.IdSalona.Id + ", stepen opremljenosti salona: " + o.IdSalona.StepenOpremljenostiServisa + ", u gradu: " + o.IdSalona.Grad + " " + o.IdSalona.Adresa + " je datuma " + o.DatumKupovine + " izvrsio prodaju vozila");

                    foreach (VoziloKojeJeProdato vk in o.ProdataVozila)
                    {
                        MessageBox.Show("Vozilo " + vk.BrojSasije + " " + vk.ModelVozila + ", kubikaza: " + vk.Kubikaza + ", je kupljeno datuma " + o.DatumKupovine);
                    }


                }

                i.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.ToString());
            }
        }

        private void s_Click(object sender, EventArgs e)
        {
            DodajKupovinu forma = new DodajKupovinu();
            this.Visible = false;
            forma.ShowDialog();
            this.Visible = true;
        }

        private void btnIzbrisiKupovinu_Click(object sender, EventArgs e)
        {
            ObrisiKupovinu forma = new ObrisiKupovinu();
            this.Visible = false;
            forma.ShowDialog();
            this.Visible = true;
        }

        private void btnDodajKupca_Click(object sender, EventArgs e)
        {
            DodajKupca forma = new DodajKupca();
            this.Visible = false;
            forma.ShowDialog();
            this.Visible = true;
        }

        private void btnVratiKupce_Click_1(object sender, EventArgs e)
        {
            try
            {

                ISession i = DataLayer.GetSession();

                IList<Kupac> k = i.QueryOver<Kupac>()
                                 .List<Kupac>();

                foreach (Kupac o in k)
                {
                    if (o.GetType() == typeof(PravnoLice))
                    {
                        PravnoLice pl = (PravnoLice)o;
                        MessageBox.Show("Kupac " + o.LicnoIme + " " + o.Prezime + " je pravno lice, Jmbg: " + pl.Pib);
                    }
                    else
                    {
                        FizickoLice fl = (FizickoLice)o;
                        MessageBox.Show("Kupac " + o.LicnoIme + " " + o.Prezime + " je fizicko lice, PiB: " + fl.Jmbg);
                    }
                    foreach (Kupovina ku in o.Kupovine)
                    {
                        MessageBox.Show("Kupac " + o.LicnoIme + " " + o.Prezime + " je izvrsio kupovinu datuma: " + ku.DatumKupovine);
                    }
                    foreach (RegistrovaniKupac rk in o.RegistrovaniKupci)
                    {
                        MessageBox.Show(o.LicnoIme + " " + o.Prezime + " je registrovani kupac");
                    }
                }

                i.Close();
            }

            catch (Exception ec)
            {
                MessageBox.Show(ec.ToString());
            }
        }

        private void btnModifikujKupca_Click(object sender, EventArgs e)
        {
            ModifikujKupca forma = new ModifikujKupca();
            this.Visible = false;
            forma.ShowDialog();
            this.Visible = true;

        }

        private void btnVratiVlasnike_Click(object sender, EventArgs e)
        {
            try
            {

                ISession i = DataLayer.GetSession();

                IList<Vlasnik> v = i.QueryOver<Vlasnik>()
                                 .List<Vlasnik>();

                foreach (Vlasnik o in v)
                {
                    if (o.GetType() == typeof(NeregistrovaniKupac))
                    {
                        NeregistrovaniKupac nk = (NeregistrovaniKupac)o;

                        foreach (TelefonNeregistrovaniKupac tnk in nk.Telefoni)
                        {
                            MessageBox.Show("Vlasnik " + o.Id + " " + nk.Ime + " " + nk.Prezime + " je neregistrovani kupac, kontakt telefon:" + tnk.BrojTelefona);
                        }
                    }
                    else
                    {
                        RegistrovaniKupac rk = (RegistrovaniKupac)o;
                        MessageBox.Show("Vlasnik " + o.Id + " " + rk.Kupac.LicnoIme + " " + rk.Kupac.Prezime + " je registrovani kupac");
                    }
                    foreach (VozilaPrimljenaNaServis vp in o.JePoslaoVoziloNaServis)
                    {
                        MessageBox.Show("Vlasnik " + o.Id + " je datuma: " + vp.DatumPrijema + " poslao vozilo registarskog broja: " + vp.RegistarskiBroj + " " + vp.ModelVozila + " na servis zbog problema: " + vp.OpisProblema);
                    }
                }

                i.Close();
            }

            catch (Exception ec)
            {
                MessageBox.Show(ec.ToString());
            }
        }

        private void btnModifikujVlasnika_Click(object sender, EventArgs e)
        {
            ModifikujNeregistrovanogKupca forma = new ModifikujNeregistrovanogKupca();
            this.Visible = false;
            forma.ShowDialog();
            this.Visible = true;
        }

        private void btnVratiVozilaPrimljenaNaServis_Click(object sender, EventArgs e)
        {
            try
            {

                ISession i = DataLayer.GetSession();

                IList<VozilaPrimljenaNaServis> v = i.QueryOver<VozilaPrimljenaNaServis>()
                                 .List<VozilaPrimljenaNaServis>();

                IList<Vlasnik> vl = i.QueryOver<Vlasnik>()
                                 .List<Vlasnik>();

                foreach (VozilaPrimljenaNaServis vozila in v)
                {
                    MessageBox.Show("Vozilo registarskog broja: " + vozila.RegistarskiBroj + " " + vozila.ModelVozila + " je datuma: " + vozila.DatumPrijema + " primljen na servis zbog: " + vozila.OpisProblema);
                    MessageBox.Show("Vozilo " + vozila.RegistarskiBroj + " je primio " + vozila.Zaposleni.Ime + " " + vozila.Zaposleni.Prezime + ", strucna sprema: " + vozila.Zaposleni.StrucnaSprema + ", godine radnog staza: " + vozila.Zaposleni.GodineRadnogStaza);

                    //foreach (Vlasnik vlasnik in vl)
                    //{
                    //    if (vlasnik.GetType() == typeof(NeregistrovaniKupac))
                    //    {
                    //        NeregistrovaniKupac nk = (NeregistrovaniKupac)vlasnik;

                    //        MessageBox.Show("Vlasnik vozila " + vozila.RegistarskiBroj + " " + vozila.ModelVozila + " iz " + vozila.GodinaProizvodnje + " je " + nk.Ime + " " + nk.Prezime);
                    //    }
                    //    else
                    //    {
                    //        RegistrovaniKupac rk = (RegistrovaniKupac)vlasnik;

                    //        MessageBox.Show("Vlasnik vozila " + vozila.RegistarskiBroj + " " + vozila.ModelVozila + " iz " + vozila.GodinaProizvodnje + " je " + rk.Kupac.LicnoIme + " " + rk.Kupac.Prezime);
                    //    }
                    //}
                    MessageBox.Show("Vlasnik vozila " + vozila.RegistarskiBroj + " je " + vozila.Vlasnik.Id);
                }


                i.Close();
            }

            catch (Exception ec)
            {
                MessageBox.Show(ec.ToString());
            }
        }

        private void btnModifikujVoziloPrimljenoNaServis_Click(object sender, EventArgs e)
        {
            ModifikujVozilaPrimljenaNaServis forma = new ModifikujVozilaPrimljenaNaServis();
            this.Visible = false;
            forma.ShowDialog();
            this.Visible = true;
        }
    }
}
