namespace AdventOfCode.Solutions.Day02
{
    using System;
    using System.Linq;

    public class Solution : BaseSolution
    {
        public Solution() : base(2, "1202 Program Alarm")
        {
        }

        public override string GetPart1Answer()
        {
            return RunProgram(12, 2).ToString();
        }

        public override string GetPart2Answer()
        {
            for (int noun = 0; noun < 99; noun++)
            {
                for (int verb = 0; verb < 99; verb++)
                {
                    if (RunProgram(noun, verb) == 19690720)
                    {
                        return $"{100 * noun + verb}";
                    }
                }
            }
            return string.Empty;
        }

        private int RunProgram(int noun, int verb)
        {
            var puzzleInput = GetResourceString().Split(',').Select(int.Parse).ToArray();
            puzzleInput[1] = noun;
            puzzleInput[2] = verb;

            int index = 0;
            int opCode = 0;

            do
            {
                opCode = puzzleInput[index];

                switch (opCode)
                {
                    case 1:
                        RunOpCode(puzzleInput, index, (x, y) => x + y);
                        break;

                    case 2:
                        RunOpCode(puzzleInput, index, (x, y) => x * y);
                        break;

                    case 99:
                        break;

                    default:
                        throw new Exception("Unexpected OpCode found");
                }

                index += 4;
            }
            while (opCode != 99);

            return puzzleInput[0];
        }

        private void RunOpCode(int[] puzzleInput, int index, Func<int, int, int> func)
        {
            var range = puzzleInput[new Range(index + 1, index + 3)];

            int result = func(puzzleInput[range[0]], puzzleInput[range[1]]);

            int outputIndex = puzzleInput[index + 3];

            puzzleInput[outputIndex] = result;
        }
    }
}