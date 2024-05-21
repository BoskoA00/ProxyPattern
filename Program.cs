using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyPatternIS
{
    internal class Program
    {

        static void Main(string[] args)
        {
            terapijeServis terapijaServis = new terapijeServis();
            Interfejs proxy = new terapijaServisProxy(terapijaServis, "doktor");

            proxy.Login("Doktor1", "123123");
            proxy.dodajTerapiju(new Terapija() { Id = 4, ImePacijenta = "Pero", PrezimePacijenta = "Peric", Sadrazaj = "Mazanje kremom" });
            proxy.ispisTerapija();

            Interfejs losProxy = new terapijaServisProxy(terapijaServis, "pacijent");
            losProxy.dodajTerapiju(new Terapija() { Id = 4, ImePacijenta = "Pero", PrezimePacijenta = "Peric", Sadrazaj = "Mazanje kremom" });
            Console.ReadLine();
        }
    }
}
