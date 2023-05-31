using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZadatakDA.Entiteti
{
    class Korisnici
    {
        public int KorisnikID { get; set; }
        public string KorisnickoIme { get; set; }
        public string Lozinka { get; set; }
        public int Uloga { get; set; }
        public bool Potvrda { get; set; }
    }
}
