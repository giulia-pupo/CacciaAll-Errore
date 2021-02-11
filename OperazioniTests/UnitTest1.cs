using Microsoft.VisualStudio.TestTools.UnitTesting;
using Operazioni;

namespace OperazioniTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestCalcoloMisterioso()
        {
            int n = 5;
            long valore_aspettato = 240;
            long resp = Gestione.CalcoloMisterioso(n);
            Assert.AreEqual(valore_aspettato, resp);
        }
        [TestMethod]
        public void TestCalcoloMisterioso2()
        {
            int n = 3;
            long valore_aspettato = -18;
            long resp = Gestione.CalcoloMisterioso2(n);
            Assert.AreEqual(valore_aspettato, resp);
        }

        [TestMethod]
        public void TestMisurazioneMisteriosa()
        {
            double[] valori = new double[4] { 4, 6, 7, -9.1 };
            double valore_aspettato = 3;
            double resp = Gestione.MisurazioneMisteriosa(valori);
            Assert.AreEqual(valore_aspettato, resp);
        }
    }
}
