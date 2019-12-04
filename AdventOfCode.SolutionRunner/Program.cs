namespace AdventOfCode.SolutionRunner
{
    using System;
    using Solutions;

    internal class Program
    {
        private static void Main(string[] args)
        {
            var repository = new SolutionRepository();

            foreach (ISolution solution in repository.GetAllSolutions())
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