namespace FizzBuzzTDD
{
    public class FizzBuzz
    {
        public string Run(int number)
        {
            var result = string.Empty;

            var rules = new List<IRule>
            {
                new FizzRule(),
                new BuzzRule(),
            };

            foreach (var rule in rules)
            {
                if (rule.Check(number))
                {
                    result += rule.Output();
                }
            }

            return string.IsNullOrEmpty(result) ? number.ToString() : result;
        }
    }
}