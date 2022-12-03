
using System.Diagnostics;
using System.Linq.Expressions;

var readAllLinesAsync = await File.ReadAllLinesAsync("input.txt");
var totalPriority = 0;
foreach(var line in readAllLinesAsync)
{
    var priority = 0;
    var halfLength = line.Length/2;
    var firstHalf = line.Substring(0, halfLength);
    var secondHalf = line.Substring(halfLength);
    var commonChar = firstHalf.ToList().Intersect(secondHalf.ToList());
    if (commonChar.Count() == 0)
        continue;;
    if (commonChar.First() > 97)
        priority = commonChar.First()-96;
    else
        priority = commonChar.First() - 38;
    totalPriority += priority;
}
Console.WriteLine(totalPriority);