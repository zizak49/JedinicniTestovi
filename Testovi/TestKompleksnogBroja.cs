using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Vsite.Oom;

namespace Testovi
{
    [TestClass]
    public class TestKompleksnogBroja
    {
        [TestMethod]
        public void PozivKonstruktoraInicijaliziraRealniDioKompleksnogBroja()
        {
            KompleksniBroj kb = new KompleksniBroj(1, 4);
            Assert.AreEqual(1, kb.RealniDio);
        }

        [TestMethod]
        public void PozivKonstruktoraInicijaliziraImaginarniDioKompleksnogBroja()
        {
            KompleksniBroj kb = new KompleksniBroj(1, 4);
            Assert.AreEqual(4, kb.ImaginarniDio);
        }
    }
}
