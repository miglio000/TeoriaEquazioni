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
            double a = 0;
            bool resp = Equazioni.IsDegree2(a);
            bool risultato_aspettato = false;
            Assert.AreEqual(risultato_aspettato, resp);
        }
        [TestMethod]
        public void IsDegree2_2()
        {
            double a = 1;
            bool resp = Equazioni.IsDegree2(a);
            bool risultato_aspettato = true;
            Assert.AreEqual(risultato_aspettato, resp);
        }
        [TestMethod]
        public void IsDegree2_3()
        {
            double a = 4;
            bool resp = Equazioni.IsDegree2(a);
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
        public void SoluzioniEquazione2Grade1()
        {
            double a = 1, b = 16, c = 64;
            string resp = Equazioni.SoluzioniEq2Grado(a, b, c);
            string risultato_aspettato = "x1= -8; x2= -8";
            Assert.AreEqual(risultato_aspettato, resp);
        }
        [TestMethod]
        public void SoluzioniEquazione2Grade2()
        {
            double a = 1, b = 7, c = -60;
            string resp = Equazioni.SoluzioniEq2Grado(a, b, c);
            string risultato_aspettato = "x1= 5; x2= -12";
            Assert.AreEqual(risultato_aspettato, resp);
        }
        [TestMethod]
        public void SoluzioniEquazione2Grade3()
        {
            double a = 2, b = 1, c = 5;
            string resp = Equazioni.SoluzioniEq2Grado(a, b, c);
            string risultato_aspettato = "impossibile";
            Assert.AreEqual(risultato_aspettato, resp);
        }
        [TestMethod]
        public void SoluzioniEquazione1Grade1()
        {
            double a = 0, b = 0;
            string resp = Equazioni.SoluzioneEq1Grado(a, b);
            string risultato_aspettato = "indeterminato";
            Assert.AreEqual(risultato_aspettato, resp);
        }
        [TestMethod]
        public void SoluzioniEquazione1Grade2()
        {
            double a = 1, b = 0;
            string resp = Equazioni.SoluzioneEq1Grado(a, b);
            string risultato_aspettato = "impossibile";
            Assert.AreEqual(risultato_aspettato, resp);
        }
        [TestMethod]
        public void SoluzioniEquazione1Grade3()
        {
            double a = 4, b = 5;
            string resp = Equazioni.SoluzioneEq1Grado(a, b);
            string risultato_aspettato = "x= 1.25";
            Assert.AreEqual(risultato_aspettato, resp);
        }
    }
}
