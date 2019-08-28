using System;
using ArbitraryLongNumber;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test_Project
{
    [TestClass]
    public class Division
    {
        //[TestMethod]
        //public void DivisionTest1()
        //{
        //    ArbitraryLong x = new ArbitraryLong("5255");
        //    ArbitraryLong y = new ArbitraryLong("5");

        //    Assert.AreEqual(ArbitraryLong.Division(x, y).ToString(), "1051");
        //}

        //[TestMethod]
        //public void DivisionTest2()
        //{
        //    ArbitraryLong x = new ArbitraryLong("525");
        //    ArbitraryLong y = new ArbitraryLong("5");

        //    Assert.AreEqual(ArbitraryLong.Division(x, y).ToString(), "105");
        //}

        [TestMethod]
        public void DivisionTest3()
        {
            ArbitraryLong x = new ArbitraryLong("222");
            ArbitraryLong y = new ArbitraryLong("2");

            Assert.AreEqual(ArbitraryLong.Division(x, y).ToString(), "111");
        }

        [TestMethod]
        public void DivisionTest4()
        {
            ArbitraryLong x = new ArbitraryLong("0000");
            ArbitraryLong y = new ArbitraryLong("0000000");

            Assert.AreEqual(ArbitraryLong.Division(x, y).ToString(), "0");
        }

        //[TestMethod]
        //public void DivisionTest5()
        //{
        //    ArbitraryLong x = new ArbitraryLong("0");
        //    ArbitraryLong y = new ArbitraryLong("8888");
        //    Assert.AreEqual(ArbitraryLong.Division(x, y).Value, "0");
        //}

        //[TestMethod]
        //[ExpectedException(typeof(DivideByZeroException))]
        //public void DivisionTest6()
        //{
        //    ArbitraryLong x = new ArbitraryLong("555");
        //    ArbitraryLong y = new ArbitraryLong("0");
        //    ArbitraryLong.Division(x, y);
        //}

        //[TestMethod]
        //public void DivisionTest7()
        //{
        //    ArbitraryLong x = new ArbitraryLong("56952");
        //    ArbitraryLong y = new ArbitraryLong("123");

        //    Assert.AreEqual(ArbitraryLong.Division(x, y).ToString(), "463");
        //}

        //[TestMethod]
        //public void DivisionTest8()
        //{
        //    ArbitraryLong x = new ArbitraryLong("9266132968316831626132968");
        //    ArbitraryLong y = new ArbitraryLong("41241244121421");
        //    Assert.AreEqual(ArbitraryLong.Division(x, y).Value, "224681218176");
        //}

        //[TestMethod]
        //public void DivisionTest9()
        //{
        //    ArbitraryLong x = new ArbitraryLong("421421421412421634");
        //    ArbitraryLong y = new ArbitraryLong("5569274");
        //    Assert.AreEqual(ArbitraryLong.Division(x, y).Value, "75669004867");
        //}

        //[TestMethod]
        //public void DivisionTest10()
        //{
        //    ArbitraryLong x = new ArbitraryLong("9831636261326822398329821368328");
        //    ArbitraryLong y = new ArbitraryLong("87328737253275132573");
        //    Assert.AreEqual(ArbitraryLong.Division(x, y).Value, "112581912558");
        //}

        //[TestMethod]
        //public void DivisionTest11()
        //{
        //    ArbitraryLong x = new ArbitraryLong("213123123215257735534");
        //    ArbitraryLong y = new ArbitraryLong("846842684686846828643683468348");
        //    Assert.AreEqual(ArbitraryLong.Division(x, y).Value, "0");
        //}

        //[TestMethod]
        //public void DivisionTest12()
        //{
        //    ArbitraryLong x = new ArbitraryLong("-873183828929861326813686");
        //    ArbitraryLong y = new ArbitraryLong("85732812968139838");
        //    Assert.AreEqual(ArbitraryLong.Division(x, y).Value, "-10184943"); 
        //}

        //[TestMethod]
        //public void DivisionTest13()
        //{
        //    ArbitraryLong x = new ArbitraryLong("559861369836298312312412");
        //    ArbitraryLong y = new ArbitraryLong("-9841418984189");
        //    Assert.AreEqual(ArbitraryLong.Division(x, y).Value, "-56888277060");
        //}

        //[TestMethod]
        //public void DivisionTest14()
        //{
        //    ArbitraryLong x = new ArbitraryLong("-8636298269832141412634");
        //    ArbitraryLong y = new ArbitraryLong("-981412684218");
        //    Assert.AreEqual(ArbitraryLong.Division(x, y).Value, "8799864123");
        //}

        //[TestMethod]
        //public void DivisionTest15()
        //{
        //    ArbitraryLong x = new ArbitraryLong("98128291794217974710709417094791");
        //    ArbitraryLong y = new ArbitraryLong("968468989");
        //    Assert.AreEqual(ArbitraryLong.Division(x, y).Value, "101323111951721951017173");
        //}

        //[TestMethod]
        //public void DivisionTest16()
        //{
        //    ArbitraryLong x = new ArbitraryLong("9683168969316836861836868128386213682183907790479127947910929494127909942197479742974107717797412");
        //    ArbitraryLong y = new ArbitraryLong("9731279302090927379217903297737");
        //    Assert.AreEqual(ArbitraryLong.Division(x, y).Value, "995056114280498226849741687238393226119977530968706309466930586427");
        //}

        //[TestMethod]
        //public void DivisionTest17()
        //{
        //    ArbitraryLong x = new ArbitraryLong("9863168382698328832893126836");
        //    ArbitraryLong y = new ArbitraryLong("86361683812498614681642684681428682486612684682148");
        //    Assert.AreEqual(ArbitraryLong.Division(x, y).Value, "0");
        //}

        //[TestMethod]
        //public void DivisionTest18()
        //{
        //    ArbitraryLong x = new ArbitraryLong("5255");
        //    ArbitraryLong y = new ArbitraryLong("-5");
        //    Assert.AreEqual(ArbitraryLong.Division(x, y).Value, "-1051");
        //}

        //[TestMethod]
        //public void DivisionTest19()
        //{
        //    ArbitraryLong x = new ArbitraryLong("-5255");
        //    ArbitraryLong y = new ArbitraryLong("5");
        //    Assert.AreEqual(ArbitraryLong.Division(x, y).Value, "-1051");
        //}
    }
}
