using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace AdventOfCode.Solutions.Day04
{
    public class Solution : BaseSolution
    {
        private const int lowerBound = 183564;

        private const int upperBound = 657474;

        private static readonly Regex regex = new Regex("([0-9])\\1{1,}");

        public Solution() : base(4, "Secure Container")
        {
        }

        public override string GetPart1Answer()
        {
            var rules = new Func<string, bool>[] { HasIncreasingDigits, HasRepeating };
            return GetPossiblePasswords(rules).Count().ToString();
        }

        public override string GetPart2Answer()
        {
            var rules = new Func<string, bool>[] { HasIncreasingDigits, HasExactlyTwoRepeating };
            return GetPossiblePasswords(rules).Count().ToString();
        }

        private static bool HasRepeating(string input)
        {
            return regex.IsMatch(input);
        }

        private static bool HasExactlyTwoRepeating(string input)
        {
            var result = regex.Matches(input);

            return result.Any(x => x.Value.Length == 2);
        }

        private static bool HasIncreasingDigits(string input)
        {
            return new string(input.OrderBy(x => x).ToArray()) == input;
        }

        private IEnumerable<int> GetPossiblePasswords(Func<string, bool>[] rules)
        {
            for (int pass = lowerBound; pass <= upperBound; pass++)
            {
                string asString = pass.ToString();

                if (rules.All(x => x(asString)))
                {
                    yield return pass;
                }
                else
                {
                    continue;
                }
            }
        }
    }
}