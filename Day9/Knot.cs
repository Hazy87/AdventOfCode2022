public class Knot
{
    public Knot()
    {
        
    }
    public Knot(int x, int y)
    {
        this.x = x;
        this.y = y;
    }
    public int x { get; set; }
    public int y { get; set; }
    public Knot? Head { get; set; }
    public int Id { get; set; }
}