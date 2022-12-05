namespace Day5;

public class StackMaker
{

    public static Dictionary<int,Stack<string>> MakeStacks(List<string> strings)
    {
        var returnValue = new Dictionary<int, Stack<string>>();
        strings.Reverse();
        foreach (var line in strings)
        {
            var counter = 0;
            foreach (var chunk in line.Chunk(4))
            {
                counter = counter + 1;
                var value = new string(chunk);
                if(string.IsNullOrEmpty(value))
                    continue;
                var letter = value.Replace("[", "").Replace("]", "").Trim();
                SafeAddToStack(letter, counter,returnValue);
            }
        }
        return returnValue;
    }

    private static void SafeAddToStack(string letter, int counter, Dictionary<int, Stack<string>> returnValue)
    {
        if (!returnValue.ContainsKey(counter))
            returnValue[counter] = new Stack<string>();
        if(!string.IsNullOrEmpty(letter))
            returnValue[counter].Push(letter);
    }
}