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
        public void TestCalcoloMisterioso1_0()
        {
            int n = 1;
            long valore_aspettato = 2;
            long resp = Gestione.CalcoloMisterioso(n);
            Assert.AreEqual(valore_aspettato, resp);
        }
        [TestMethod]
        public void TestCalcoloMisterioso1_1()
        {
            int n = 0;
            long valore_aspettato = 1;
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
        public void TestCalcoloMisterioso2_0()
        {
            int n = 5;
            long valore_aspettato = -360;
            long resp = Gestione.CalcoloMisterioso2(n);
            Assert.AreEqual(valore_aspettato, resp);
        }
        [TestMethod]
        public void TestCalcoloMisterioso2_1()
        {
            int n = 0;
            long valore_aspettato = 0;
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
        public void TestMisurazioneMisteriosa1()
        {
            double[] valori = new double[5] { 5, 10, 21, 12, 25 };
            double valore_aspettato = 0;
            double resp = Gestione.MisurazioneMisteriosa(valori);
            Assert.AreEqual(valore_aspettato, resp);
        }
        public void TestMisurazioneMisteriosa2()
        {
            double[] valori = new double[6] { -4, 11, -9, 8, 16, -2 };
            double valore_aspettato = 5;
            double resp = Gestione.MisurazioneMisteriosa(valori);
            Assert.AreEqual(valore_aspettato, resp);
        }
    }
}
