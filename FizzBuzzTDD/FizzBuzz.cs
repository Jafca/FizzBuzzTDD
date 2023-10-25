namespace FizzBuzzTDD
{
    public class FizzBuzz
    {
        public string Run(int number)
        {
            if (number % 3 == 0)
                return "Fizz";

            return number.ToString();
        }
    }
}