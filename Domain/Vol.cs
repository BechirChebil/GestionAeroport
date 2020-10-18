using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Vol
    {
        public int VolId { get; set; }
        public string Destination { get; set; }
        public DateTime DateDepart { get; set; }
        public int Duree { get; set; }
        public List<Passager> Passagers { get; set; }
        public Avion Avion { get; set; }
    }
}
