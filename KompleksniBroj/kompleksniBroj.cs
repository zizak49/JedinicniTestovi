using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vsite.Oom
{
    public struct kompleksniBroj
    {
        public kompleksniBroj(double realni,double imaginarni){
            Realni = realni;
            Imaginarni = imaginarni;
        }
        static public kompleksniBroj operator +(kompleksniBroj br1, kompleksniBroj br2) {
            return new kompleksniBroj(br1.Realni + br2.Realni, br1.Imaginarni + br2.Imaginarni);
        }
        static public kompleksniBroj operator -(kompleksniBroj br1, kompleksniBroj br2)
        {
            return new kompleksniBroj(br1.Realni - br2.Realni, br1.Imaginarni - br2.Imaginarni);
        }

        public double Realni;
        public double Imaginarni;
    }
}
