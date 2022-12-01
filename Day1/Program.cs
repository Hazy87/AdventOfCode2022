var max = 0;
var current = 0;
var lines = await File.ReadAllLinesAsync("input.json");
foreach (var line in lines) 
{
    if(string.IsNullOrEmpty(line))
    {
        if (current > max)
            max = current;
        current = 0;
    }
    else
        current = current + int.Parse(line);
}
Console.Write(max);