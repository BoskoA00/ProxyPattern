using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyPatternIS
{
    internal class terapijeServis : Interfejs
    {
        private List<Terapija> terapije = new List<Terapija>() { 
            new Terapija()
            {
                Id=1,
                ImePacijenta="Marko",
                PrezimePacijenta = "Markovic",
                Sadrazaj = "Vezbe"
            },
            new Terapija()
            {
                Id = 2,
                ImePacijenta="Stefan",
                PrezimePacijenta="Stefanovic",
                Sadrazaj = "Elektroterapija"
            },
            new Terapija()
            {
                Id = 3 ,
                ImePacijenta = "Janko",
                PrezimePacijenta = "Jankovic",
                Sadrazaj = "Istezanje"
            }
        };

        public void dodajTerapiju(Terapija terapija)
        {
            this.terapije.Add(terapija);
        }

        public void ispisTerapija()
        {
            foreach (Terapija terapija in this.terapije)
            {
                Console.WriteLine(terapija.Id + "-" + terapija.ImePacijenta + " " + terapija.PrezimePacijenta + ":" + terapija.Sadrazaj + Environment.NewLine);
            }
        }
        public void Login(string name, string password)
        {
            Console.WriteLine($"{name} je prijavljen u sistem" + Environment.NewLine);
        }
    }
}
