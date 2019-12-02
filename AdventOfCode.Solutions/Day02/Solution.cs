namespace AdventOfCode.Solutions.Day02
{
    using System;
    using System.Collections.Generic;

    public class Solution : BaseSolution
    {
        private int[] puzzleInput;

        public Solution() : base(2, "1202 Program Alarm")
        {
            // This code is very verbose to try and figure out the issue
            List<int> list = new List<int>();
            foreach (var s in GetResourceString().Split(','))
            {
                if (!int.TryParse(s, out int foo))
                {
                    Console.WriteLine("Whoops");
                }
                else
                {
                    list.Add(foo);
                }
            }

            // 'list' is correct before running .ToArray(), after running .ToArray() it seems like all the other code runs even if breakpoints are set there
            puzzleInput = list.ToArray();
        }

        public override string GetPart1Answer()
        {
            puzzleInput[1] = 12;
            puzzleInput[2] = 2;
            RunProgram();
            return puzzleInput[0].ToString();
        }

        public override string GetPart2Answer()
        {
            return string.Empty;
        }

        private void RunProgram()
        {
            int index = 0;
            do
            {
                int val = puzzleInput[index];

                switch (val)
                {
                    case 1:
                        RunOpCode(index, (x, y) => x + y);
                        break;

                    case 2:
                        RunOpCode(index, (x, y) => x * y);
                        break;

                    case 99:
                        return;

                    default:
                        throw new Exception();
                }

                index += 4;
            }
            while (true);
        }

        private void RunOpCode(int index, Func<int, int, int> func)
        {
            var range = puzzleInput[new Range(index + 1, index + 3)];

            int result = func(puzzleInput[range[0]], puzzleInput[range[1]]);

            int outputIndex = puzzleInput[index + 3];

            puzzleInput[outputIndex] = result;
        }
    }
}