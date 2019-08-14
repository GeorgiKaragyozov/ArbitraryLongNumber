using System;
using ArbitraryLongNumber;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test_Project
{
    [TestClass]
    public class Addition
    {
        [TestMethod]
        public void AdditionTest1()
        {
            //---X > 0 && Y > 0 => X > Y---//
            ArbitraryLong x = new ArbitraryLong("7309");
            ArbitraryLong y = new ArbitraryLong("6978");
            Assert.AreEqual(ArbitraryLong.Addition(x, y).Value, "14287");
        }

        [TestMethod]
        public void AdditionTest2()
        {
            //---X > 0 && Y > 0 => X > Y---//
            ArbitraryLong x = new ArbitraryLong("82912");
            ArbitraryLong y = new ArbitraryLong("9876");
            Assert.AreEqual(ArbitraryLong.Addition(x, y).Value, "92788");
        }

        [TestMethod]
        public void AdditionTest3()
        {
            //---X > 0 && Y > 0 => X < Y---//
            ArbitraryLong x = new ArbitraryLong("92321321");
            ArbitraryLong y = new ArbitraryLong("7547475474");
            Assert.AreEqual(ArbitraryLong.Addition(x, y).Value, "7639796795");
        }

        [TestMethod]
        public void AdditionTest4()
        {
            //---X > 0 && Y < 0 => X > Y--//
            ArbitraryLong x = new ArbitraryLong("895739043");
            ArbitraryLong y = new ArbitraryLong("-9987422");
            Assert.AreEqual(ArbitraryLong.Addition(x, y).Value, "885751621");
        }

        [TestMethod]
        public void AdditionTest5()
        {
            //---X > 0 && Y < 0 => X > Y--//
            ArbitraryLong x = new ArbitraryLong("9876542421998879");
            ArbitraryLong y = new ArbitraryLong("-9987665443232");
            Assert.AreEqual(ArbitraryLong.Addition(x, y).Value,"9866554756555647");
        }

        [TestMethod]
        public void AdditionTest6()
        {
            //---X < 0 && Y < 0 => X == Y--//
            ArbitraryLong x = new ArbitraryLong("-3");
            ArbitraryLong y = new ArbitraryLong("-3");
            Assert.AreEqual(ArbitraryLong.Addition(x, y).Value, "-6");
        }

        [TestMethod]
        public void AdditionTest7()
        {
            //---X < 0 && Y < 0 => X > Y--//
            ArbitraryLong x = new ArbitraryLong("-3535352999634399");
            ArbitraryLong y = new ArbitraryLong("-39998877332218");
            Assert.AreEqual(ArbitraryLong.Addition(x, y).Value, "-3575351876966617");
        }

        [TestMethod]
        public void AdditionTest8()
        {
            //---X < 0 && Y < 0 => X < Y--//
            ArbitraryLong x = new ArbitraryLong("-35353529994288");
            ArbitraryLong y = new ArbitraryLong("-6999887741421988");
            Assert.AreEqual(ArbitraryLong.Addition(x, y).Value, "-7035241271416276");
        }

        [TestMethod]
        public void AdditionTest9()
        {
            ArbitraryLong x = new ArbitraryLong("000000000000000000000");
            ArbitraryLong y = new ArbitraryLong("00000000000");
            Assert.AreEqual(ArbitraryLong.Addition(x, y).Value, "0");
        }

        [TestMethod]
        public void AdditionTest10()
        {
            ArbitraryLong x = new ArbitraryLong("-0");
            ArbitraryLong y = new ArbitraryLong("-0");
            Assert.AreEqual(ArbitraryLong.Addition(x, y).Value, "-0");
        }

        [TestMethod]
        public void AdditionTest11()
        {
            ArbitraryLong x = new ArbitraryLong("-00000000000000000000000000000000");
            ArbitraryLong y = new ArbitraryLong("-0000000000000");
            Assert.AreEqual(ArbitraryLong.Addition(x, y).Value, "-0");
        }

        [TestMethod]
        public void AdditionTest12()
        {
            //---X < 0 && Y > 0 => X > Y--//
            ArbitraryLong x = new ArbitraryLong("-3535352999634399");
            ArbitraryLong y = new ArbitraryLong("39998877332218");
            Assert.AreEqual(ArbitraryLong.Addition(x, y).Value, "-3495354122302181");
        }

        [TestMethod]
        public void AdditionTest13()
        {
            //---X = 0 && Y > 0 => X < Y--//
            ArbitraryLong x = new ArbitraryLong("0");
            ArbitraryLong y = new ArbitraryLong("99999999");
            Assert.AreEqual(ArbitraryLong.Addition(x, y).Value, "99999999");
        }

        [TestMethod]
        public void AdditionTest14()
        {
            //---X > 0 && Y > 0 => X > Y--//
            ArbitraryLong x = new ArbitraryLong("9797379921731779");
            ArbitraryLong y = new ArbitraryLong("8389382893283");
            Assert.AreEqual(ArbitraryLong.Addition(x, y).Value, "9805769304625062");
        }

        [TestMethod]
        public void AdditionTest15()
        {
            //---X > 0 && Y > 0 => X > Y--//
            ArbitraryLong x = new ArbitraryLong("10203040506070");
            ArbitraryLong y = new ArbitraryLong("809030303030");
            Assert.AreEqual(ArbitraryLong.Addition(x, y).Value, "11012070809100");
        }

        [TestMethod]
        public void AdditionTest16()
        {
            //---X > 0 && Y > 0 => X > Y--//
            ArbitraryLong x = new ArbitraryLong("979778668689680997896543351535217626185313");
            ArbitraryLong y = new ArbitraryLong("9987736836636816828163121386318831266128632168162368163813286123");
            Assert.AreEqual(ArbitraryLong.Addition(x, y).Value, "9987736836636816828164101164987520947126528711513903381439471436");
        }

        [TestMethod]
        public void AdditionTest17()
        {
            //---X > 0 && Y < 0 => X < Y--//
            ArbitraryLong x = new ArbitraryLong("21312321233213214124112412421876865655855885632432421643643");
            ArbitraryLong y = new ArbitraryLong("-6434121242421424242424242446346458658659497472974249219642169146461946641269415845");
            Assert.AreEqual(ArbitraryLong.Addition(x, y).Value, "-6434121242421424242424221134025225445445373360561827342776513290576314208847772202");
        }
    }
}
