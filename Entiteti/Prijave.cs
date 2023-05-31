using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZadatakDA.Entiteti
{
    class Prijave
    {
        public int PrijavaID { get; set; }
        public int TemaID { get; set; }
        public int StudentID { get; set; }
        public bool Prihvaceno { get; set; }
    }
}
