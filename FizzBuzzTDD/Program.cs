namespace FizzBuzzTDD
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var fizzBuzz = new FizzBuzz();
            fizzBuzz.RunRange(1, 100);
        }
    }
}