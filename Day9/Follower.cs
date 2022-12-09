public class Follower
{
    public static bool DoINeedToMove((int x, int y) head, (int x, int y) tail)
    {
        var headX = Math.Abs(head.x - tail.x);
        var headY = Math.Abs(head.y - tail.y);
        if(headX <=1 && headY <=1)
            return false;
        return true;
    }

    public static ((int x, int y) headposition, (int x, int y) tailposition) MoveHead(string direction, int spacesMoved, (int x, int y) headposition, (int x, int y) tailposition)
    {
        for (int i = 0; i < spacesMoved; i++)
        {
            headposition = MoveHead(direction, 1, headposition);
            if(DoINeedToMove(headposition, tailposition))
                tailposition = MoveTail(headposition, tailposition);
        }

        return (headposition, tailposition);
    }

    private static (int x, int y) MoveHead(string direction, int spacesMoved, (int x, int y) headposition)
    {
        if (direction == "R")
            headposition.y += spacesMoved;
        if (direction == "L")
            headposition.y -= spacesMoved;
        if (direction == "U")
            headposition.x += spacesMoved;
        if (direction == "D")
            headposition.x -= spacesMoved;
        return headposition;
    }

    public static (int x, int y) MoveTail((int x, int y) head, (int x, int y) tail)
    {
        var resultx = Resultx(head.x, tail.x);
        var resulty = Resultx(head.y, tail.y);
        positions.Add($"{resultx}--{resulty}");
        return (resultx,resulty);
    }

    public static List<string> positions = new();

    private static int Resultx(int head, int tail)
    {
        int result = tail;
        if (Math.Abs(head - tail) >= 1)
        {
            if (Math.Abs(head - tail) == head - tail)
                result = tail + 1;
            else
            {
                result = tail - 1;
            }
        }

        return result;
    }
}