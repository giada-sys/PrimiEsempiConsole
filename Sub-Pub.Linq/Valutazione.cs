using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sub_Pub.Linq
{
    class Valutazione
    {
        public string NomeStudente { get; set; }
        public DateTime DataValutazione { get; set; }
        public int Voto { get; set; }
        public Materia Materia { get; set; }
    }
    enum Materia{
        Storia,
        Matematica,
        Geografia,
        Fisica,
        Italiano
    }
}
