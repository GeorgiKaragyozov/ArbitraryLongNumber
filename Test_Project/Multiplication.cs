using System;
using ArbitraryLongNumber;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test_Project
{
    [TestClass]
    public class Multiplication
    {
        [TestMethod]
        public void MultiplicationTest1()
        {
            ArbitraryLong x = new ArbitraryLong("365");
            ArbitraryLong y = new ArbitraryLong("843");

            Assert.AreEqual(ArbitraryLong.Multiplication(x, y).ToString(), "307695");
        }

        [TestMethod]
        public void MultiplicationTest2()
        {
            string x = "365";
            string y = "843";

            ArbitraryLong arbitraryLongX = ArbitraryLong.Parse(x);
            ArbitraryLong arbitraryLongY = ArbitraryLong.Parse(y);

            Assert.AreEqual(ArbitraryLong.Multiplication(arbitraryLongX, arbitraryLongY).ToString(), "307695");
        }

        [TestMethod]
        public void MultiplicationTest3()
        {
            ArbitraryLong x = new ArbitraryLong("0000000000");
            ArbitraryLong y = new ArbitraryLong("00000000000000000");

            Assert.AreEqual(ArbitraryLong.Multiplication(x, y).ToString(), "0");
        }

        [TestMethod]
        public void MultiplicationTest4()
        {
            ArbitraryLong x = new ArbitraryLong("-0000000000");
            ArbitraryLong y = new ArbitraryLong("-00000000000000000");

            Assert.AreEqual(ArbitraryLong.Multiplication(x, y).ToString(), "0");
        }

        [TestMethod]
        public void MultiplicationTest5()
        {
            ArbitraryLong x = new ArbitraryLong("56544848558");
            ArbitraryLong y = new ArbitraryLong("65552987");

            Assert.AreEqual(ArbitraryLong.Multiplication(x, y).ToString(), "3706683722439542746");
        }

        [TestMethod]
        public void MultiplicationTest6()
        {
            string x = "56544848558";
            string y = "65552987";

            ArbitraryLong arbitraryLongX = ArbitraryLong.Parse(x);
            ArbitraryLong arbitraryLongY = ArbitraryLong.Parse(y);

            Assert.AreEqual(ArbitraryLong.Multiplication(arbitraryLongX, arbitraryLongY).ToString(), "3706683722439542746");
        }

        [TestMethod]
        public void MultiplicationTest7()
        {
            ArbitraryLong x = new ArbitraryLong("-7031937172730172747417274712");
            ArbitraryLong y = new ArbitraryLong("86931692936162368");

            Assert.AreEqual(ArbitraryLong.Multiplication(x, y).ToString(), "-611298203046165131635575865014194482492438016");
        }

        [TestMethod]
        public void MultiplicationTest8()
        {
            string x = "-7031937172730172747417274712";
            string y = "86931692936162368";

            ArbitraryLong arbitraryLongX = ArbitraryLong.Parse(x);
            ArbitraryLong arbitraryLongY = ArbitraryLong.Parse(y);

            Assert.AreEqual(ArbitraryLong.Multiplication(arbitraryLongX, arbitraryLongY).ToString(), "-611298203046165131635575865014194482492438016");
        }

        [TestMethod]
        public void MultiplicationTest9()
        {
            ArbitraryLong x = new ArbitraryLong("-3123213124421645509742727091");
            ArbitraryLong y = new ArbitraryLong("6894681268421846821984126984126841814896981");

            Assert.AreEqual(ArbitraryLong.Multiplication(x, y).ToString(), "-21533559026239190160675878908350170100040892387878497732503924162812271");
        }

        [TestMethod]
        public void MultiplicationTest10()
        {
            string x = "-3123213124421645509742727091";
            string y = "6894681268421846821984126984126841814896981";

            ArbitraryLong arbitraryLongX = ArbitraryLong.Parse(x);
            ArbitraryLong arbitraryLongY = ArbitraryLong.Parse(y);

            Assert.AreEqual(ArbitraryLong.Multiplication(arbitraryLongX, arbitraryLongY).ToString(), "-21533559026239190160675878908350170100040892387878497732503924162812271");
        }

        [TestMethod]
        public void MultiplicationTest11()
        {
            ArbitraryLong x = new ArbitraryLong("869412684216489216842169841284128914");
            ArbitraryLong y = new ArbitraryLong("-468941684921868491698149684186");

            Assert.AreEqual(ArbitraryLong.Multiplication(x, y).ToString(), "-407703849028924833775702910146899525746595947098137120003211154004");
        }

        [TestMethod]
        public void MultiplicationTest12()
        {
            string x = "869412684216489216842169841284128914";
            string y = "-468941684921868491698149684186";

            ArbitraryLong arbitraryLongX = ArbitraryLong.Parse(x);
            ArbitraryLong arbitraryLongY = ArbitraryLong.Parse(y);

            Assert.AreEqual(ArbitraryLong.Multiplication(arbitraryLongX, arbitraryLongY).ToString(), "-407703849028924833775702910146899525746595947098137120003211154004");
        }

        [TestMethod]
        public void MultiplicationTest13()
        {
            ArbitraryLong x = new ArbitraryLong("6841894816841984686841214");
            ArbitraryLong y = new ArbitraryLong("-8914681264816984198246891684124681248189");

            Assert.AreEqual(ArbitraryLong.Multiplication(x, y).ToString(), "-60993311539549672487785490474855791520114520154999762845168061446");
        }

        [TestMethod]
        public void MultiplicationTest14()
        {
            string x = "6841894816841984686841214";
            string y = "-8914681264816984198246891684124681248189";

            ArbitraryLong arbitraryLongX = ArbitraryLong.Parse(x);
            ArbitraryLong arbitraryLongY = ArbitraryLong.Parse(y);

            Assert.AreEqual(ArbitraryLong.Multiplication(arbitraryLongX, arbitraryLongY).ToString(), "-60993311539549672487785490474855791520114520154999762845168061446");
        }

        [TestMethod]
        public void MultiplicationTest15()
        {
            ArbitraryLong x = new ArbitraryLong("-98641968946164981626489612648198646126841264868912");
            ArbitraryLong y = new ArbitraryLong("-68921369831268313866812683");

            Assert.AreEqual(ArbitraryLong.Multiplication(x, y).ToString(), "6798539622623121035938572622949532777403163686416146413069479501591254010896");
        }

        [TestMethod]
        public void MultiplicationTest16()
        {
            string x = "-98641968946164981626489612648198646126841264868912";
            string y = "-68921369831268313866812683";

            ArbitraryLong arbitraryLongX = ArbitraryLong.Parse(x);
            ArbitraryLong arbitraryLongY = ArbitraryLong.Parse(y);

            Assert.AreEqual(ArbitraryLong.Multiplication(arbitraryLongX, arbitraryLongY).ToString(), "6798539622623121035938572622949532777403163686416146413069479501591254010896");
        }

        [TestMethod]
        public void MultiplicationTest17()
        {
            ArbitraryLong x = new ArbitraryLong("-1861686489168468124986126984698");
            ArbitraryLong y = new ArbitraryLong("-4891942846841864816698124861869498612698412");

            Assert.AreEqual(ArbitraryLong.Multiplication(x, y).ToString(), "9107263903749832487758105786179292001983647366803448469536467158812899576");
        }

        [TestMethod]
        public void MultiplicationTest18()
        {
            string x = "-1861686489168468124986126984698";
            string y = "-4891942846841864816698124861869498612698412";

            ArbitraryLong arbitraryLongX = ArbitraryLong.Parse(x);
            ArbitraryLong arbitraryLongY = ArbitraryLong.Parse(y);

            Assert.AreEqual(ArbitraryLong.Multiplication(arbitraryLongX, arbitraryLongY).ToString(), "9107263903749832487758105786179292001983647366803448469536467158812899576");
        }

        [TestMethod]
        public void MultiplicationTest19()
        {
            ArbitraryLong x = new ArbitraryLong(7999797);
            ArbitraryLong y = new ArbitraryLong(421214);

            Assert.AreEqual(ArbitraryLong.Multiplication(x, y).ToString(), "3369626493558");
        }

        [TestMethod]
        public void MultiplicationTest20()
        {
            ArbitraryLong x = new ArbitraryLong(8083133);
            ArbitraryLong y = new ArbitraryLong(-412421);

            Assert.AreEqual(ArbitraryLong.Multiplication(x, y).ToString(), "-3333653794993");
        }

        [TestMethod]
        public void MultiplicationTest21()
        {
            ArbitraryLong x = new ArbitraryLong(-13213124);
            ArbitraryLong y = new ArbitraryLong(-412421444);

            Assert.AreEqual(ArbitraryLong.Multiplication(x, y).ToString(), "5449375679831056");
        }

        [TestMethod]
        public void MultiplicationTest22()
        {
            ArbitraryLong x = new ArbitraryLong(-31232131);
            ArbitraryLong y = new ArbitraryLong(-4214224);

            Assert.AreEqual(ArbitraryLong.Multiplication(x, y).ToString(), "131619196031344");
        }

        [TestMethod]
        public void MultiplicationTest23()
        {
            ArbitraryLong x = new ArbitraryLong(0);
            ArbitraryLong y = new ArbitraryLong(00000000000000);

            Assert.AreEqual(ArbitraryLong.Multiplication(x, y).ToString(), "0");
        }
    }
}
