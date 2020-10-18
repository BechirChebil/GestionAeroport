using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Vip:Passager
    {
        public int Tarif { get; set; }
        public string Option { get; set; }
        //public Vip(string n, string p, int t):base(n,p)
        //{
        //         Tarif = t;
        //}
        public override string ToString()
        {
            return base.ToString() + "Tarif= " + Tarif;
        }
        public override string AccesAvion()
        {
            return "veillez entrer par la porte des VIP";
        }
    }
}
