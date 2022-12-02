namespace Day2;

public class Paper : IMove
{
    public MoveType Move => MoveType.Paper;

    public int OutcomeofFight(MoveType opponentMove)
    {
        return opponentMove switch
        {
            MoveType.Scissors => 0,
            MoveType.Rock => 6,
            MoveType.Paper => 3,
            _ => throw new ArgumentOutOfRangeException(nameof(opponentMove), opponentMove, null)
        };
    }
}