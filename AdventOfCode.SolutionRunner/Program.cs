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
                if (!string.IsNullOrWhiteSpace(solution.Title))
                {
                    Console.WriteLine($"Day {solution.Day} | {solution.Title}");
                    Console.WriteLine($"Solution Part 1: {solution.GetPart1Answer()}");
                    Console.WriteLine($"Solution Part 2: {solution.GetPart2Answer()}");
                }
            }

            Console.ReadLine();
        }
    }
}