using System;
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
            //---X > 0 && Y > 0 => X > Y---//
            ArbitraryLong x = new ArbitraryLong("912378129632173152931264");
            ArbitraryLong y = new ArbitraryLong("312319999779877321");
            Assert.AreEqual(ArbitraryLong.Subtraction(x, y).Value, "912377817312173373053943");
        }

        [TestMethod]
        public void SubtractionTest2()
        {
            //---X > 0 && Y > 0 => X > Y---//
            ArbitraryLong x = new ArbitraryLong("739931231");
            ArbitraryLong y = new ArbitraryLong("426978331");
            Assert.AreEqual(ArbitraryLong.Subtraction(x, y).Value, "312952900");
        }

        [TestMethod]
        public void SubtractionTest3()
        {
            //---X > 0 && Y > 0 => X < Y---//
            ArbitraryLong x = new ArbitraryLong("938378318362183126923968216383213");
            ArbitraryLong y = new ArbitraryLong("498278472178149142864169481281418284126812685235233532");
            Assert.AreEqual(ArbitraryLong.Subtraction(x, y).Value, "-498278472178149142863231102963056100999888717018850319");
        }

        [TestMethod]
        public void SubtractionTest4()
        {
            ArbitraryLong x = new ArbitraryLong("0");
            ArbitraryLong y = new ArbitraryLong("0");
            Assert.AreEqual(ArbitraryLong.Subtraction(x, y).Value, "0");
        }

        [TestMethod]
        public void SubtractionTest5()
        {
            //---X < 0 && Y > 0 => X > Y---//
            ArbitraryLong x = new ArbitraryLong("-639136219831269381283812813298");
            ArbitraryLong y = new ArbitraryLong("124214900888888866666652");
            Assert.AreEqual(ArbitraryLong.Subtraction(x, y).Value, "-639136344046170270172679479950");
        }

        [TestMethod]
        public void SubtractionTest6()
        {
            //---X < 0 && Y > 0 => X < Y---//
            ArbitraryLong x = new ArbitraryLong("-8946194162461264821686418184198498");
            ArbitraryLong y = new ArbitraryLong("89709764896162684912698412862169168241468614286468468168");
            Assert.AreEqual(ArbitraryLong.Subtraction(x, y).Value, "-89709764896162684912707359056331629506290300704652666666");
        }

        [TestMethod]
        public void SubtractionTest7()
        {
            //---X > 0 && Y < 0 => X > Y---//
            ArbitraryLong x = new ArbitraryLong("9861266321636683126638216836821863861268362118");
            ArbitraryLong y = new ArbitraryLong("-683162368126832681636862183126989842164");
            Assert.AreEqual(ArbitraryLong.Subtraction(x, y).Value, "9861267004799051253470898473684046988258204282");
        }

        [TestMethod]
        public void SubtractionTest8()
        {
            //---X > 0 && Y < 0 => X < Y---//
            ArbitraryLong x = new ArbitraryLong("681268326163868192683681268648109147412709");
            ArbitraryLong y = new ArbitraryLong("-9683168238126836182683162686846821686142684126842188641268142682");
            Assert.AreEqual(ArbitraryLong.Subtraction(x, y).Value, "9683168238126836182683843955172985554335367808110836750415555391");
        }

        [TestMethod]
        public void SubtractionTest9()
        {
            //---X < 0 && Y < 0 => X > Y---//
            ArbitraryLong x = new ArbitraryLong("-894198648199648216648126842109410212142601620848128");
            ArbitraryLong y = new ArbitraryLong("-8129972300291974217094721094684168941698");
            Assert.AreEqual(ArbitraryLong.Subtraction(x, y).Value, "-894198648191518244347834867892315491047917451906430");
        }

        [TestMethod]
        public void SubtractionTest10()
        {
            //---X < 0 && Y < 0 => X < Y---//
            ArbitraryLong x = new ArbitraryLong("-69832166983681246984126498194812948621684126842681264826821864268421682");
            ArbitraryLong y = new ArbitraryLong("-786321312398648296412648970921373712730217903209130932709321709317209371290974791271279420927971");
            Assert.AreEqual(ArbitraryLong.Subtraction(x, y).Value, "786321312398648296412648901089206729048970919082632737896373087633082528609709964449415152506289");
        }

        [TestMethod]
        public void SubtractionTest11()
        {
            ArbitraryLong x = new ArbitraryLong("-00000000000000000000000000000000");
            ArbitraryLong y = new ArbitraryLong("-0");
            Assert.AreEqual(ArbitraryLong.Subtraction(x, y).Value, "-0");
        }

        [TestMethod]
        public void SubtractionTest12()
        {
            ArbitraryLong x = new ArbitraryLong("1111111111111111111111111111111111111");
            ArbitraryLong y = new ArbitraryLong("1111111111111111111111111111111111111");
            Assert.AreEqual(ArbitraryLong.Subtraction(x, y).Value, "0");
        }

        [TestMethod]
        public void SubtractionTest13()
        {
            //---X > 0 && Y > 0 => X > Y---//
            ArbitraryLong x = new ArbitraryLong("2313123123123123123123123121123123");
            ArbitraryLong y = new ArbitraryLong("1186163210949712047217094790172070");
            Assert.AreEqual(ArbitraryLong.Subtraction(x, y).Value, "1126959912173411075906028330951053");
        }
    }
}
