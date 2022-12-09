var commands = await File.ReadAllLinesAsync("input.txt");
var headposition = new Knot(){x = 1,y =  1};
var twoposition = new Knot(){x = 1,y =  1, Head = headposition};
var threeposition = new Knot(){x = 1,y =  1, Head = twoposition};
var fourposition = new Knot(){x = 1,y =  1, Head = threeposition};
var fiveposition = new Knot(){x = 1,y =  1, Head = fourposition};
var sixposition = new Knot(){x = 1,y =  1, Head = fiveposition};
var sevenposition = new Knot(){x = 1,y =  1, Head = sixposition};
var eightposition = new Knot(){x = 1,y =  1, Head = sevenposition};
var nineition = new Knot(){x = 1,y =  1, Head = eightposition, Id = 9};
var tenposition = new Knot(){x = 1,y =  1, Head = nineition};

var knots = new List<Knot>() { headposition, twoposition, threeposition, fourposition, fiveposition, sixposition, sevenposition, eightposition,nineition,tenposition };
Follower.positions.Add("1--1");
foreach (var command in commands)
{
    var direction = command.Split(" ");
    Follower.MoveHead(direction[0], int.Parse(direction[1]), knots);
}

Console.Write(Follower.positions.Distinct().Count());