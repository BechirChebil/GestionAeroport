using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gui
{
    class Program
    {
        static void Main(string[] args)
        {

            //Passager p1 = new Passager("chebil","bechir");
            Passager p1 = new Passager() { Nom = "saber", Prenom = "sarah", DateNaissance = DateTime.Now };
            Passager p2 = new Passager(){Nom="chebil",Prenom="bechir",DateNaissance=new DateTime(1993,11,25) };
            Passager p3 = new Passager() { Nom = "bouchaala", Prenom = "ayoub"};

            List<Passager> passagers = new List<Passager>() { p2, p3 };

            passagers.Add(p1);


            //for (int i = 0; i < passagers.Count; i++)
            //{
            //    Console.WriteLine(passagers.ElementAt(i));
            //}
            
             
            //Console.ReadKey();
            Vip v1 = new Vip() { Nom = "gaaloul", Prenom = "amine", DateNaissance = new DateTime(2000, 12, 12),Tarif=300 };
            Vip v2 = new Vip() { Nom = "makther", Prenom = "touhami", DateNaissance = new DateTime(2000, 12, 12),Tarif=100 };
            Vip v3 = new Vip() { Nom = "souhaib", Prenom = "sa7li", DateNaissance = new DateTime(2000, 12, 12), Tarif=10 };
            passagers.Add(v1);
            passagers.Add(v2);
            passagers.Add(v3);
            foreach (Passager p in passagers)
                Console.WriteLine(p.AccesAvion());

            Avion a1 = new Avion()
            {
                TypeAvion = TypeAvion.BOING,
                Vols = new List<Vol>()
            };
            Vol vv1 = new Vol() { DateDepart = new DateTime(2020, 11, 10), Destination = "paris", Duree = 120 };
            Vol vv2 = new Vol() { DateDepart = new DateTime(2018, 12, 10), Destination = "paris", Duree = 120 };

            Vol vv3 = new Vol() { DateDepart = new DateTime(2022, 12, 10), Destination = "madrid", Duree = 200 };
            List<Vol> vols = new List<Vol>() { vv1, vv2, vv3 };
            a1.Vols.AddRange(vols);
            vv1.Avion = a1;
            vv2.Avion = a1;
            vv3.Avion = a1;
            
            // retourner la liste des vols vers paris
            IEnumerable<DateTime> volParis = from v in vols
                                        where v.Destination == "paris"
                                        select v.DateDepart;

            var volParisLambda = vols.Where(v => v.Destination.Equals("paris"))
                                            .Select(v => v.DateDepart);



            foreach (DateTime d in volParis)
                Console.WriteLine(d);


            //Console.WriteLine("duree: "+v.Duree+"destination: "+v.Destination+ "date" + v.DateDepart);

            // retourner les dates et les duree de vols vers paris

            var volParis2= from v in vols
                           where v.Destination == "paris"
                           select new {v.Duree,v.DateDepart } ;


            var volParis2lambda= vols.Where(v => v.Destination.Equals("paris"))
                                            .Select(v => new { v.Duree, v.DateDepart });


            foreach (var v in volParis2)
                
            Console.WriteLine(v);


            // liste des passagers ordonnes par age
            var lp = from p in passagers
                     orderby p.DateNaissance descending
                     select p;


            var lpLambda = passagers.OrderBy(p => p.DateNaissance);
                                            

            // retourner les vols groupees par destination
            var groupVol = from v in vols
                           group v by v.Destination;

            foreach (var g in groupVol)
            {
                Console.WriteLine(g.Key);
                foreach(Vol v in g)
                    Console.WriteLine(v.DateDepart);
            }

            var groupVolLambda = vols.GroupBy(p => p.Destination);

            // retourner les deux Vols avec la plus grand duree
            List<Vol> volLong = (from v in vols
                           orderby v.Duree descending
                           select v).Take ( 2 ).ToList();

            var volLongLambda = vols.OrderByDescending(p => p.Duree).Take(2);

            //retourner la Destination des vols <360 jours
            var vol360 = from v in vols
                         where (DateTime.Now - v.DateDepart).TotalDays < 360
                         select v;


            var vol360Lambda = vols.Where(v=> (DateTime.Now - v.DateDepart).TotalDays < 360);


            // retourner les passagers de type VIP:
            var passVip = (from p in passagers
                           select p).OfType<Vip>();

            var passVipLamda = passagers.OfType<Vip>();
            ///////
            Console.ReadKey();

        }
    }
}
