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
            int total = puzzleInput.Sum(CalculateFuel);
            return total.ToString();
        }

        public override string GetPart2Answer()
        {
            int total = puzzleInput.Sum(CalculateFuelExtended);
            return total.ToString();
        }

        private int CalculateFuelExtended(int input)
        {
            int totalFuel = 0;
            int fuel = input;

            bool doLoop = true;
            do
            {
                int result = CalculateFuel(fuel);
                if (result > 0)
                {
                    totalFuel += result;
                    fuel = result;
                }
                else
                {
                    doLoop = false;
                }
            }
            while (doLoop);

            return totalFuel;
        }

        private int CalculateFuel(int input)
        {
            return input / 3 - 2;
        }
    }
}