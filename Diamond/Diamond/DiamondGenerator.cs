using System;
using System.Text;

namespace Diamond
{
    public static class DiamondGenerator
    {
        /// <param name="diamondType">A-Z</param>
        public static string CreateDiamond(char diamondType)
        {
            const char startChar = 'A';
            var c = diamondType.ToString().ToUpper()[0];

            var sb = new StringBuilder();
            var maxPadding = c - startChar;
            for (int i = c; i >= startChar; i--)
            {
                var line = GenerateLine(c, (char)i, maxPadding);
                if (i != c)
                {
                    sb.Insert(0, line + Environment.NewLine);
                }

                if (i != startChar)
                {
                    sb.AppendLine(line);
                }
                else
                {
                    sb.Append(line); 
                }
            }

            return sb.ToString();
        }

        private static string GenerateLine(char middle, char current, int maxPadding)
        {
            var diffToCenter = middle - current;
            var sb = new StringBuilder();
            sb.Append(string.Empty.PadLeft(diffToCenter));
            sb.Append(current);

            var gap = (maxPadding - diffToCenter) * 2 - 1;
            if (gap > 0)
            {
                sb.Append(string.Empty.PadRight(gap));
                sb.Append(current);
            }


            return sb.ToString();
        }
    }
}