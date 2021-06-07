using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MotornaVozila
{
    public class DTOs
    {
        public class SalonZaBrisanje
        {
            public int Id { get; set; }
            public string Grad { get; set; }

            public string Adresa{ get; set;}
            
            public SalonZaBrisanje(int id, string grad, string adresa)
            {
                Id = id;
                Grad = grad;
                Adresa = adresa;
            }
        }

        public class SalonZaModifikovanje
        {
            public int Id { get; set; }

            public string Grad { get; set; }

            public string Adresa { get; set; }

            public string SefSalona { get; set; }

            public string SefServisa { get; set; }

            public SalonZaModifikovanje(int id, string grad, string adresa, string sefSalona, string sefServisa)
            {
                Id = id;
                Grad = grad;
                Adresa = adresa;
                SefSalona = sefSalona;
                SefServisa = sefServisa;
            }
        }

        public class KupacInfo
        {
            public int Id { get; set; }
            public string Ime { get; set; }
            public string Prezime { get; set; }
            public KupacInfo(int id,string ime,string prezime)
            {
                this.Id = id;
                this.Ime = ime;
                this.Prezime = prezime;
            }
        }

        public class KupovinaInfo
        {
            public int Id { get; set; }
            public DateTime Datum { get; set; }
            public KupovinaInfo(int id, DateTime datum)
            {
                this.Id = id;
                this.Datum = datum;
                
            }
        }

        public class PravnoLiceInfo
        {
            public int Id { get; set; }
            public string Ime { get; set; }
            public string Prezime { get; set; }
            public int Pib { get; set; }
            public PravnoLiceInfo(int id, string ime, string prezime,int pib)
            {
                this.Id = id;
                this.Ime = ime;
                this.Prezime = prezime;
                this.Pib = pib;
            }
        }


        public class FizickoLiceInfo
        {
            public int Id { get; set; }
            public string Ime { get; set; }
            public string Prezime { get; set; }
            public int Jmbg { get; set; }
            public FizickoLiceInfo(int id, string ime, string prezime, int jmbg)
            {
                this.Id = id;
                this.Ime = ime;
                this.Prezime = prezime;
                this.Jmbg = jmbg;
            }
        }

        public class VlasnikInfo
        {
            public int Id { get; set; }
            public string Ime { get; set; }
            public string Prezime { get; set; }

            public VlasnikInfo(int id, string ime, string prezime)
            {
                this.Id = id;
                this.Ime = ime;
                this.Prezime = prezime;
            }
        }


        public class ZaposleniInfo
        {
            public int Jmbg { get; set; }
            public string Ime { get; set; }
            public string Prezime { get; set; }

            public ZaposleniInfo(int jmbg, string ime, string prezime)
            {
                this.Jmbg = jmbg;
                this.Ime = ime;
                this.Prezime = prezime;
            }
        }

    }
}
