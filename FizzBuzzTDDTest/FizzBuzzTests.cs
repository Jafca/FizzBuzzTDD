using FizzBuzzTDD;

namespace FizzBuzzTDDTest
{
    [TestClass]
    public class FizzBuzzTests
    {
        [TestMethod]
        [DataRow(1)]
        [DataRow(2)]
        [DataRow(98)]
        public void NormalNumberReturnsNumber(int input)
        {
            var fizzBuzz = new FizzBuzz();
            var expected = input.ToString();

            var actual = fizzBuzz.Run(input);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [DataRow(3)]
        [DataRow(66)]
        public void MultipleOf3ReturnsFizz(int input)
        {
            var fizzBuzz = new FizzBuzz();
            var expected = "Fizz";

            var actual = fizzBuzz.Run(input);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [DataRow(5)]
        [DataRow(55)]
        public void MultipleOf5ReturnsBuzz(int input)
        {
            var fizzBuzz = new FizzBuzz();
            var expected = "Buzz";

            var actual = fizzBuzz.Run(input);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [DataRow(15)]
        [DataRow(90)]
        public void MultipleOf15ReturnsFizzBuzz(int input)
        {
            var fizzBuzz = new FizzBuzz();
            var expected = "FizzBuzz";

            var actual = fizzBuzz.Run(input);

            Assert.AreEqual(expected, actual);
        }
    }
}