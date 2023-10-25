using FizzBuzzTDD;

namespace FizzBuzzTDDTest
{
    [TestClass]
    public class FizzBuzzTests
    {
        [TestMethod]
        [DataRow(1, "1")]
        public void NormalNumberReturnsNumber(int input, string expected)
        {
            var fizzBuzz = new FizzBuzz();

            var actual = fizzBuzz.Run(input);

            Assert.AreEqual(expected, actual);
        }
    }
}