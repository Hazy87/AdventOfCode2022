namespace Day6;

public class MarkerFinder
{
    
    public static int FindMarker(string message, int lengthOfMarker)
    {
        for (int i = 0; i < message.Length; i++)
        {
           if (message.Substring(i, lengthOfMarker).GroupBy(x => x).All(x => x.Count() == 1))
               return i +lengthOfMarker;
        }

        throw new Exception();
    }
}