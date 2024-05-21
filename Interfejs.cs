using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyPatternIS
{
    public interface Interfejs
    {
        void Login(string username,string password);
        void dodajTerapiju(Terapija terapija);
        void ispisTerapija();
    }
}
