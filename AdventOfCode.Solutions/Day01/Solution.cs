namespace AdventOfCode.Solutions.Day01
{
    using System;
    using System.Linq;

    public class Solution : BaseSolution
    {
        private readonly int[] puzzleInput;

        public Solution() : base(1, "The Tyranny of the Rocket Equation")
        {
            puzzleInput = GetResourceString().Split(new char[0], StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
        }

        public override string GetPart1Answer()
        {
            int total = puzzleInput.Sum(FuelCalculation);
            return total.ToString();
        }

        public override string GetPart2Answer()
        {
            int total = puzzleInput.Sum(ExtendedFuelCalculation);
            return total.ToString();
        }

        private int ExtendedFuelCalculation(int input)
        {
            int fuel = FuelCalculation(input);

            if (fuel <= 0)
            {
                return 0;
            }
            else
            {
                return fuel + ExtendedFuelCalculation(fuel);
            }
        }

        private int FuelCalculation(int input)
        {
            return input / 3 - 2;
        }
    }
}