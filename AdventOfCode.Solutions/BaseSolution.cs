using System.Text;
using AdventOfCode.Solutions.Properties;

namespace AdventOfCode.Solutions
{
    public abstract class BaseSolution : ISolution
    {
        protected BaseSolution(int day, string title)
        {
            Day = day;
            Title = title;
        }

        public int Day { get; }
        public string Title { get; }

        public override string ToString()
        {
            var sb = new StringBuilder();

            sb.AppendLine($"Day {Day} | {Title}");
            sb.AppendLine($"Solution Part 1: {GetPart1Answer()}");
            sb.AppendLine($"Solution Part 2: {GetPart2Answer()}");

            return sb.ToString();
        }

        public abstract string GetPart1Answer();

        public abstract string GetPart2Answer();

        protected string GetResourceString() => Resources.ResourceManager.GetString($"Day{Day.ToString("D2")}");
    }
}