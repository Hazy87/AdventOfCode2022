namespace Day5;

public class MoveParser
{
    public static List<Move> ParseMoves(List<string> moves)
    {
        return moves.Select(ParseMove).ToList();
    }
    public static Move ParseMove(string move)
    {
        //move 21 from 2 to 1
        var splitted = move.Replace("move", "-").Replace("from", "-").Replace("to", "-").Split("-").Where(x => !string.IsNullOrEmpty(x)).Select(x =>
        {
            return int.Parse(x.Trim());
        }).ToList();
        return new Move()
        {
            Destination = splitted[2],
            Source = splitted[1],
            ContainersToMove = splitted[0]
        };
    }
}