using Lib;
using Xunit;
using Assert = Xunit.Assert;

namespace Tests;

public class PalindromTests
{
    [Theory]
    [InlineData("radar")]
    [InlineData("dghjdshgkjsdhgshgdf45h45fh54f7ghdfhjgfhk,gfhk.hkldjhkljghhfgsksfgh.mfhsdfgh25422452hgfdshfm.hgfsksgfhhgjlkhjdlkh.khfg,khfgjhfdhg7f45hf54h54fdghsghdsjkghsdjhgd")]
    public void IsPalindromTest(string s)
    {
        var c = new Palindrom { ToCheck = s };
        Assert.True(c.IsPalindromLoopSpan());
    }

    [Theory]
    [InlineData("radar2")]
    [InlineData("rad2ar")]
    [InlineData("dghjdshgkjsdhgshgdf45h45fh54f7ghdfhjgfhk,gfhk_hkldjhkljghhfgsksfgh.mfhsdfgh25422452hgfdshfm.hgfsksgfhhgjlkhjdlkh.khfg,khfgjhfdhg7f45hf54h54fdghsghdsjkghsdjhgd")]
    public void IsNotPalindromTest(string s)
    {
        var c = new Palindrom { ToCheck = s };
        Assert.False(c.IsPalindromLoopSpan());
    }

    [Theory]
    [InlineData("radar")]
    [InlineData("dghjdshgkjsdhgshgdf45h45fh54f7ghdfhjgfhk,gfhk.hkldjhkljghhfgsksfgh.mfhsdfgh25422452hgfdshfm.hgfsksgfhhgjlkhjdlkh.khfg,khfgjhfdhg7f45hf54h54fdghsghdsjkghsdjhgd")]
    public void IsPalindromLoopSubStringTest(string s)
    {
        var c = new Palindrom { ToCheck = s };
        Assert.True(c.IsPalindromLoopSubString());
    }

    [Theory]
    [InlineData("radar2")]
    [InlineData("rad2ar")]
    [InlineData("dghjdshgkjsdhgshgdf45h45fh54f7ghdfhjgfhk,gfhk_hkldjhkljghhfgsksfgh.mfhsdfgh25422452hgfdshfm.hgfsksgfhhgjlkhjdlkh.khfg,khfgjhfdhg7f45hf54h54fdghsghdsjkghsdjhgd")]
    public void IsNotPalindromLoopSubStringTest(string s)
    {
        var c = new Palindrom { ToCheck = s };
        Assert.False(c.IsPalindromLoopSubString());
    }


    [Theory]
    [InlineData("radar")]
    [InlineData("dghjdshgkjsdhgshgdf45h45fh54f7ghdfhjgfhk,gfhk.hkldjhkljghhfgsksfgh.mfhsdfgh25422452hgfdshfm.hgfsksgfhhgjlkhjdlkh.khfg,khfgjhfdhg7f45hf54h54fdghsghdsjkghsdjhgd")]
    public void IsPalindromReverseStringTest(string s)
    {
        var c = new Palindrom { ToCheck = s };
        Assert.True(c.IsPalindromReverseString());
    }

    [Theory]
    [InlineData("radar2")]
    [InlineData("rad2ar")]
    [InlineData("dghjdshgkjsdhgshgdf45h45fh54f7ghdfhjgfhk,gfhk_hkldjhkljghhfgsksfgh.mfhsdfgh25422452hgfdshfm.hgfsksgfhhgjlkhjdlkh.khfg,khfgjhfdhg7f45hf54h54fdghsghdsjkghsdjhgd")]
    public void IsNotPalindromReverseString(string s)
    {
        var c = new Palindrom { ToCheck = s };
        Assert.False(c.IsPalindromLoopSpan());
    }

    [Theory]
    [InlineData("radar")]
    [InlineData("dghjdshgkjsdhgshgdf45h45fh54f7ghdfhjgfhk,gfhk.hkldjhkljghhfgsksfgh.mfhsdfgh25422452hgfdshfm.hgfsksgfhhgjlkhjdlkh.khfg,khfgjhfdhg7f45hf54h54fdghsghdsjkghsdjhgd")]
    public void IsPalindromCheck_ByOlda_ForLoop(string s)
    {
        var c = new Palindrom { ToCheck = s };
        Assert.True(c.IsPalindromCheck_ByOlda_ForLoop());
    }

    [Theory]
    [InlineData("radar2")]
    [InlineData("rad2ar")]
    [InlineData("dghjdshgkjsdhgshgdf45h45fh54f7ghdfhjgfhk,gfhk_hkldjhkljghhfgsksfgh.mfhsdfgh25422452hgfdshfm.hgfsksgfhhgjlkhjdlkh.khfg,khfgjhfdhg7f45hf54h54fdghsghdsjkghsdjhgd")]
    public void IsNotPalindromCheck_ByOlda_ForLoop(string s)
    {
        var c = new Palindrom { ToCheck = s };
        Assert.False(c.IsPalindromCheck_ByOlda_ForLoop());
    }



    [Theory]
    [InlineData("radar")]
    [InlineData("dghjdshgkjsdhgshgdf45h45fh54f7ghdfhjgfhk,gfhk.hkldjhkljghhfgsksfgh.mfhsdfgh25422452hgfdshfm.hgfsksgfhhgjlkhjdlkh.khfg,khfgjhfdhg7f45hf54h54fdghsghdsjkghsdjhgd")]
    public void IsPalindromCheck_ByOlda_HashCode(string s)
    {
        var c = new Palindrom { ToCheck = s };
        Assert.True(c.IsPalindromCheck_ByOlda_HashCode());
    }

    [Theory]
    [InlineData("radar2")]
    [InlineData("rad2ar")]
    [InlineData("dghjdshgkjsdhgshgdf45h45fh54f7ghdfhjgfhk,gfhk_hkldjhkljghhfgsksfgh.mfhsdfgh25422452hgfdshfm.hgfsksgfhhgjlkhjdlkh.khfg,khfgjhfdhg7f45hf54h54fdghsghdsjkghsdjhgd")]
    public void IsNotPalindromCheck_ByOlda_HashCode(string s)
    {
        var c = new Palindrom { ToCheck = s };
        Assert.False(c.IsPalindromCheck_ByOlda_HashCode());
    }

    

    [Theory]
    [InlineData("radar")]
    [InlineData("dghjdshgkjsdhgshgdf45h45fh54f7ghdfhjgfhk,gfhk.hkldjhkljghhfgsksfgh.mfhsdfgh25422452hgfdshfm.hgfsksgfhhgjlkhjdlkh.khfg,khfgjhfdhg7f45hf54h54fdghsghdsjkghsdjhgd")]
    public void IsPalindromCheck_ByRandomGuy_FullReverse(string s)
    {
        var c = new Palindrom { ToCheck = s };
        Assert.True(c.IsPalindromCheck_ByRandomGuy_FullReverse());
    }

    [Theory]
    [InlineData("radar2")]
    [InlineData("rad2ar")]
    [InlineData("dghjdshgkjsdhgshgdf45h45fh54f7ghdfhjgfhk,gfhk_hkldjhkljghhfgsksfgh.mfhsdfgh25422452hgfdshfm.hgfsksgfhhgjlkhjdlkh.khfg,khfgjhfdhg7f45hf54h54fdghsghdsjkghsdjhgd")]
    public void IsNotPalindromCheck_ByRandomGuy_FullReverse(string s)
    {
        var c = new Palindrom { ToCheck = s };
        Assert.False(c.IsPalindromCheck_ByRandomGuy_FullReverse());
    }
}
