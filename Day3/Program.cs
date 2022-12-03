var readAllLinesAsync = await File.ReadAllLinesAsync("input.txt");
var totalPriority = 0;
for (var i = 0; i < readAllLinesAsync.Length; i += 3)
{
    var priority = 0;

    var commonChar = readAllLinesAsync[i].Intersect(readAllLinesAsync[i+1]).Intersect(readAllLinesAsync[i+2]).ToArray();
    if (commonChar.First() > 97)
        priority = commonChar.First()-96;
    else
        priority = commonChar.First() - 38;
    totalPriority += priority;

}
Console.WriteLine(totalPriority);