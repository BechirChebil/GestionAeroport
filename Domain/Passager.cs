using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Passager
    {
        public int PassagerId { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public DateTime DateNaissance { get; set; }
        public List<Vol> Vols { get; set; }
        //public Passager(string n, string p)
        //{
        //    Nom = n;
        //    Prenom = p;
        //}
        public override string ToString()
        {
            return "Nom= " + Nom + " prenom= " + Prenom;
        }
        public virtual string AccesAvion()
        {
            return "veillez entrer par la porte des passagers";
        }
    }
}
