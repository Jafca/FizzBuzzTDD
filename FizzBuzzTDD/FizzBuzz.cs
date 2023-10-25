using System.Reflection;

namespace FizzBuzzTDD
{
    public class FizzBuzz
    {
        public string Run(int number)
        {
            var result = string.Empty;
            var rules = new List<IRule>();

            var ruleTypes = Assembly.GetExecutingAssembly().GetTypes()
                .Where(type => typeof(IRule).IsAssignableFrom(type) && !type.IsInterface && !type.IsAbstract);

            foreach (var type in ruleTypes)
            {
                var instance = Activator.CreateInstance(type);
                if (instance != null)
                {
                    rules.Add((IRule)instance);
                }
            }

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