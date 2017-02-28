using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vsite.Oom
{
    public struct KompleksniBroj
    {
        public KompleksniBroj(double realni, double imaginarni)
        {
            RealniDio = realni;
            ImaginarniDio = imaginarni;
        }

        public double RealniDio;
        public double ImaginarniDio;

        public static KompleksniBroj operator+(KompleksniBroj kb1, KompleksniBroj kb2)
        {
            return new KompleksniBroj(kb1.RealniDio + kb2.RealniDio, kb1.ImaginarniDio + kb2.ImaginarniDio);
        }
    }
}
