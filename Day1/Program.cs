var totals = new List<int>();
var current = 0;
var lines = await File.ReadAllLinesAsync("input.json");
foreach (var line in lines) 
{
    if(string.IsNullOrEmpty(line))
    {
        totals.Add(current);
        current = 0;
    }
    else
        current = current + int.Parse(line);
}
Console.Write(totals.OrderByDescending(x => x).Take(3).Sum());