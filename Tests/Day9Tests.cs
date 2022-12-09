namespace Tests;

public class Day9Tests
{
    [Theory]
    [InlineData(1,2, 1,2, false)]
    [InlineData(1,3, 1,1, true)]
    [InlineData(4,2, 1,2, true)]
    [InlineData(1,2, 4,2, true)]
    [InlineData(1,2, 1,3, false)]
    [InlineData(1,2, 2,2, false)]
    public void Follower_DoINeed_ToMove(int headx, int heady, int tailx, int taily, bool expectedOutcome)
    {
        var doINeedToMove = Follower.DoINeedToMove((headx,heady), (tailx,taily));
        
        Assert.Equal(expectedOutcome, doINeedToMove);
    }

    [Theory]
    [InlineData(1, 3, 1, 1, 1, 2)]
    [InlineData(3, 2, 1, 2, 2, 2)]
    [InlineData(1, 2, 3, 3, 2, 2)]
    public void Follow_MoveTail(int headx, int heady, int tailx, int taily, int expectedX, int expectedY)
    {
        var move = Follower.MoveTail((headx, heady), (tailx, taily));
        
        Assert.Equal(expectedX, move.x);
        Assert.Equal(expectedY, move.y);

    }
}