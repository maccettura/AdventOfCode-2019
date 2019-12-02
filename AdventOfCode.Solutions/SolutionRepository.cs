namespace AdventOfCode.Solutions
{
    using System.Collections.Generic;

    public class SolutionRepository
    {
        private static readonly List<ISolution> AllSolutions = new List<ISolution>()
        {
            new Day01.Solution(),
            new Day02.Solution(),
            new Day03.Solution(),
            new Day04.Solution(),
            new Day05.Solution(),
            new Day06.Solution(),
            new Day07.Solution(),
            new Day08.Solution(),
            new Day09.Solution(),
            new Day10.Solution(),
            new Day11.Solution(),
            new Day12.Solution(),
            new Day13.Solution(),
            new Day14.Solution(),
            new Day15.Solution(),
            new Day16.Solution(),
            new Day17.Solution(),
            new Day18.Solution(),
            new Day19.Solution(),
            new Day20.Solution(),
            new Day21.Solution(),
            new Day22.Solution(),
            new Day23.Solution(),
            new Day24.Solution(),
            new Day25.Solution(),
        };

        public ISolution GetSolutionByDay(int day)
        {
            return AllSolutions[day - 1];
        }

        public List<ISolution> GetAllSolutions()
        {
            return AllSolutions;
        }
    }
}