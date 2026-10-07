using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lift
{
    internal class Hasznalat
    {
        public DateTime datum;
        public int kartyaSzam;  
        public int induloEmelet;
        public int celEmelet;

        public Hasznalat(DateTime datum, int kartyaSzam, int induloEmelet, int celEmelet)
        {
            this.datum = datum;
            this.kartyaSzam = kartyaSzam;
            this.induloEmelet = induloEmelet;
            this.celEmelet = celEmelet;
        }
    }
}
