﻿using BenchmarkDotNet.Attributes;

namespace Lib;


[MemoryDiagnoser]
public class Palindrom
{
    [Params("radar","dghjdshgkjsdhgshgdf45h45fh54f7ghdfhjgfhk,gfhk.hkldjhkljghhfgsksfgh.mfhsdfgh25422452hgfdshfm.hgfsksgfhhgjlkhjdlkh.khfg,khfgjhfdhg7f45hf54h54fdghsghdsjkghsdjhgd")]
    public string ToCheck { get; set; }

    [Benchmark(Baseline = true)]
    public bool IsPalindromLoopSpan()
    {
        var half = (int)Math.Floor(ToCheck.Length / 2d);
        var span = ToCheck.AsSpan();

        for (int i = 0; i < half; i++)
        {
            var l = span.Slice(i, 1);
            var r = span.Slice(ToCheck.Length - i - 1, 1);
            if (!MemoryExtensions.Equals(l, r, StringComparison.Ordinal)) return false;
        }


        return true;
    }

    [Benchmark]
    public bool IsPalindromLoopSubString()
    {
        var half = (int)Math.Floor(ToCheck.Length / 2d);

        for (int i = 0; i < half; i++)
        {
            var l = ToCheck.Substring(i, 1);
            var r = ToCheck.Substring(ToCheck.Length - i - 1, 1);
            if (l != r) return false;
        }


        return true;
    }

    [Benchmark]
    public bool IsPalindromReverseString()
    {
        var half = (int)Math.Floor(ToCheck.Length / 2d);

        var l = ToCheck.Substring(0, half);
        var list = ToCheck.Substring(half + ToCheck.Length % 2).Reverse();
        var r = new string(list.ToArray());
        if (l != r) return false;
            
        return true;
    }

    [Benchmark]
    public bool IsPalindromCheck_ByOlda_HashCode()
    {
        var s1 = ToCheck.GetHashCode();
        char[] charArray = ToCheck.ToCharArray();
        Array.Reverse(charArray);
        var s2 = new string(charArray).GetHashCode();
        return s1 == s2;
    }

    [Benchmark]
    public bool IsPalindromCheck_ByOlda_ForLoop()
    {
        for (int i = 0; i <= ToCheck.Length / 2; i++)
        {
            if (ToCheck[i] != ToCheck[^(i + 1)])
                return false;
        }
        return true;
    }

    [Benchmark]
    public bool IsPalindromCheck_ByRandomGuy_FullReverse()
    {
        return new string(ToCheck.Reverse().ToArray()).Equals(ToCheck, StringComparison.InvariantCulture);
    }
}