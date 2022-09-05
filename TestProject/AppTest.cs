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
        public void RomanNumberParse() {

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
    }
}


/*
 TDD - test driven development - development that controls by tests
Essence - in begin you need to write the tests, then create software, which passing these tests.
XP - adding - minimum wayout
 
 */