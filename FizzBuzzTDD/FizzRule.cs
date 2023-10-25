namespace FizzBuzzTDD
{
    public class FizzRule : IRule
    {
        public bool Check(int number) => number % 3 == 0;
        public string Output() => "Fizz";
    }
}