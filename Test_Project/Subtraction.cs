using System;
using System.Collections.Generic;
using ArbitraryLongNumber;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test_Project
{
    [TestClass]
    public class Subtraction
    {
        [TestMethod]
        public void SubtractionTest1()
        {
            string x = "912378129632173152931264";
            string y = "312319999779877321";

            ArbitraryLong arbitraryLongX = ArbitraryLong.Parse(x);
            ArbitraryLong arbitraryLongY = ArbitraryLong.Parse(y);

            Assert.AreEqual(ArbitraryLong.Subtraction(arbitraryLongX, arbitraryLongY).ToString(), "912377817312173373053943");
        }

        [TestMethod]
        public void SubtractionTest2()
        {
            ArbitraryLong x = new ArbitraryLong("912378129632173152931264");
            ArbitraryLong y = new ArbitraryLong("312319999779877321");

            Assert.AreEqual(ArbitraryLong.Subtraction(x, y).ToString(), "912377817312173373053943");
        }

        [TestMethod]
        public void SubtractionTest3()
        {
            ArbitraryLong x = new ArbitraryLong("31232131124214");
            ArbitraryLong y = new ArbitraryLong("986312631");

            Assert.AreEqual(ArbitraryLong.Subtraction(x, y).ToString(), "31231144811583");
        }

        [TestMethod]
        public void SubtractionTest4()
        {
            string x = "31232131124214";
            string y = "986312631";

            ArbitraryLong arbitraryLongX = ArbitraryLong.Parse(x);
            ArbitraryLong arbitraryLongY = ArbitraryLong.Parse(y);

            Assert.AreEqual(ArbitraryLong.Subtraction(arbitraryLongX, arbitraryLongY).ToString(), "31231144811583");
        }

        [TestMethod]
        public void SubtractionTest5()
        {
            ArbitraryLong x = new ArbitraryLong("938378318362183126923968216383213");
            ArbitraryLong y = new ArbitraryLong("498278472178149142864169481281418284126812685235233532");

            Assert.AreEqual(ArbitraryLong.Subtraction(x, y).ToString(), "-498278472178149142863231102963056100999888717018850319");
        }

        [TestMethod]
        public void SubtractionTest6()
        {
            string x = "938378318362183126923968216383213";
            string y = "498278472178149142864169481281418284126812685235233532";

            ArbitraryLong arbitraryLongX = ArbitraryLong.Parse(x);
            ArbitraryLong arbitraryLongY = ArbitraryLong.Parse(y);

            Assert.AreEqual(ArbitraryLong.Subtraction(arbitraryLongX, arbitraryLongY).ToString(), "-498278472178149142863231102963056100999888717018850319");
        }

        [TestMethod]
        public void SubtractionTest7()
        {
            ArbitraryLong x = new ArbitraryLong("0");
            ArbitraryLong y = new ArbitraryLong("0");

            Assert.AreEqual(ArbitraryLong.Subtraction(x, y).ToString(), "0");
        }

        [TestMethod]
        public void SubtractionTest8()
        {
            ArbitraryLong x = new ArbitraryLong("-639136219831269381283812813298");
            ArbitraryLong y = new ArbitraryLong("124214900888888866666652");

            Assert.AreEqual(ArbitraryLong.Subtraction(x, y).ToString(), "-639136344046170270172679479950");
        }

        [TestMethod]
        public void SubtractionTest9()
        {
            string x = "-639136219831269381283812813298";
            string y = "124214900888888866666652";

            ArbitraryLong arbitraryLongX = ArbitraryLong.Parse(x);
            ArbitraryLong arbitraryLongY = ArbitraryLong.Parse(y);

            Assert.AreEqual(ArbitraryLong.Subtraction(arbitraryLongX, arbitraryLongY).ToString(), "-639136344046170270172679479950");
        }

        [TestMethod]
        public void SubtractionTest10()
        {
            ArbitraryLong x = new ArbitraryLong("-8946194162461264821686418184198498");
            ArbitraryLong y = new ArbitraryLong("89709764896162684912698412862169168241468614286468468168");

            Assert.AreEqual(ArbitraryLong.Subtraction(x, y).ToString(), "-89709764896162684912707359056331629506290300704652666666");
        }

        [TestMethod]
        public void SubtractionTest11()
        {
            string x = "-8946194162461264821686418184198498";
            string y = "89709764896162684912698412862169168241468614286468468168";

            ArbitraryLong arbitraryLongX = ArbitraryLong.Parse(x);
            ArbitraryLong arbitraryLongY = ArbitraryLong.Parse(y);

            Assert.AreEqual(ArbitraryLong.Subtraction(arbitraryLongX, arbitraryLongY).ToString(), "-89709764896162684912707359056331629506290300704652666666");
        }

        [TestMethod]
        public void SubtractionTest12()
        {
            ArbitraryLong x = new ArbitraryLong("9861266321636683126638216836821863861268362118");
            ArbitraryLong y = new ArbitraryLong("-683162368126832681636862183126989842164");

            Assert.AreEqual(ArbitraryLong.Subtraction(x, y).ToString(), "9861267004799051253470898473684046988258204282");
        }

        [TestMethod]
        public void SubtractionTest13()
        {
            string x = "9861266321636683126638216836821863861268362118";
            string y = "-683162368126832681636862183126989842164";

            ArbitraryLong arbitraryLongX = ArbitraryLong.Parse(x);
            ArbitraryLong arbitraryLongY = ArbitraryLong.Parse(y);

            Assert.AreEqual(ArbitraryLong.Subtraction(arbitraryLongX, arbitraryLongY).ToString(), "9861267004799051253470898473684046988258204282");
        }

        [TestMethod]
        public void SubtractionTest14()
        {
            ArbitraryLong x = new ArbitraryLong("681268326163868192683681268648109147412709");
            ArbitraryLong y = new ArbitraryLong("-9683168238126836182683162686846821686142684126842188641268142682");

            Assert.AreEqual(ArbitraryLong.Subtraction(x, y).ToString(), "9683168238126836182683843955172985554335367808110836750415555391");
        }

        [TestMethod]
        public void SubtractionTest15()
        {
            string x = "681268326163868192683681268648109147412709";
            string y = "-9683168238126836182683162686846821686142684126842188641268142682";

            ArbitraryLong arbitraryLongX = ArbitraryLong.Parse(x);
            ArbitraryLong arbitraryLongY = ArbitraryLong.Parse(y);

            Assert.AreEqual(ArbitraryLong.Subtraction(arbitraryLongX, arbitraryLongY).ToString(), "9683168238126836182683843955172985554335367808110836750415555391");
        }

        [TestMethod]
        public void SubtractionTest16()
        {
            ArbitraryLong x = new ArbitraryLong("-894198648199648216648126842109410212142601620848128");
            ArbitraryLong y = new ArbitraryLong("-8129972300291974217094721094684168941698");

            Assert.AreEqual(ArbitraryLong.Subtraction(x, y).ToString(), "-894198648191518244347834867892315491047917451906430");
        }

        [TestMethod]
        public void SubtractionTest17()
        {
            string x = "-894198648199648216648126842109410212142601620848128";
            string y = "-8129972300291974217094721094684168941698";

            ArbitraryLong arbitraryLongX = ArbitraryLong.Parse(x);
            ArbitraryLong arbitraryLongY = ArbitraryLong.Parse(y);

            Assert.AreEqual(ArbitraryLong.Subtraction(arbitraryLongX, arbitraryLongY).ToString(), "-894198648191518244347834867892315491047917451906430");
        }

        [TestMethod]
        public void SubtractionTest18()
        {
            ArbitraryLong x = new ArbitraryLong("-69832166983681246984126498194812948621684126842681264826821864268421682");
            ArbitraryLong y = new ArbitraryLong("-786321312398648296412648970921373712730217903209130932709321709317209371290974791271279420927971");

            Assert.AreEqual(ArbitraryLong.Subtraction(x, y).ToString(), "786321312398648296412648901089206729048970919082632737896373087633082528609709964449415152506289");
        }

        [TestMethod]
        public void SubtractionTest19()
        {
            string x = "-69832166983681246984126498194812948621684126842681264826821864268421682";
            string y = "-786321312398648296412648970921373712730217903209130932709321709317209371290974791271279420927971";

            ArbitraryLong arbitraryLongX = ArbitraryLong.Parse(x);
            ArbitraryLong arbitraryLongY = ArbitraryLong.Parse(y);

            Assert.AreEqual(ArbitraryLong.Subtraction(arbitraryLongX, arbitraryLongY).ToString(), "786321312398648296412648901089206729048970919082632737896373087633082528609709964449415152506289");
        }

        [TestMethod]
        public void SubtractionTest20()
        {
            ArbitraryLong x = new ArbitraryLong("-00000000000000000000000000000000");
            ArbitraryLong y = new ArbitraryLong("-0");

            Assert.AreEqual(ArbitraryLong.Subtraction(x, y).ToString(), "-0");
        }

        [TestMethod]
        public void SubtractionTest21()
        {
            ArbitraryLong x = new ArbitraryLong("1111111111111111111111111111111111111");
            ArbitraryLong y = new ArbitraryLong("1111111111111111111111111111111111111");
            Assert.AreEqual(ArbitraryLong.Subtraction(x, y).ToString(), "0");
        }

        [TestMethod]
        public void SubtractionTest22()
        {
            string x = "1111111111111111111111111111111111111";
            string y = "1111111111111111111111111111111111111";

            ArbitraryLong arbitraryLongX = ArbitraryLong.Parse(x);
            ArbitraryLong arbitraryLongY = ArbitraryLong.Parse(y);

            Assert.AreEqual(ArbitraryLong.Subtraction(arbitraryLongX, arbitraryLongY).ToString(), "0");
        }

        [TestMethod]
        public void SubtractionTest23()
        {
            ArbitraryLong x = new ArbitraryLong("2313123123123123123123123121123123");
            ArbitraryLong y = new ArbitraryLong("1186163210949712047217094790172070");

            Assert.AreEqual(ArbitraryLong.Subtraction(x, y).ToString(), "1126959912173411075906028330951053");
        }

        [TestMethod]
        public void SubtractionTest24()
        {
            string x = "2313123123123123123123123121123123";
            string y = "1186163210949712047217094790172070";

            ArbitraryLong arbitraryLongX = ArbitraryLong.Parse(x);
            ArbitraryLong arbitraryLongY = ArbitraryLong.Parse(y);

            Assert.AreEqual(ArbitraryLong.Subtraction(arbitraryLongX, arbitraryLongY).ToString(), "1126959912173411075906028330951053");
        }

        [TestMethod]
        public void SubtractionTest25()
        {
            ArbitraryLong x = new ArbitraryLong(321341242);
            ArbitraryLong y = new ArbitraryLong(4124141);

            Assert.AreEqual(ArbitraryLong.Subtraction(x, y).ToString(), "317217101");
        }

        [TestMethod]
        public void SubtractionTest26()
        {
            ArbitraryLong x = new ArbitraryLong(41221421);
            ArbitraryLong y = new ArbitraryLong(-720973);

            Assert.AreEqual(ArbitraryLong.Subtraction(x, y).ToString(), "41942394");
        }

        [TestMethod]
        public void SubtractionTest27()
        {
            ArbitraryLong x = new ArbitraryLong(-986866);
            ArbitraryLong y = new ArbitraryLong(-863663);

            Assert.AreEqual(ArbitraryLong.Subtraction(x, y).ToString(), "-123203");
        }

        [TestMethod]
        public void SubtractionTest28()
        {
            ArbitraryLong x = new ArbitraryLong(0);
            ArbitraryLong y = new ArbitraryLong(0);

            Assert.AreEqual(ArbitraryLong.Subtraction(x, y).ToString(), "0");
        }

        [TestMethod]
        public void SubtractionTest29()
        {
            ArbitraryLong x = new ArbitraryLong(-688263);
            ArbitraryLong y = new ArbitraryLong(-4242632);

            Assert.AreEqual(ArbitraryLong.Subtraction(x, y).ToString(), "3554369");
        }

        [TestMethod]
        public void SubtractionTest30()
        {
            ArbitraryLong x = new ArbitraryLong(new List<byte> { 3, 2 });
            ArbitraryLong y = new ArbitraryLong(new List<byte> { 2, 1 });

            Assert.AreEqual(ArbitraryLong.Subtraction(x, y).ToString(), "11");
        }
    }
}
