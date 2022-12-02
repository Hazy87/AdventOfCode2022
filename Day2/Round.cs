namespace Day2;

public class Round
{
    private readonly IMove? _opponentMoveType;
    private readonly IMove? _myMoveType;

    public Round(string opponentMove, string myMove)
    {
        _myMoveType = myMove switch
        {
            "X" => new Rock(),
            "Y" => new Paper(),
            "Z" => new Scissors(),
            _ => _myMoveType
        };

        _opponentMoveType = opponentMove switch
        {
            "A" => new Rock(),
            "B" => new Paper(),
            "C" => new Scissors(),
            _ => _opponentMoveType
        };
    }

    public int GetOutCome()
    {
        var score = 0;
        score += _myMoveType.Move switch
        {
            MoveType.Rock => 1,
            MoveType.Paper => 2,
            MoveType.Scissors => 3,
            _ => throw new ArgumentOutOfRangeException()
        };
        score += _myMoveType.OutcomeofFight(_opponentMoveType.Move);
        return score;
    }
}