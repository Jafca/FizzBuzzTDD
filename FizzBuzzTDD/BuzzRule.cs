namespace FizzBuzzTDD
{
    public class BuzzRule : IRule
    {
        public bool Check(int number) => number % 5 == 0;
        public string Output() => "Buzz";
        public int GetPriority() => 5;
    }
}