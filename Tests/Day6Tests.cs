using Day6;

namespace Tests;

public class Day6Tests
{
    [Theory]
    [InlineData("bvwbjplbgvbhsrlpgdmjqwftvncz", 5)]
    [InlineData("nppdvjthqldpwncqszvftbrmjlhg", 6)]
    [InlineData("nznrnfrfntjfmvfwmzdfjlvtqnbhcprsg", 10)]
    public void MarkerFinder_FindsMarker(string message, int expectedMarker)
    {
        var markerFinder = MarkerFinder.FindMarker(message, 4);
        Assert.Equal(expectedMarker, markerFinder);
    }
}