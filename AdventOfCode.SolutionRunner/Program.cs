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
                    Console.WriteLine(solution);
                }
            }

            Console.ReadLine();
        }
    }
}