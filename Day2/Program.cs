using Day2;

var rounds = (await File.ReadAllLinesAsync("input.txt")).Select(x => new Round(x.Split(' ')[0],x.Split(' ')[1]));
Console.WriteLine(rounds.Select(x => x.GetOutCome()).Sum());