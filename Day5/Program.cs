// See https://aka.ms/new-console-template for more information

using Day5;

Console.WriteLine("Hello, World!");
var readAllLinesAsync = (await File.ReadAllLinesAsync("input.txt")).ToList();
var indexOfHeader = readAllLinesAsync.ToList().IndexOf(readAllLinesAsync.Single(x => x.Trim().StartsWith("1")));
var stacks = readAllLinesAsync.GetRange(0, indexOfHeader);
var actualStacks = StackMaker.MakeStacks(stacks);
var moves = readAllLinesAsync.GetRange(indexOfHeader +2, readAllLinesAsync.Count-indexOfHeader-2).Select(MoveParser.ParseMove);

foreach (var move in moves)
{
    var myContainers = new List<string>();
    for (int i = 0; i < move.ContainersToMove; i++)
    {
        myContainers.Add(actualStacks[move.Source].Pop());
    }

    myContainers.Reverse();
    myContainers.ForEach(x => actualStacks[move.Destination].Push(x));
}


foreach(var stack in actualStacks)
    Console.Write(stack.Value.Pop().First());