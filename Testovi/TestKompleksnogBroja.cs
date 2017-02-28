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

        [TestMethod]
        public void ZbrojDvaKompleksnaBrojaJeKompleksniBrojSRealnimDijelomJednakimZbrojuRealnihDijelavaPribrojnika()
        {
            KompleksniBroj kb1 = new KompleksniBroj(1, 4);
            KompleksniBroj kb2 = new KompleksniBroj(7, 9);
            Assert.AreEqual(8, (kb1 + kb2).RealniDio);
        }
    }
}
