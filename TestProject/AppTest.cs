using Calc.App;
namespace TestProject
 
{
    [TestClass]
    public class AppTest
    {
        [TestMethod]
        public void CalcTest()
        {
            //Trying to create object of main class 
            Calc.App.Calc calc = new();
            //Statement - Need to receive not-null value
            Assert.IsNotNull(calc);
        }

        [TestMethod]
        public void RomanNumberParse()
        {

            Assert.AreEqual(RomanNumber.Parse("I"), 1);
            Assert.AreEqual(RomanNumber.Parse("IV"), 4);
            Assert.AreEqual(RomanNumber.Parse("XV"), 15);
            Assert.AreEqual(RomanNumber.Parse("XXX"), 30);
            Assert.AreEqual(RomanNumber.Parse("CM"), 900);
            Assert.AreEqual(RomanNumber.Parse("MCMXCIX"), 1999);
            Assert.AreEqual(RomanNumber.Parse("CD"), 400);
            Assert.AreEqual(RomanNumber.Parse("CDI"), 401);
            Assert.AreEqual(RomanNumber.Parse("LV"), 55);
            Assert.AreEqual(RomanNumber.Parse("XL"), 40);

        }
        [TestMethod]
        public void RomanNumberParseNdigits()
        {
            var exc = Assert.ThrowsException<ArgumentException>(() => { RomanNumber.Parse("XNX"); });//Daniel Change
            var exp = new ArgumentException("Invalid number, only one 'N'");
            Assert.AreEqual(exc.ParamName, exp.ParamName);
        }

        //Ann's tests
        [TestMethod]
        public void RomanNumberNegativeDigitCrosTest()
        {
            //Parse test
            Assert.AreEqual(-400, RomanNumber.Parse("-CD"), "-CD == -400");

            Assert.AreEqual(-4, RomanNumber.Parse("-IV"), "-IV == -4");

            Assert.AreEqual(-10, RomanNumber.Parse("-X"), "-X == -10");

            Assert.AreEqual(-30, RomanNumber.Parse("-XXX"), "-XXX == -30");

            Assert.AreEqual(-1999, RomanNumber.Parse("-MCMXCIX"), "-MCMXCIX == -1999");

            //ToString test
            RomanNumber romanNumber = new(-10);
            Assert.AreEqual("-X", romanNumber.ToString());

            romanNumber = new(-1);
            Assert.AreEqual("-I", romanNumber.ToString());

            romanNumber = new(-90);
            Assert.AreEqual("-XC", romanNumber.ToString());

            romanNumber = new(-55);
            Assert.AreEqual("-LV", romanNumber.ToString());

            romanNumber = new(-120);
            Assert.AreEqual("-CXX", romanNumber.ToString());


            //error
            Assert.ThrowsException<ArgumentException>(() => { RomanNumber.Parse("1CMXCIX-"); });
            Assert.ThrowsException<ArgumentException>(() => { RomanNumber.Parse("--1CMXCIX"); });
            Assert.ThrowsException<ArgumentException>(() => { RomanNumber.Parse("--1CMXCIX-"); });
        }
    }
}


/*
 TDD - test driven development - development that controls by tests
Essence - in begin you need to write the tests, then create software, which passing these tests.
XP - adding - minimum wayout
 
 */