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
    }
}
