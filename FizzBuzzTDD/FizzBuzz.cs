namespace FizzBuzzTDD
{
    public class FizzBuzz
    {
        public string Run(int number)
        {
            if (number % 3 == 0)
                return "Fizz";

            if (number % 5 == 0)
                return "Buzz";

            return number.ToString();
        }
    }
}