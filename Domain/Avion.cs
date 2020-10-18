using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public enum TypeAvion { AIRBUS, BOING}
    public class Avion
    {
        public int Reference { get; set; }
        public TypeAvion TypeAvion { get; set; }
        public List<Vol> Vols { get; set; }
    }
}
