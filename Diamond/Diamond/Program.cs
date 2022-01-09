using System;

namespace Diamond
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            var d = DiamondGenerator.CreateDiamond('C');
            Console.WriteLine(d);
        }
    }
}
