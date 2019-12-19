using System;
using AdventOfCode.Solutions;

namespace AdventOfCode.SolutionRunner
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            foreach (ISolution solution in SolutionRepository.GetAllSolutions())
            {
                try
                {
                    if (!string.IsNullOrWhiteSpace(solution.Title))
                    {
                        Console.WriteLine($"Day {solution.Day,2} | \"{solution.Title}\"");
                        Console.WriteLine($"- Solution Part 1: {solution.GetPart1Answer()}");
                        Console.WriteLine($"- Solution Part 2: {solution.GetPart2Answer()}");
                    }
                }
                catch (NotImplementedException)
                {
                    continue;
                }
            }
            Console.ReadLine();
        }
    }
}