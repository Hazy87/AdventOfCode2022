using Day6;

var readAllLinesAsync = (await File.ReadAllLinesAsync("input.txt")).ToList();
Console.WriteLine(MarkerFinder.FindMarker(readAllLinesAsync.First(), 4));

Console.WriteLine(MarkerFinder.FindMarker(readAllLinesAsync.First(), 14));