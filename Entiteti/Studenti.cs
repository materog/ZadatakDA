using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZadatakDA.Entiteti
{
    class Studenti
    {
        public int StudentID { get; set; }
        public int KorisnikID { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public int TipStudija { get; set; }
    }
}
