using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dhamo.zavatta._4H.Tris2
{
    class Giocatore
    {
        string giocatore1;
        string giocatore2;

        public Giocatore()
        {
            giocatore1 = "";
            giocatore2 = "";
        }

        public Giocatore(string g1, string g2)
        {
            giocatore1 = g1;
            giocatore2 = g2;
        }

        public string stpG1()
        {
            return giocatore1;
        }

        public string stpG2()
        {
            return giocatore2;
        }
    }
}
