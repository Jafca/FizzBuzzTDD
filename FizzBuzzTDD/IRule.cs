namespace FizzBuzzTDD
{
    public interface IRule
    {
        bool Check(int number);
        string Output();
    }
}