using FizzBuzzTDD;

namespace FizzBuzzTDDTest
{
    [TestClass]
    public class FizzBuzzTests
    {
        [TestMethod]
        [DataRow(1, "1")]
        [DataRow(2, "2")]
        public void NormalNumberReturnsNumber(int input, string expected)
        {
            var fizzBuzz = new FizzBuzz();

            var actual = fizzBuzz.Run(input);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [DataRow(3, "Fizz")]
        public void Number3ReturnsFizz(int input, string expected)
        {
            var fizzBuzz = new FizzBuzz();

            var actual = fizzBuzz.Run(input);

            Assert.AreEqual(expected, actual);
        }
    }
}