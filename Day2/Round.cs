namespace Day2;

public class Round
{
    private readonly MoveType _opponentMoveType;
    private readonly Outcome _requiredOutcome;

    public Round(string opponentMove, string wantedOutcome)
    {
        _requiredOutcome = wantedOutcome switch
        {
            "X" => Outcome.Lose,
            "Y" => Outcome.Draw,
            "Z" => Outcome.Win,
            _ => _requiredOutcome
        };

        _opponentMoveType = opponentMove switch
        {
            "A" => MoveType.Rock,
            "B" => MoveType.Paper,
            "C" => MoveType.Scissors,
            _ => _opponentMoveType
        };
    }

    public int GetOutCome()
    {
        var score = 0;
        MoveType myMove = MoveType.Paper;
        if(OutcomeFinder.OutcomeFinderForMoves(MoveType.Paper, _opponentMoveType) == _requiredOutcome)
            myMove = MoveType.Paper;
        if(OutcomeFinder.OutcomeFinderForMoves(MoveType.Scissors, _opponentMoveType) == _requiredOutcome)
            myMove = MoveType.Scissors;
        if(OutcomeFinder.OutcomeFinderForMoves(MoveType.Rock, _opponentMoveType) == _requiredOutcome)
            myMove = MoveType.Rock;
        
        score += (int)OutcomeFinder.OutcomeFinderForMoves(myMove, _opponentMoveType);

        score += (int)myMove;
        return score;
    }
}

public enum Outcome
{
    Win = 6,
    Lose = 0,
    Draw = 3
}

public static class OutcomeFinder
{
     private static Dictionary<(MoveType move, MoveType opponent), Outcome> outcomes = new Dictionary<(MoveType move, MoveType opponent), Outcome>()
    {
        { (MoveType.Rock, MoveType.Rock), Outcome.Draw },
        { (MoveType.Rock, MoveType.Paper), Outcome.Lose },
        { (MoveType.Rock, MoveType.Scissors), Outcome.Win },
        { (MoveType.Paper, MoveType.Paper), Outcome.Draw },
        { (MoveType.Paper, MoveType.Rock), Outcome.Win },
        { (MoveType.Paper, MoveType.Scissors), Outcome.Lose },
        { (MoveType.Scissors, MoveType.Scissors), Outcome.Draw },
        { (MoveType.Scissors, MoveType.Rock), Outcome.Lose },
        { (MoveType.Scissors, MoveType.Paper), Outcome.Win }
    };
    public static Outcome OutcomeFinderForMoves(MoveType myMove, MoveType theirMove)
    {
        return outcomes[(myMove, theirMove)];
    }
}