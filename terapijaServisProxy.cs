using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyPatternIS
{
    internal class terapijaServisProxy : Interfejs
    {
        private terapijeServis servis;
        private string _role;

        public terapijaServisProxy(terapijeServis ts, string role)
        {
            this.servis = ts;
            this._role = role;
        }

        public void dodajTerapiju(Terapija terapija)
        {
            if (Autorizacija(this._role))
            {
                this.servis.dodajTerapiju(terapija);
            }
            else
            {
                Console.WriteLine("Nemate dozvolu da dodajete terapije" + Environment.NewLine);
            }
        }

        public void ispisTerapija()
        {
            if (Autorizacija(_role))
            {
                this.servis.ispisTerapija();
            }
            else
            {
                Console.WriteLine("Nemate prava da vidite sve terapije" + Environment.NewLine);
            }
        }

        public void Login(string username, string role)
        {
            if(proveraPrijave(username, role))
            {
                this.servis.Login(username, role);
            }
            else
            {
                Console.WriteLine("Neispravni podaci" + Environment.NewLine);
            }
        }
        private bool Autorizacija(string role) {

            return role == "doktor" || role == "administrator";
        }
        private bool proveraPrijave(string name, string password)
        {
            return name == "Doktor1" && password == "123123";
        }
    }
}
