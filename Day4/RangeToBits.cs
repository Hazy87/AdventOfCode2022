using System.Text;

namespace Day4;

public class RangeToBits
{
    public static (string rangeoneBinary, string rangetwoBinary) GetBitsFromRange(string range1, string range2)
    {
        
        var range1List = range1.Split("-").Select(x => int.Parse(x)).ToList();
        var range2List = range2.Split("-").Select(x => int.Parse(x)).ToList();
        var max = range1List.Max() > range2List.Max() ? range1List.Max() : range2List.Max();
        StringBuilder range1Builder = new StringBuilder();
        StringBuilder range2Builder = new StringBuilder();
        for (int i = 1; i < max+1; i++)
        {
            if (range1List[0] <= i && range1List[1] >= i)
                range1Builder.Append("1");
            else
                range1Builder.Append("0");
            if (range2List[0] <= i && range2List[1] >= i)
                range2Builder.Append("1");
            else
                range2Builder.Append("0");
        }

        return (range1Builder.ToString(), range2Builder.ToString());
    }
    
    public static bool CheckForContaining(string binary1String, string binary2String)
    {
        StringBuilder sb = new StringBuilder();
        for (int i = 0; i < binary1String.Length; i++)
        {
            if (binary1String[i] == binary2String[i] && binary2String[i] == '1')
                return true;
            else
                sb.Append("0");
        }

        return binary1String == sb.ToString() || binary2String == sb.ToString();
        Console.WriteLine(binary1String);
        Console.WriteLine(binary2String);
        var binary1 = Convert.ToInt64(binary1String, 2);
        var binary2= Convert.ToInt64(binary2String, 2);
        var checkForContaining = binary1 | binary2;
        return checkForContaining == binary1 || checkForContaining == binary2;

    }
}