using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CalcLibrary.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestRadQ()
        {
            double num = 36;
            double numeroaspettato = 6;
            double numerocalcolato = Calc.RadQ(num);
            Assert.AreEqual(numeroaspettato, numerocalcolato);

        }
        [TestMethod]
        public void TestVertice()
        {
            double a = 4;
            double b = 2;
            double valaspettato= -0.25;
            double numerocalcolato = Calc.Vertice(a, b);
            Assert.AreEqual(valaspettato, numerocalcolato);
        }
    }
}
