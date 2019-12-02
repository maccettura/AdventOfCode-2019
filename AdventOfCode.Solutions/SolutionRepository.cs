using System.Collections.Generic;
using System.Linq;

namespace AdventOfCode.Solutions
{
    public class SolutionRepository
    {
        public ISolution GetSolutionByDay(int day)
        {
            return GetAllSolutions().Single(x => x.Day == day);
        }

        public IEnumerable<ISolution> GetAllSolutions()
        {
            yield return new Day01.Solution();
            yield return new Day02.Solution();
            yield return new Day03.Solution();
            yield return new Day04.Solution();
            yield return new Day05.Solution();
            yield return new Day06.Solution();
            yield return new Day07.Solution();
            yield return new Day08.Solution();
            yield return new Day09.Solution();
            yield return new Day10.Solution();
            yield return new Day11.Solution();
            yield return new Day12.Solution();
            yield return new Day13.Solution();
            yield return new Day14.Solution();
            yield return new Day15.Solution();
            yield return new Day16.Solution();
            yield return new Day17.Solution();
            yield return new Day18.Solution();
            yield return new Day19.Solution();
            yield return new Day20.Solution();
            yield return new Day21.Solution();
            yield return new Day22.Solution();
            yield return new Day23.Solution();
            yield return new Day24.Solution();
            yield return new Day25.Solution();            
        }        
    }
}