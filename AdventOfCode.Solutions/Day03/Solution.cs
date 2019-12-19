using System;
using System.Collections.Generic;
using System.Numerics;

namespace AdventOfCode.Solutions.Day03
{
    public class Solution : BaseSolution
    {
        private List<string[]> wireDirections;

        public Solution() : base(3, "Crossed Wires")
        {
            //var wires = GetResourceString().Split(new char[0], StringSplitOptions.RemoveEmptyEntries);
            //foreach (var wire in wires)
            //{
            //    wireDirections.Add(wire.Split(','));
            //}
        }

        public override string GetPart1Answer()
        {
            return string.Empty;
        }

        public override string GetPart2Answer()
        {
            return string.Empty;
        }

        private static Vector2 GetNextPoint(Vector2 start, string direction)
        {
            if (!int.TryParse(direction[1..^0], out int steps))
            {
                throw new ArgumentException("Not a valid integer", nameof(direction));
            }

            return (direction[0]) switch
            {
                'R' => new Vector2(start.X + steps, start.Y),
                'D' => new Vector2(start.X, start.Y - steps),
                'L' => new Vector2(start.X - steps, start.Y),
                'U' => new Vector2(start.X, start.Y + steps),
                _ => throw new ArgumentOutOfRangeException("Not a valid direction string", nameof(direction)),
            };
        }

        private static Vector2 NavigateToNextPoint(int startX, int startY, string directionString)
        {
            if (!int.TryParse(directionString[1..^0], out int steps))
            {
                throw new ArgumentException("Not a valid integer", nameof(directionString));
            }

            return (directionString[0]) switch
            {
                'R' => new Vector2(startX + steps, startY),
                'D' => new Vector2(startX, startY - steps),
                'L' => new Vector2(startX - steps, startY),
                'U' => new Vector2(startX, startY + steps),
                _ => throw new ArgumentOutOfRangeException("Not a valid direction string", nameof(directionString)),
            };
        }

        private static bool DoLinesIntersect(Vector2 line1a, Vector2 line1b, Vector2 line2a, Vector2 line2b, out Vector2? intersection)
        {
            //Line1
            float A1 = line1b.Y - line1a.Y;
            float B1 = line1b.X - line1a.X;
            float C1 = A1 * line1a.X + B1 * line1a.Y;

            //Line2
            float A2 = line2b.Y - line2a.Y;
            float B2 = line2b.X - line2a.X;
            float C2 = A2 * line2a.X + B2 * line2a.Y;

            float det = A1 * B2 - A2 * B1;
            if (det == 0)
            {
                intersection = null;
                return false;
            }
            else
            {
                float x = (B2 * C1 - B1 * C2) / det;
                float y = (A1 * C2 - A2 * C1) / det;
                intersection = new Vector2(x, y);
                return true;
            }
        }
    }
}