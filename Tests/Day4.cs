using Day4;
using Assert = Xunit.Assert;

namespace Tests;

public class Day4
{
    [Theory]
    [InlineData("2-8","3-7")]
    public void RangeToBits_ShouldReturnCorrectBits(string range1, string range2)
    {
        var range1List = range1.Split("-").Select(x => int.Parse(x)).ToList();
        var range2List = range2.Split("-").Select(x => int.Parse(x)).ToList();
        var max = range1List.Max() > range2List.Max() ? range1List.Max() : range2List.Max();

        var bitsFromRange = RangeToBits.GetBitsFromRange(range1,range2);
        
        Assert.Equal("01111111", bitsFromRange.rangeoneBinary);
        
        Assert.Equal("00111110", bitsFromRange.rangetwoBinary);
    }

    [Theory]
    [InlineData("01111111","00111110", true)]
    [InlineData("01111111","10101110", false)]

    public void RangeToBits_CheckForContains(string binaryone, string binarytwo, bool expectedResult)
    {
        var checkForContaining = RangeToBits.CheckForContaining(binaryone, binarytwo);
        Assert.Equal(checkForContaining, expectedResult);
    }
}