using FizzBuzz;

namespace TestFizzBuzz
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void Test1Return1()
        {
            FizzBuzzConverter converter = new FizzBuzzConverter();

           string returnedText = converter.CheckIfFizzOrBuzzOrFizzBuzz("", 1);

            Assert.AreEqual("1", returnedText);
        }

        [TestMethod]
        public void Test3ReturnFizz()
        {
            FizzBuzzConverter converter = new FizzBuzzConverter();

           string returnedText = converter.CheckIfFizzOrBuzzOrFizzBuzz("", 3);

            Assert.AreEqual("Fizz", returnedText);
        }

        [TestMethod]
        public void Test5ReturnBuzz()
        {
            FizzBuzzConverter converter = new FizzBuzzConverter();

           string returnedText = converter.CheckIfFizzOrBuzzOrFizzBuzz("", 5);

            Assert.AreEqual("Buzz", returnedText);
        }

        [TestMethod]
        public void Test15ReturnFizzBuzz()
        {
            FizzBuzzConverter converter = new FizzBuzzConverter();

           string returnedText = converter.CheckIfFizzOrBuzzOrFizzBuzz("", 15);

            Assert.AreEqual("FizzBuzz", returnedText);
        }

        [TestMethod]
        public void Test23Return23()
        {
            FizzBuzzConverter converter = new FizzBuzzConverter();

           string returnedText = converter.CheckIfFizzOrBuzzOrFizzBuzz("", 23);

            Assert.AreEqual("23", returnedText);
        }

        
    }
}
