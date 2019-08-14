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
            //---X > 0 && Y > 0 => X < Y---//
            ArbitraryLong x = new ArbitraryLong("365");
            ArbitraryLong y = new ArbitraryLong("843");
            Assert.AreEqual(ArbitraryLong.Multiplication(x, y).Value, "307695");
        }

        [TestMethod]
        public void MultiplicationTest2()
        {
            //---X > 0 && Y > 0 => X = Y---//
            ArbitraryLong x = new ArbitraryLong("6");
            ArbitraryLong y = new ArbitraryLong("6");
            Assert.AreEqual(ArbitraryLong.Multiplication(x, y).Value, "36");
        }

        [TestMethod]
        public void MultiplicationTest3()
        {
            //---X = 0 && Y = 0 => X = Y---//
            ArbitraryLong x = new ArbitraryLong("0000000000");
            ArbitraryLong y = new ArbitraryLong("00000000000000000");
            Assert.AreEqual(ArbitraryLong.Multiplication(x, y).Value, "0");
        }

        [TestMethod]
        public void MultiplicationTest4()
        {
            ArbitraryLong x = new ArbitraryLong("-0000000000");
            ArbitraryLong y = new ArbitraryLong("-00000000000000000");
            Assert.AreEqual(ArbitraryLong.Multiplication(x, y).Value, "0");
        }

        [TestMethod]
        public void MultiplicationTest5()
        {
            //---X > 0 && Y > 0 => X > Y---//
            ArbitraryLong x = new ArbitraryLong("56544848558");
            ArbitraryLong y = new ArbitraryLong("65552987");
            Assert.AreEqual(ArbitraryLong.Multiplication(x, y).Value, "3706683722439542746");
        }

        [TestMethod]
        public void MultiplicationTest6()
        {
            //---X < 0 && Y > 0 => X > Y---//
            ArbitraryLong x = new ArbitraryLong("-7031937172730172747417274712");
            ArbitraryLong y = new ArbitraryLong("86931692936162368");
            Assert.AreEqual(ArbitraryLong.Multiplication(x, y).Value, "-611298203046165131635575865014194482492438016");
        }

        [TestMethod]
        public void MultiplicationTest7()
        {
            //---X < 0 && Y > 0 => X < Y---//
            ArbitraryLong x = new ArbitraryLong("-3123213124421645509742727091");
            ArbitraryLong y = new ArbitraryLong("6894681268421846821984126984126841814896981");
            Assert.AreEqual(ArbitraryLong.Multiplication(x, y).Value, "-21533559026239190160675878908350170100040892387878497732503924162812271");
        }

        [TestMethod]
        public void MultiplicationTest8()
        {
            //---X > 0 && Y < 0 => X > Y---//
            ArbitraryLong x = new ArbitraryLong("869412684216489216842169841284128914");
            ArbitraryLong y = new ArbitraryLong("-468941684921868491698149684186");
            Assert.AreEqual(ArbitraryLong.Multiplication(x, y).Value, "-407703849028924833775702910146899525746595947098137120003211154004");
        }

        [TestMethod]
        public void MultiplicationTest9()
        {
            //---X > 0 && Y < 0 => X < Y---//
            ArbitraryLong x = new ArbitraryLong("6841894816841984686841214");
            ArbitraryLong y = new ArbitraryLong("-8914681264816984198246891684124681248189");
            Assert.AreEqual(ArbitraryLong.Multiplication(x, y).Value, "-60993311539549672487785490474855791520114520154999762845168061446");
        }

        [TestMethod]
        public void MultiplicationTest10()
        {
            //---X < 0 && Y < 0 => X > Y---//
            ArbitraryLong x = new ArbitraryLong("-98641968946164981626489612648198646126841264868912");
            ArbitraryLong y = new ArbitraryLong("-68921369831268313866812683");
            Assert.AreEqual(ArbitraryLong.Multiplication(x, y).Value, "6798539622623121035938572622949532777403163686416146413069479501591254010896");
        }

        [TestMethod]
        public void MultiplicationTest11()
        {
            //---X < 0 && Y < 0 => X < Y---//
            ArbitraryLong x = new ArbitraryLong("-1861686489168468124986126984698");
            ArbitraryLong y = new ArbitraryLong("-4891942846841864816698124861869498612698412");
            Assert.AreEqual(ArbitraryLong.Multiplication(x, y).Value, "9107263903749832487758105786179292001983647366803448469536467158812899576");
        }
    }
}
