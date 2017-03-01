using Microsoft.VisualStudio.TestTools.UnitTesting;
using Vsite.Oom;

namespace Testovi
{
    /// <summary>
    /// Summary description for testKompleksnogBroja
    /// </summary>
    [TestClass]
    public class testKompleksnogBroja
    {
        

        [TestMethod]
        public void PozivKonstruktoraKompleksnogBrojaKaoRealniDioPostavljenog()
        {
            kompleksniBroj kb = new kompleksniBroj(4, 7);
            Assert.AreEqual(4, kb.Realni);
        }
        [TestMethod]
        public void PozivKonstruktoraKompleksnogBrojaKaoImagniarniDioPostavljenog()
        {
            kompleksniBroj kb = new kompleksniBroj(4, 7);
            Assert.AreEqual(7, kb.Imaginarni);
        }
        [TestMethod]
        public void Zbroj2KomleksnaBrojaRealniIO()
        {
            kompleksniBroj kb1 = new kompleksniBroj(4, 7);
            kompleksniBroj kb2 = new kompleksniBroj(7, 9);

            Assert.AreEqual(11, (kb1+kb2).Realni);
        }
        [TestMethod]
        public void Zbroj2KomleksnaBrojaImaginarniDio()
        {
            kompleksniBroj kb1 = new kompleksniBroj(4, 7);
            kompleksniBroj kb2 = new kompleksniBroj(7, 9);

            Assert.AreEqual(16, (kb1+kb2).Imaginarni);
        }


    }
}
