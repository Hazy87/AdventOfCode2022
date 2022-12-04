using Day4;

var readAllLinesAsync = await File.ReadAllLinesAsync("input.txt");
var counter = 0;
foreach (var line in readAllLinesAsync)
{
    var strings = line.Split(",");
    var bitsFromRange = RangeToBits.GetBitsFromRange(strings[0], strings[1]);
    var result = RangeToBits.CheckForContaining(bitsFromRange.rangeoneBinary, bitsFromRange.rangetwoBinary);
    if (result)
        counter++;
}
Console.WriteLine(counter);
