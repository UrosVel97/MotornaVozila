using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MotornaVozila.Mapiranja
{
    public class NezavisniEkonomistaMapiranje : ClassMap<Entiteti.NezavisniEkonomista>
    {
        public NezavisniEkonomistaMapiranje()
        {
            //Mapiranje tabele
            Table("NEZAVISNI_EKONOMISTA");


            //Mapiranje primarnog kljuca
            Id(x => x.Jmbg, "JMBG").GeneratedBy.Assigned();

            //Mapiranje propertija
            Map(x => x.Ime, "IME");
            Map(x => x.Prezime, "PREZIME");
            Map(x => x.Adresa, "ADRESA");


            //Mapiranje veze M:N Salon : NezavisniEkonomista. Prvo cuvamo NezavisnogEkonomistu
            HasManyToMany(x => x.Saloni)
                        .Table("JE_ANGAZOVAO")
                        .ParentKeyColumn("FK_JMBG_NEZAVISNI_EKONOMISTA")
                        .ChildKeyColumn("FK_ID_SALONA")
                        .Cascade.All()
                        .Inverse();
        }
    }
}
