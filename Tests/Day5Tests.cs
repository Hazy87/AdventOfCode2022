using System.Text;
using Day5;

namespace Tests;

public class Day5Tests
{
    [Fact]
    public void MakeStack_ReturnsCorrectStacks()
    {
        var listsOfString = new List<string>();
        listsOfString.Add("    [D]    ");
        listsOfString.Add("[N] [C]    ");
        listsOfString.Add("[Z] [M] [P]");
        var makeStacks = StackMaker.MakeStacks(listsOfString);
        Assert.Equal(makeStacks[1].First(),"");
        Assert.Equal(makeStacks[1].ToList()[1],"N");
        Assert.Equal(makeStacks[1].ToList()[2],"Z");
        Assert.Equal(makeStacks[2].ToList()[1],"C");
        Assert.Equal(makeStacks[2].ToList()[2],"M");
        Assert.Equal(makeStacks[2].First(),"D");
        Assert.Equal(makeStacks[3].ToList()[2],"P");
        Assert.Equal(makeStacks[3].ToList()[1],"");
        Assert.Equal(makeStacks[3].First(),"");
    }

    [Fact]
    public void MoveParser_parses()
    {
        var move = "move 21 from 2 to 1";

        var move1 = MoveParser.ParseMove(move);
        
        Assert.Equal(move1.Destination, 1);
        Assert.Equal(move1.Source, 2);
        Assert.Equal(move1.ContainersToMove, 21);

    }
}