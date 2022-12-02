namespace Day2;

public class Scissors : IMove
{
    public MoveType Move => MoveType.Scissors;

    public int OutcomeofFight(MoveType opponentMove)
    {
        return opponentMove switch
        {
            MoveType.Scissors => 3,
            MoveType.Rock => 0,
            MoveType.Paper => 6,
            _ => throw new ArgumentOutOfRangeException(nameof(opponentMove), opponentMove, null)
        };
    }
}