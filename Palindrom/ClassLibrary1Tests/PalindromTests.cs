using Lib;
using Xunit;
using Assert = Xunit.Assert;

namespace Tests;

public class PalindromeTests
{
    [Theory]
    [InlineData("radar")]
    [InlineData("dghjdshgkjsdhgshgdf45h45fh54f7ghdfhjgfhk,gfhk.hkldjhkljghhfgsksfgh.mfhsdfgh25422452hgfdshfm.hgfsksgfhhgjlkhjdlkh.khfg,khfgjhfdhg7f45hf54h54fdghsghdsjkghsdjhgd")]
    public void IsPalindrome_LoopSpan(string s)
    {
        var c = new Palindrome { ToCheck = s };
        Assert.True(c.IsPalindrome_LoopSpan());
    }

    [Theory]
    [InlineData("radar2")]
    [InlineData("rad2ar")]
    [InlineData("dghjdshgkjsdhgshgdf45h45fh54f7ghdfhjgfhk,gfhk_hkldjhkljghhfgsksfgh.mfhsdfgh25422452hgfdshfm.hgfsksgfhhgjlkhjdlkh.khfg,khfgjhfdhg7f45hf54h54fdghsghdsjkghsdjhgd")]
    public void IsNotPalindrome_LoopSpan(string s)
    {
        var c = new Palindrome { ToCheck = s };
        Assert.False(c.IsPalindrome_LoopSpan());
    }

    [Theory]
    [InlineData("radar")]
    [InlineData("dghjdshgkjsdhgshgdf45h45fh54f7ghdfhjgfhk,gfhk.hkldjhkljghhfgsksfgh.mfhsdfgh25422452hgfdshfm.hgfsksgfhhgjlkhjdlkh.khfg,khfgjhfdhg7f45hf54h54fdghsghdsjkghsdjhgd")]
    public void IsPalindrome_LoopSubString(string s)
    {
        var c = new Palindrome { ToCheck = s };
        Assert.True(c.IsPalindrome_LoopSubString());
    }

    [Theory]
    [InlineData("radar2")]
    [InlineData("rad2ar")]
    [InlineData("dghjdshgkjsdhgshgdf45h45fh54f7ghdfhjgfhk,gfhk_hkldjhkljghhfgsksfgh.mfhsdfgh25422452hgfdshfm.hgfsksgfhhgjlkhjdlkh.khfg,khfgjhfdhg7f45hf54h54fdghsghdsjkghsdjhgd")]
    public void IsNotPalindrome_LoopSubString(string s)
    {
        var c = new Palindrome { ToCheck = s };
        Assert.False(c.IsPalindrome_LoopSubString());
    }

    [Theory]
    [InlineData("radar")]
    [InlineData("dghjdshgkjsdhgshgdf45h45fh54f7ghdfhjgfhk,gfhk.hkldjhkljghhfgsksfgh.mfhsdfgh25422452hgfdshfm.hgfsksgfhhgjlkhjdlkh.khfg,khfgjhfdhg7f45hf54h54fdghsghdsjkghsdjhgd")]
    public void IsPalindrome_HalfReverseSubstr(string s)
    {
        var c = new Palindrome { ToCheck = s };
        Assert.True(c.IsPalindrome_HalfReverseSubstr());
    }

    [Theory]
    [InlineData("radar2")]
    [InlineData("rad2ar")]
    [InlineData("dghjdshgkjsdhgshgdf45h45fh54f7ghdfhjgfhk,gfhk_hkldjhkljghhfgsksfgh.mfhsdfgh25422452hgfdshfm.hgfsksgfhhgjlkhjdlkh.khfg,khfgjhfdhg7f45hf54h54fdghsghdsjkghsdjhgd")]
    public void IsNotPalindrome_HalfReverseSubstr(string s)
    {
        var c = new Palindrome { ToCheck = s };
        Assert.False(c.IsPalindrome_HalfReverseSubstr());
    }

    [Theory]
    [InlineData("radar")]
    [InlineData("dghjdshgkjsdhgshgdf45h45fh54f7ghdfhjgfhk,gfhk.hkldjhkljghhfgsksfgh.mfhsdfgh25422452hgfdshfm.hgfsksgfhhgjlkhjdlkh.khfg,khfgjhfdhg7f45hf54h54fdghsghdsjkghsdjhgd")]
    public void IsPalindrome_ForLoop(string s)
    {
        var c = new Palindrome { ToCheck = s };
        Assert.True(c.IsPalindrome_ForLoop());
    }

    [Theory]
    [InlineData("radar2")]
    [InlineData("rad2ar")]
    [InlineData("dghjdshgkjsdhgshgdf45h45fh54f7ghdfhjgfhk,gfhk_hkldjhkljghhfgsksfgh.mfhsdfgh25422452hgfdshfm.hgfsksgfhhgjlkhjdlkh.khfg,khfgjhfdhg7f45hf54h54fdghsghdsjkghsdjhgd")]
    public void IsNotPalindrome_ForLoop(string s)
    {
        var c = new Palindrome { ToCheck = s };
        Assert.False(c.IsPalindrome_ForLoop());
    }
    

    [Theory]
    [InlineData("radar")]
    [InlineData("dghjdshgkjsdhgshgdf45h45fh54f7ghdfhjgfhk,gfhk.hkldjhkljghhfgsksfgh.mfhsdfgh25422452hgfdshfm.hgfsksgfhhgjlkhjdlkh.khfg,khfgjhfdhg7f45hf54h54fdghsghdsjkghsdjhgd")]
    public void IsPalindrome_HashCode(string s)
    {
        var c = new Palindrome { ToCheck = s };
        Assert.True(c.IsPalindrome_HashCode());
    }

    [Theory]
    [InlineData("radar2")]
    [InlineData("rad2ar")]
    [InlineData("dghjdshgkjsdhgshgdf45h45fh54f7ghdfhjgfhk,gfhk_hkldjhkljghhfgsksfgh.mfhsdfgh25422452hgfdshfm.hgfsksgfhhgjlkhjdlkh.khfg,khfgjhfdhg7f45hf54h54fdghsghdsjkghsdjhgd")]
    public void IsNotPalindrome_HashCode(string s)
    {
        var c = new Palindrome { ToCheck = s };
        Assert.False(c.IsPalindrome_HashCode());
    }

    [Theory]
    [InlineData("radar")]
    [InlineData("dghjdshgkjsdhgshgdf45h45fh54f7ghdfhjgfhk,gfhk.hkldjhkljghhfgsksfgh.mfhsdfgh25422452hgfdshfm.hgfsksgfhhgjlkhjdlkh.khfg,khfgjhfdhg7f45hf54h54fdghsghdsjkghsdjhgd")]
    public void IsPalindrome_FullReverse(string s)
    {
        var c = new Palindrome { ToCheck = s };
        Assert.True(c.IsPalindrome_FullReverse());
    }

    [Theory]
    [InlineData("radar2")]
    [InlineData("rad2ar")]
    [InlineData("dghjdshgkjsdhgshgdf45h45fh54f7ghdfhjgfhk,gfhk_hkldjhkljghhfgsksfgh.mfhsdfgh25422452hgfdshfm.hgfsksgfhhgjlkhjdlkh.khfg,khfgjhfdhg7f45hf54h54fdghsghdsjkghsdjhgd")]
    public void IsNotPalindrome_FullReverse(string s)
    {
        var c = new Palindrome { ToCheck = s };
        Assert.False(c.IsPalindrome_FullReverse());
    }
}
