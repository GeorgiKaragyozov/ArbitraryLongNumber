using System;
using System.Collections.Generic;
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
            string x = "7309";
            string y = "6978";

            ArbitraryLong arbitraryLongX = ArbitraryLong.Parse(x);
            ArbitraryLong arbitraryLongY = ArbitraryLong.Parse(y);

            Assert.AreEqual(ArbitraryLong.Addition(arbitraryLongX, arbitraryLongY).ToString(), "14287");
        }

        [TestMethod]
        public void AdditionTest2()
        {
            ArbitraryLong x = new ArbitraryLong("7309");
            ArbitraryLong y = new ArbitraryLong("6978");

            Assert.AreEqual(ArbitraryLong.Addition(x, y).ToString(), "14287");
        }

        //[TestMethod]
        //public void AdditionTest3()
        //{
        //    ArbitraryLong x = new ArbitraryLong(new List<byte> { 7, 3, 0, 9 });
        //    ArbitraryLong y = new ArbitraryLong(new List<byte> { 6, 9, 7, 8 });

        //    Assert.AreEqual(ArbitraryLong.Addition(x, y).ToString(), "14287");
        //}

        [TestMethod]
        public void AdditionTest4()
        {
            ArbitraryLong x = new ArbitraryLong("82912");
            ArbitraryLong y = new ArbitraryLong("9876");

            Assert.AreEqual(ArbitraryLong.Addition(x, y).ToString(), "92788");
        }

        [TestMethod]
        public void AdditionTest5()
        {
            string x = "82912";
            string y = "9876";

            ArbitraryLong arbitraryLongX = ArbitraryLong.Parse(x);
            ArbitraryLong arbitraryLongY = ArbitraryLong.Parse(y);

            Assert.AreEqual(ArbitraryLong.Addition(arbitraryLongX, arbitraryLongY).ToString(), "92788");
        }

        [TestMethod]
        public void AdditionTest6()
        {
            ArbitraryLong x = new ArbitraryLong("92321321");
            ArbitraryLong y = new ArbitraryLong("7547475474");

            Assert.AreEqual(ArbitraryLong.Addition(x, y).ToString(), "7639796795");
        }

        [TestMethod]
        public void AdditionTest7()
        {
            string x = "92321321";
            string y = "7547475474";

            ArbitraryLong arbitraryLongX = ArbitraryLong.Parse(x);
            ArbitraryLong arbitraryLongY = ArbitraryLong.Parse(y);

            Assert.AreEqual(ArbitraryLong.Addition(arbitraryLongX, arbitraryLongY).ToString(), "7639796795");
        }

        [TestMethod]
        public void AdditionTest8()
        {
            ArbitraryLong x = new ArbitraryLong("895739043");
            ArbitraryLong y = new ArbitraryLong("-9987422");

            Assert.AreEqual(ArbitraryLong.Addition(x, y).ToString(), "885751621");
        }

        [TestMethod]
        public void AdditionTest9()
        {
            string x = "895739043";
            string y = "-9987422";

            ArbitraryLong arbitraryLongX = ArbitraryLong.Parse(x);
            ArbitraryLong arbitraryLongY = ArbitraryLong.Parse(y);

            Assert.AreEqual(ArbitraryLong.Addition(arbitraryLongX, arbitraryLongY).ToString(), "885751621");
        }

        [TestMethod]
        public void AdditionTest10()
        {
            ArbitraryLong x = new ArbitraryLong("9876542421998879");
            ArbitraryLong y = new ArbitraryLong("-9987665443232");

            Assert.AreEqual(ArbitraryLong.Addition(x, y).ToString(), "9866554756555647");
        }

        [TestMethod]
        public void AdditionTest11()
        {
            string x = "9876542421998879";
            string y = "-9987665443232";

            ArbitraryLong arbitraryLongX = ArbitraryLong.Parse(x);
            ArbitraryLong arbitraryLongY = ArbitraryLong.Parse(y);

            Assert.AreEqual(ArbitraryLong.Addition(arbitraryLongX, arbitraryLongY).ToString(), "9866554756555647");
        }

        [TestMethod]
        public void AdditionTest12()
        {
            ArbitraryLong x = new ArbitraryLong("-3535352999634399");
            ArbitraryLong y = new ArbitraryLong("-39998877332218");

            Assert.AreEqual(ArbitraryLong.Addition(x, y).ToString(), "-3575351876966617");
        }

        [TestMethod]
        public void AdditionTest13()
        {
            string x = "-3535352999634399";
            string y = "-39998877332218";

            ArbitraryLong arbitraryLongX = ArbitraryLong.Parse(x);
            ArbitraryLong arbitraryLongY = ArbitraryLong.Parse(y);

            Assert.AreEqual(ArbitraryLong.Addition(arbitraryLongX, arbitraryLongY).ToString(), "-3575351876966617");
        }

        [TestMethod]
        public void AdditionTest14()
        {
            ArbitraryLong x = new ArbitraryLong("000000000000000000000");
            ArbitraryLong y = new ArbitraryLong("00000000000");

            Assert.AreEqual(ArbitraryLong.Addition(x, y).ToString(), "0");
        }

        [TestMethod]
        public void AdditionTest15()
        {
            string x = "000000000000000000000";
            string y = "00000000000";

            ArbitraryLong arbitraryLongX = ArbitraryLong.Parse(x);
            ArbitraryLong arbitraryLongY = ArbitraryLong.Parse(y);

            Assert.AreEqual(ArbitraryLong.Addition(arbitraryLongX, arbitraryLongX).ToString(), "0");
        }

        [TestMethod]
        public void AdditionTest16()
        {
            ArbitraryLong x = new ArbitraryLong("-0");
            ArbitraryLong y = new ArbitraryLong("-0");

            Assert.AreEqual(ArbitraryLong.Addition(x, y).ToString(), "-0");
        }

        [TestMethod]
        public void AdditionTest17()
        {
            string x = "-0";
            string y = "-0";

            ArbitraryLong arbitraryLongX = ArbitraryLong.Parse(x);
            ArbitraryLong arbitraryLongY = ArbitraryLong.Parse(y);

            Assert.AreEqual(ArbitraryLong.Addition(arbitraryLongX, arbitraryLongY).ToString(), "-0");
        }

        [TestMethod]
        public void AdditionTest18()
        {
            ArbitraryLong x = new ArbitraryLong("-3535352999634399");
            ArbitraryLong y = new ArbitraryLong("39998877332218");

            Assert.AreEqual(ArbitraryLong.Addition(x, y).ToString(), "-3495354122302181");
        }

        [TestMethod]
        public void AdditionTest19()
        {
            string x = "-3535352999634399";
            string y = "39998877332218";

            ArbitraryLong arbitraryLongX = ArbitraryLong.Parse(x);
            ArbitraryLong arbitraryLongY = ArbitraryLong.Parse(y);

            Assert.AreEqual(ArbitraryLong.Addition(arbitraryLongX, arbitraryLongY).ToString(), "-3495354122302181");
        }

        [TestMethod]
        public void AdditionTest20()
        {
            ArbitraryLong x = new ArbitraryLong("0");
            ArbitraryLong y = new ArbitraryLong("99999999");

            Assert.AreEqual(ArbitraryLong.Addition(x, y).ToString(), "99999999");
        }

        [TestMethod]
        public void AdditionTest21()
        {
            string x = "0";
            string y = "99999999";

            ArbitraryLong arbitraryLongX = ArbitraryLong.Parse(x);
            ArbitraryLong arbitraryLongY = ArbitraryLong.Parse(y);

            Assert.AreEqual(ArbitraryLong.Addition(arbitraryLongX, arbitraryLongY).ToString(), "99999999");
        }

        [TestMethod]
        public void AdditionTest22()
        {
            ArbitraryLong x = new ArbitraryLong("979778668689680997896543351535217626185313");
            ArbitraryLong y = new ArbitraryLong("9987736836636816828163121386318831266128632168162368163813286123");

            Assert.AreEqual(ArbitraryLong.Addition(x, y).ToString(), "9987736836636816828164101164987520947126528711513903381439471436");
        }

        [TestMethod]
        public void AdditionTest23()
        {
            string x = "979778668689680997896543351535217626185313";
            string y = "9987736836636816828163121386318831266128632168162368163813286123";

            ArbitraryLong arbitraryLongX = ArbitraryLong.Parse(x);
            ArbitraryLong arbitraryLongY = ArbitraryLong.Parse(y);

            Assert.AreEqual(ArbitraryLong.Addition(arbitraryLongX, arbitraryLongY).ToString(), "9987736836636816828164101164987520947126528711513903381439471436");
        }

        [TestMethod]
        public void AdditionTest24()
        {
            ArbitraryLong x = new ArbitraryLong("21312321233213214124112412421876865655855885632432421643643");
            ArbitraryLong y = new ArbitraryLong("-6434121242421424242424242446346458658659497472974249219642169146461946641269415845");

            Assert.AreEqual(ArbitraryLong.Addition(x, y).ToString(), "-6434121242421424242424221134025225445445373360561827342776513290576314208847772202");
        }

        [TestMethod]
        public void AdditionTest25()
        {
            string x = "21312321233213214124112412421876865655855885632432421643643";
            string y = "-6434121242421424242424242446346458658659497472974249219642169146461946641269415845";

            ArbitraryLong arbitraryLongX = ArbitraryLong.Parse(x);
            ArbitraryLong arbitraryLongY = ArbitraryLong.Parse(y);

            Assert.AreEqual(ArbitraryLong.Addition(arbitraryLongX, arbitraryLongY).ToString(), "-6434121242421424242424221134025225445445373360561827342776513290576314208847772202");
        }

        [TestMethod]
        public void AdditionTest26()
        {
            ArbitraryLong x = new ArbitraryLong(283753125);
            ArbitraryLong y = new ArbitraryLong(312321);

            Assert.AreEqual(ArbitraryLong.Addition(x, y).ToString(), "284065446");
        }

        [TestMethod]
        public void AdditionTest27()
        {
            ArbitraryLong x = new ArbitraryLong(31232134);
            ArbitraryLong y = new ArbitraryLong(-889777);

            Assert.AreEqual(ArbitraryLong.Addition(x, y).ToString(), "30342357");
        }

        [TestMethod]
        public void AdditionTest28()
        {
            ArbitraryLong x = new ArbitraryLong(0);
            ArbitraryLong y = new ArbitraryLong(0);

            Assert.AreEqual(ArbitraryLong.Addition(x, y).ToString(), "0");
        }

        [TestMethod]
        public void AdditionTest29()
        {
            ArbitraryLong x = new ArbitraryLong(-698236326);
            ArbitraryLong y = new ArbitraryLong(-7474127);

            Assert.AreEqual(ArbitraryLong.Addition(x, y).ToString(), "-705710453");
        }
    }
}
