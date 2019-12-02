namespace AdventOfCode.Solutions
{
    public interface ISolution
    {
        int Day { get; }

        string Title { get; }

        string GetPart1Answer();

        string GetPart2Answer();
    }
}