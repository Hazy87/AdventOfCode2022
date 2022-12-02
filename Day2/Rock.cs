namespace Day2;

public class Rock : IMove
{
    public MoveType Move => MoveType.Rock;

    public int OutcomeofFight(MoveType opponentMove)
    {
        return opponentMove switch
        {
            MoveType.Scissors => 6,
            MoveType.Rock => 3,
            MoveType.Paper => 0,
            _ => throw new ArgumentOutOfRangeException(nameof(opponentMove), opponentMove, null)
        };
    }
}