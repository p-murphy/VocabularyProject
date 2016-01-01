using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace November16th
{
    public class Appointment
    {
        public Collection C { get; set; }
        public DateTime DatTim {get; set; }
        public ReviewStatus RevStat { get; set; }

        public Appointment(Collection c, DateTime datTim, ReviewStatus revStat)
        {
            C = c;
            DatTim = datTim;
            RevStat = revStat;
        }
    }
}
