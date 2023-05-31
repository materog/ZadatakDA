using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZadatakDA.Entiteti
{
    class Teme
    {
        public int TemaID { get; set; }
        public int ProfesorID { get; set; }
        public int StudentID { get; set; }
        public bool Dostupnost { get; set; }
        public string NazivTeme { get; set; }
        public string KratkiOpis { get; set; }
        public int Studij { get; set; }
    }
}
