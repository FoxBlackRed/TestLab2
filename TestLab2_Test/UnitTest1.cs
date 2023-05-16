using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestLab2;

namespace TestLab2_Unit
{
    [TestClass]
    public class CalcusTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            //arrange
            int n1 = 3;
            int n2 = 4;
            int n3 = 5;
            int ex = 12;

            //act
            Num N = new Num(n1, n2, n3);
            int act = N.Summ();

            //assert
            Assert.AreEqual(ex, act);
        }
        [TestMethod]
        public void TestMethod2()
        {
            //arrange
            int n1 = 11;
            int n2 = 11;
            int n3 = 11;
            int ex = 33;

            //act
            Num N = new Num(n1, n2, n3);
            int act = N.Summ();

            //assert
            Assert.AreEqual(ex, act);
        }
        [TestMethod]
        public void TestMethod3()
        {
            //arrange
            int n1 = 256;
            int n2 = 144;
            int n3 = 624;
            int ex = 1024;

            //act
            Num N = new Num(n1, n2, n3);
            int act = N.Summ();

            //assert
            Assert.AreEqual(ex, act);
        }
        [TestMethod]
        public void TestMethod4()
        {
            //arrange
            int n1 = 3;
            int n2 = 3;
            int n3 = 3;
            int ex = 81;

            //act
            Num N = new Num(n1, n2, n3);
            double act = N.SummPow();

            //assert
            Assert.AreEqual(ex, act);
        }
        [TestMethod]
        public void TestMethod5()
        {
            //arrange
            int n1 = 4;
            int n2 = 4;
            int n3 = 4;
            int ex = 144;

            //act
            Num N = new Num(n1, n2, n3);
            double act = N.SummPow();

            //assert
            Assert.AreEqual(ex, act);
        }
        [TestMethod]
        public void TestMethod6()
        {
            //arrange
            int n1 = 1;
            int n2 = 2;
            int n3 = 3;
            int ex = 36;

            //act
            Num N = new Num(n1, n2, n3);
            double act = N.SummPow();

            //assert
            Assert.AreEqual(ex, act);
        }
        [TestMethod]
        public void TestMethod7()
        {
            //arrange
            int n1 = 3;
            int n2 = 3;
            int n3 = 3;
            double ex = 3;

            //act
            Num N = new Num(n1, n2, n3);
            double act = N.SummSqrt();

            //assert
            Assert.AreEqual(ex, act);
        }
        [TestMethod]
        public void TestMethod8()
        {
            //arrange
            int n1 = 3;
            int n2 = -2;
            int n3 = -1;
            double ex = 0;

            //act
            Num N = new Num(n1, n2, n3);
            double act = N.SummSqrt();

            //assert
            Assert.AreEqual(ex, act);
        }
        [TestMethod]
        public void TestMethod9()
        {
            //arrange
            int n1 = 3;
            int n2 = 3;
            int n3 = 3;
            double ex = 3;

            //act
            Num N = new Num(n1, n2, n3);
            double act = N.SummSqrt();

            //assert
            Assert.AreEqual(ex, act);
        }
        [TestMethod]
        public void TestMethod10()
        {
            //arrange
            int n1 = 2;
            int n2 = 3;
            int n3 = 6;
            string ex = "\nПервая: 2\nВторая: 3\nТретья: 6";

            //act
            Num N = new Num(n1, n2, n3);
            string act = N.ToString();

            //assert
            Assert.AreEqual(ex, act);
        }
        [TestMethod]
        public void TestMethod11()
        {
            //arrange
            int n1 = 12;
            int n2 = 13;
            int n3 = 11;
            string ex = "\nПервая: 12\nВторая: 13\nТретья: 11";

            //act
            Num N = new Num(n1, n2, n3);
            string act = N.ToString();

            //assert
            Assert.AreEqual(ex, act);
        }
        [TestMethod]
        public void TestMethod12()
        {
            //arrange
            int n1 = 0;
            int n2 = 0;
            int n3 = 0;
            string ex = "\nПервая: 0\nВторая: 0\nТретья: 0";

            //act
            Num N = new Num(n1, n2, n3);
            string act = N.ToString();

            //assert
            Assert.AreEqual(ex, act);
        }
    }
}
