using Xunit;

namespace Day2;

public class RoundTests
{
    [Theory]
    [InlineData("A", "Y", 4)]
    [InlineData("B", "X", 1)]
    [InlineData("C", "Z", 7)]
    public void Round_Gives_Correct_Outcome(string opponentMove, string myMove, int expectedScore)
    {
        var round = new Round(opponentMove, myMove);
        Assert.Equal(expectedScore, round.GetOutCome());
    }
}