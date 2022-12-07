using System.Globalization;

var readAllLinesAsync = (await File.ReadAllLinesAsync("input.txt")).ToList();
var directories = new List<Directory>();
Directory currentDirectory = null;
foreach (var line in readAllLinesAsync)
{
    if (line == "$ cd ..")
    {
        currentDirectory = currentDirectory.Parent;
    }
    else if (line.StartsWith($"$ cd"))
    {
        currentDirectory = new Directory(){Name = line.Split(" ")[2], Parent = currentDirectory};
        directories.Add(currentDirectory);
    }

    else if (line.StartsWith("dir"))
    {
        
    }
    else if (Helper.IsFile(line))
    {
        currentDirectory.fileSizes.Add(int.Parse(line.Split(" ")[0]));
    }
}
int GetSize(Directory directory1, List<Directory> list)
{
    var size = 0;
    foreach (var child in list.Where(x => x.Parent == directory1))
    {
        size += GetSize(child, list);
    }

    size += directory1.fileSizes.Sum();
    return size;
}

var fileUsage = GetSize(directories.Single(x => x.Name == "/"), directories);
var neededSize = 30000000 - ( 70000000 - fileUsage);
var sum = directories.Where(x => GetSize(x, directories) >= neededSize).Min(x => GetSize(x,directories));
Console.WriteLine(sum);

public class Helper
{
    public static bool IsFile(string command)
    {
        int whocares;
        return int.TryParse(command.Split()[0], out whocares);
    }
}
class Directory
{
    public Directory Parent { get; set; }
    public string Name { get; set; }
    public List<int> fileSizes { get; set; } = new List<int>();
    public List<string> SubDirectory { get; set; } = new List<string>();
}