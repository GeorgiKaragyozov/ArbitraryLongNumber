using System;
using ArbitraryLongNumber;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test_Project
{
    [TestClass]
    public class Division
    {
        [TestMethod]
        public void DivisionTest1()
        {
            ArbitraryLong x = new ArbitraryLong("5255");
            ArbitraryLong y = new ArbitraryLong("5");

            Assert.AreEqual(ArbitraryLong.Division(x, y).ToString(), "1051");
        }

        [TestMethod]
        public void DivisionTest2()
        {
            string x = "5255";
            string y = "5";

            ArbitraryLong arbitraryLongX = ArbitraryLong.Parse(x);
            ArbitraryLong arbitraryLongY = ArbitraryLong.Parse(y);

            Assert.AreEqual(ArbitraryLong.Division(arbitraryLongX, arbitraryLongY).ToString(), "1051");
        }       

        [TestMethod]
        public void DivisionTest3()
        {
            ArbitraryLong x = new ArbitraryLong("525");
            ArbitraryLong y = new ArbitraryLong("5");

            Assert.AreEqual(ArbitraryLong.Division(x, y).ToString(), "105");
        }

        [TestMethod]
        public void DivisionTest4()
        {
            string x = "525";
            string y = "5";

            ArbitraryLong arbitraryLongX = ArbitraryLong.Parse(x);
            ArbitraryLong arbitraryLongY = ArbitraryLong.Parse(y);

            Assert.AreEqual(ArbitraryLong.Division(arbitraryLongX, arbitraryLongY).ToString(), "105");
        }

        [TestMethod]
        public void DivisionTest5()
        {
            ArbitraryLong x = new ArbitraryLong("222");
            ArbitraryLong y = new ArbitraryLong("2");

            Assert.AreEqual(ArbitraryLong.Division(x, y).ToString(), "111");
        }

        [TestMethod]
        public void DivisionTest6()
        {
            string x = "222";
            string y = "2";

            ArbitraryLong arbitraryLongX = ArbitraryLong.Parse(x);
            ArbitraryLong arbitraryLongY = ArbitraryLong.Parse(y);

            Assert.AreEqual(ArbitraryLong.Division(arbitraryLongX, arbitraryLongY).ToString(), "111");
        }

        [TestMethod]
        public void DivisionTest7()
        {
            ArbitraryLong x = new ArbitraryLong("0000");
            ArbitraryLong y = new ArbitraryLong("0000000");

            Assert.AreEqual(ArbitraryLong.Division(x, y).ToString(), "0");
        }

        [TestMethod]
        public void DivisionTest8()
        {
            string x = "0000";
            string y = "0000000";

            ArbitraryLong arbitraryLongX = ArbitraryLong.Parse(x);
            ArbitraryLong arbitraryLongY = ArbitraryLong.Parse(y);

            Assert.AreEqual(ArbitraryLong.Division(arbitraryLongX, arbitraryLongY).ToString(), "0");
        }

        [TestMethod]
        public void DivisionTest9()
        {
            ArbitraryLong x = new ArbitraryLong("0");
            ArbitraryLong y = new ArbitraryLong("8888");

            Assert.AreEqual(ArbitraryLong.Division(x, y).ToString(), "0");
        }

        [TestMethod]
        public void DivisionTest10()
        {
            string x = "0";
            string y = "8888";

            ArbitraryLong arbitraryLongX = ArbitraryLong.Parse(x);
            ArbitraryLong arbitraryLongY = ArbitraryLong.Parse(y);

            Assert.AreEqual(ArbitraryLong.Division(arbitraryLongX, arbitraryLongY).ToString(), "0");
        }

        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException))]
        public void DivisionTest11()
        {
            ArbitraryLong x = new ArbitraryLong("555");
            ArbitraryLong y = new ArbitraryLong("0");

            ArbitraryLong.Division(x, y);
        }

        [TestMethod]
        public void DivisionTest12()
        {
            ArbitraryLong x = new ArbitraryLong("56952");
            ArbitraryLong y = new ArbitraryLong("123");

            Assert.AreEqual(ArbitraryLong.Division(x, y).ToString(), "463");
        }

        [TestMethod]
        public void DivisionTest13()
        {
            string x = "56952";
            string y = "123";

            ArbitraryLong arbitraryLongX = ArbitraryLong.Parse(x);
            ArbitraryLong arbitraryLongY = ArbitraryLong.Parse(y);

            Assert.AreEqual(ArbitraryLong.Division(arbitraryLongX, arbitraryLongY).ToString(), "463");
        }

        [TestMethod]
        public void DivisionTest14()
        {
            ArbitraryLong x = new ArbitraryLong("9266132968316831626132968");
            ArbitraryLong y = new ArbitraryLong("41241244121421");

            Assert.AreEqual(ArbitraryLong.Division(x, y).ToString(), "224681218176");
        }

        [TestMethod]
        public void DivisionTest15()
        {
            string x = "9266132968316831626132968";
            string y = "41241244121421";

            ArbitraryLong arbitraryLongX = ArbitraryLong.Parse(x);
            ArbitraryLong arbitraryLongY = ArbitraryLong.Parse(y);

            Assert.AreEqual(ArbitraryLong.Division(arbitraryLongX, arbitraryLongY).ToString(), "224681218176");
        }

        [TestMethod]
        public void DivisionTest16()
        {
            ArbitraryLong x = new ArbitraryLong("421421421412421634");
            ArbitraryLong y = new ArbitraryLong("5569274");

            Assert.AreEqual(ArbitraryLong.Division(x, y).ToString(), "75669004867");
        }

        [TestMethod]
        public void DivisionTest17()
        {
            string x = "421421421412421634";
            string y = "5569274";

            ArbitraryLong arbitraryLongX = ArbitraryLong.Parse(x);
            ArbitraryLong arbitraryLongY = ArbitraryLong.Parse(y);

            Assert.AreEqual(ArbitraryLong.Division(arbitraryLongX, arbitraryLongY).ToString(), "75669004867");
        }

        [TestMethod]
        public void DivisionTest18()
        {
            ArbitraryLong x = new ArbitraryLong("9831636261326822398329821368328");
            ArbitraryLong y = new ArbitraryLong("87328737253275132573");

            Assert.AreEqual(ArbitraryLong.Division(x, y).ToString(), "112581912558");
        }

        [TestMethod]
        public void DivisionTest19()
        {
            string x = "9831636261326822398329821368328";
            string y = "87328737253275132573";

            ArbitraryLong arbitraryLongX = ArbitraryLong.Parse(x);
            ArbitraryLong arbitraryLongY = ArbitraryLong.Parse(y);

            Assert.AreEqual(ArbitraryLong.Division(arbitraryLongX, arbitraryLongY).ToString(), "112581912558");
        }

        [TestMethod]
        public void DivisionTest20()
        {
            ArbitraryLong x = new ArbitraryLong("213123123215257735534");
            ArbitraryLong y = new ArbitraryLong("846842684686846828643683468348");

            Assert.AreEqual(ArbitraryLong.Division(x, y).ToString(), "0");
        }

        [TestMethod]
        public void DivisionTest21()
        {
            string x = "213123123215257735534";
            string y = "846842684686846828643683468348";

            ArbitraryLong arbitraryLongX = ArbitraryLong.Parse(x);
            ArbitraryLong arbitraryLongY = ArbitraryLong.Parse(y);

            Assert.AreEqual(ArbitraryLong.Division(arbitraryLongX, arbitraryLongY).ToString(), "0");
        }

        [TestMethod]
        public void DivisionTest22()
        {
            ArbitraryLong x = new ArbitraryLong("-873183828929861326813686");
            ArbitraryLong y = new ArbitraryLong("85732812968139838");

            Assert.AreEqual(ArbitraryLong.Division(x, y).ToString(), "-10184943");
        }

        [TestMethod]
        public void DivisionTest23()
        {
            string x = "-873183828929861326813686";
            string y = "85732812968139838";

            ArbitraryLong arbitraryLongX = ArbitraryLong.Parse(x);
            ArbitraryLong arbitraryLongY = ArbitraryLong.Parse(y);

            Assert.AreEqual(ArbitraryLong.Division(arbitraryLongX, arbitraryLongY).ToString(), "-10184943");
        }

        [TestMethod]
        public void DivisionTest24()
        {
            ArbitraryLong x = new ArbitraryLong("559861369836298312312412");
            ArbitraryLong y = new ArbitraryLong("-9841418984189");

            Assert.AreEqual(ArbitraryLong.Division(x, y).ToString(), "-56888277060");
        }

        [TestMethod]
        public void DivisionTest25()
        {
            string x = "559861369836298312312412";
            string y = "-9841418984189";

            ArbitraryLong arbitraryLongX = ArbitraryLong.Parse(x);
            ArbitraryLong arbitraryLongY = ArbitraryLong.Parse(y);

            Assert.AreEqual(ArbitraryLong.Division(arbitraryLongX, arbitraryLongY).ToString(), "-56888277060");
        }

        [TestMethod]
        public void DivisionTest26()
        {
            ArbitraryLong x = new ArbitraryLong("-8636298269832141412634");
            ArbitraryLong y = new ArbitraryLong("-981412684218");

            Assert.AreEqual(ArbitraryLong.Division(x, y).ToString(), "8799864123");
        }

        [TestMethod]
        public void DivisionTest27()
        {
            string x = "-8636298269832141412634";
            string y = "-981412684218";

            ArbitraryLong arbitraryLongX = ArbitraryLong.Parse(x);
            ArbitraryLong arbitraryLongY = ArbitraryLong.Parse(y);

            Assert.AreEqual(ArbitraryLong.Division(arbitraryLongX, arbitraryLongY).ToString(), "8799864123");
        }

        [TestMethod]
        public void DivisionTest28()
        {
            ArbitraryLong x = new ArbitraryLong("98128291794217974710709417094791");
            ArbitraryLong y = new ArbitraryLong("968468989");

            Assert.AreEqual(ArbitraryLong.Division(x, y).ToString(), "101323111951721951017173");
        }

        [TestMethod]
        public void DivisionTest29()
        {
            string x = "98128291794217974710709417094791";
            string y = "968468989";

            ArbitraryLong arbitraryLongX = ArbitraryLong.Parse(x);
            ArbitraryLong arbitraryLongY = ArbitraryLong.Parse(y);

            Assert.AreEqual(ArbitraryLong.Division(arbitraryLongX, arbitraryLongY).ToString(), "101323111951721951017173");
        }

        [TestMethod]
        public void DivisionTest30()
        {
            ArbitraryLong x = new ArbitraryLong("9683168969316836861836868128386213682183907790479127947910929494127909942197479742974107717797412");
            ArbitraryLong y = new ArbitraryLong("9731279302090927379217903297737");

            Assert.AreEqual(ArbitraryLong.Division(x, y).ToString(), "995056114280498226849741687238393226119977530968706309466930586427");
        }

        [TestMethod]
        public void DivisionTest31()
        {
            string x = "9683168969316836861836868128386213682183907790479127947910929494127909942197479742974107717797412";
            string y = "9731279302090927379217903297737";

            ArbitraryLong arbitraryLongX = ArbitraryLong.Parse(x);
            ArbitraryLong arbitraryLongY = ArbitraryLong.Parse(y);

            Assert.AreEqual(ArbitraryLong.Division(arbitraryLongX, arbitraryLongY).ToString(), "995056114280498226849741687238393226119977530968706309466930586427");
        }

        [TestMethod]
        public void DivisionTest32()
        {
            ArbitraryLong x = new ArbitraryLong("9863168382698328832893126836");
            ArbitraryLong y = new ArbitraryLong("86361683812498614681642684681428682486612684682148");

            Assert.AreEqual(ArbitraryLong.Division(x, y).ToString(), "0");
        }

        [TestMethod]
        public void DivisionTest33()
        {
            string x = "9863168382698328832893126836";
            string y = "86361683812498614681642684681428682486612684682148";

            ArbitraryLong arbitraryLongX = ArbitraryLong.Parse(x);
            ArbitraryLong arbitraryLongY = ArbitraryLong.Parse(y);

            Assert.AreEqual(ArbitraryLong.Division(arbitraryLongX, arbitraryLongY).ToString(), "0");
        }

        [TestMethod]
        public void DivisionTest34()
        {
            ArbitraryLong x = new ArbitraryLong("5255");
            ArbitraryLong y = new ArbitraryLong("-5");

            Assert.AreEqual(ArbitraryLong.Division(x, y).ToString(), "-1051");
        }

        [TestMethod]
        public void DivisionTest35()
        {
            string x = "5255";
            string y = "-5";

            ArbitraryLong arbitraryLongX = ArbitraryLong.Parse(x);
            ArbitraryLong arbitraryLongY = ArbitraryLong.Parse(y);

            Assert.AreEqual(ArbitraryLong.Division(arbitraryLongX, arbitraryLongY).ToString(), "-1051");
        }

        [TestMethod]
        public void DivisionTest36()
        {
            ArbitraryLong x = new ArbitraryLong("-5255");
            ArbitraryLong y = new ArbitraryLong("5");

            Assert.AreEqual(ArbitraryLong.Division(x, y).ToString(), "-1051");
        }

        [TestMethod]
        public void DivisionTest37()
        {
            string x = "-5255";
            string y = "5";

            ArbitraryLong arbitraryLongX = ArbitraryLong.Parse(x);
            ArbitraryLong arbitraryLongY = ArbitraryLong.Parse(y);

            Assert.AreEqual(ArbitraryLong.Division(arbitraryLongX, arbitraryLongY).ToString(), "-1051");
        }

        [TestMethod]
        public void DivisionTest38()
        {
            ArbitraryLong x = new ArbitraryLong(42414124);
            ArbitraryLong y = new ArbitraryLong(4124);

            Assert.AreEqual(ArbitraryLong.Division(x, y).ToString(), "10284");
        }

        [TestMethod]
        public void DivisionTest39()
        {
            ArbitraryLong x = new ArbitraryLong(-3214124);
            ArbitraryLong y = new ArbitraryLong(588);

            Assert.AreEqual(ArbitraryLong.Division(x, y).ToString(), "-5466");
        }

        [TestMethod]
        public void DivisionTest40()
        {
            ArbitraryLong x = new ArbitraryLong(-7983283);
            ArbitraryLong y = new ArbitraryLong(-323);

            Assert.AreEqual(ArbitraryLong.Division(x, y).ToString(), "24716");
        }
    }
}
