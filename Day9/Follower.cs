public class Follower
{
    public static bool DoINeedToMove(Knot head, Knot tail)
    {
        var headX = Math.Abs(head.x - tail.x);
        var headY = Math.Abs(head.y - tail.y);
        if(headX <=1 && headY <=1)
            return false;
        return true;
    }

    public static void MoveHead(string direction, int spacesMoved, List<Knot> knots)
    {
        var head = knots.Single(x => x.Head is null);
        for (int i = 0; i < spacesMoved; i++)
        {
            head = MoveHead(direction, 1, head);
            var myhead = head;
            while (true)
            {
                if (!knots.Any(x => x.Head == myhead))
                    break;
                MoveTails(myhead, knots.Single(x => x.Head == myhead));
                myhead = knots.Single(x => x.Head == myhead);
            }
            
        }
    }

    private static void MoveTails(Knot head, Knot tail)
    {
        if(DoINeedToMove(head, tail))
            MoveTail(head, tail);
    }

    private static Knot MoveHead(string direction, int spacesMoved, Knot headposition)
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

    public static Knot MoveTail(Knot head, Knot tail)
    {
        tail.x = MoveAxis(head.x, tail.x);;
        tail.y = MoveAxis(head.y, tail.y);;
        if(head.Id == 9)
            positions.Add($"{tail.x}--{tail.y}");
        return tail;
    }

    public static List<string> positions = new();

    private static int MoveAxis(int head, int tail)
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