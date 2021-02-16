using Microsoft.VisualStudio.TestTools.UnitTesting;
using EquazioniLibrary;
namespace EquazioniLibrary.Test
{
    [TestClass]
    public class GestioneTest
    {
        [TestMethod]
        public void IsDeterminedTest1()
        {
            double a = 0;
            bool resp = Equazioni.IsDetermined(a);
            bool risultato_aspettato = false;
            Assert.AreEqual(risultato_aspettato, resp);
        }
        [TestMethod]
        public void IsDeterminedTest2()
        {
            double a = 1;
            bool resp = Equazioni.IsDetermined(a);
            bool risultato_aspettato = true;
            Assert.AreEqual(risultato_aspettato, resp);
        }
        [TestMethod]
        public void IsInconsisted1()
        {
            double a = 1, b = 1;
            bool resp = Equazioni.IsInconstisted(a, b);
            bool risultato_aspettato = true;
            Assert.AreEqual(risultato_aspettato, resp);
        }
        [TestMethod]
        public void IsInconsisted2()
        {
            double a = 1, b = 0;
            bool resp = Equazioni.IsInconstisted(a, b);
            bool risultato_aspettato = true;
            Assert.AreEqual(risultato_aspettato, resp);
        }
        [TestMethod]
        public void IsInconsisted3()
        {
            double a = 0, b = 1;
            bool resp = Equazioni.IsInconstisted(a, b);
            bool risultato_aspettato = false;
            Assert.AreEqual(risultato_aspettato, resp);
        }
        [TestMethod]
        public void IsDegree2_1()
        {
            double x = 1, esponente = 1;
            bool resp = Equazioni.IsDegree2(esponente, x);
            bool risultato_aspettato = false;
            Assert.AreEqual(risultato_aspettato, resp);
        }
        [TestMethod]
        public void IsDegree2_2()
        {
            double x = 1, esponente = 2;
            bool resp = Equazioni.IsDegree2(esponente, x);
            bool risultato_aspettato = true;
            Assert.AreEqual(risultato_aspettato, resp);
        }
        [TestMethod]
        public void Delta1()
        {
            double a = 1, b = 2, c = 1;
            double resp = Equazioni.Delta(a,b,c);
            double risultato_aspettato = 0;
            Assert.AreEqual(risultato_aspettato, resp);
        }
        [TestMethod]
        public void Delta2()
        {
            double a = 0, b = 1, c = 1;
            double resp = Equazioni.Delta(a, b, c);
            double risultato_aspettato = 1;
            Assert.AreEqual(risultato_aspettato, resp);
        }
        [TestMethod]
        public void Delta3()
        {
            double a = 3, b = 3, c = 4;
            double resp = Equazioni.Delta(a, b, c);
            double risultato_aspettato = -39;
            Assert.AreEqual(risultato_aspettato, resp);
        }
        [TestMethod]
        public void SoluzioniEquazione1()
        {
            double a = 1, b = 1, c = -1;
            string resp = Equazioni.SoluzioniEq2Grado(a, b, c);
            string risultato_aspettato = "x1= 0.6180339887498949; x2= -1.618033988749895";
            Assert.AreEqual(risultato_aspettato, resp);
        }
        [TestMethod]
        public void SoluzioniEquazione2()
        {
            double a = 2, b = 4, c = 2;
            string resp = Equazioni.SoluzioniEq2Grado(a, b, c);
            string risultato_aspettato = "x1= -1; x2= -1";
            Assert.AreEqual(risultato_aspettato, resp);
        }
        [TestMethod]
        public void SoluzioniEquazione3()
        {
            double a = 2, b = 1, c = 5;
            string resp = Equazioni.SoluzioniEq2Grado(a, b, c);
            string risultato_aspettato = "impossibile";
            Assert.AreEqual(risultato_aspettato, resp);
        }
    }
}
