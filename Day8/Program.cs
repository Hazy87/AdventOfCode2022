var treesGrid = (await File.ReadAllLinesAsync("input.txt")).ToList().Select(x => x.ToCharArray().Select(y => int.Parse(y.ToString())).ToList()).ToList();


bool LookUpwards(int treeHeight, List<List<int>> list, int x, int y)
{
    if (x == 0) return true;
    for (int j = x; j >= 1; j--)
    {
        if (list[j - 1][y] >= treeHeight)
        {
            return false;
        }
    }
    return true;
}
bool LookDownwards(int treeHeight, List<List<int>> list, int x, int y)
{
    if (x == 0) return true;
    for (int j = x; j < list.Count()-1; j++)
    {
        if(list[j +1][y] >= treeHeight) {
            return false;
        }
    }

    return true;
}
bool LookLeftwards(int treeHeight, List<List<int>> list, int x, int y)
{
    if (y == 0) return true;
    for (int j = y; j >= 1; j--)
    {
        if (list[x][j - 1] >= treeHeight)
        {
            return false;
        }
    }
    return true;
}
bool LookRightwards(int treeHeight, List<List<int>> list, int x, int y)
{
    if (y == 0) return true;
    for (int j = y; j < list.Count-1; j++)
    {
        if(list[x][j +1] >= treeHeight) {
            return false;
        }
    }

    return true;
}
var counter = 0;
for (int x = 0; x <= treesGrid.Count-1; x++)
{
    
    for (int y = 0; y <= treesGrid[x].Count-1; y++)
    {
        var treeHeight = treesGrid[x][y];
        if (LookUpwards(treeHeight, treesGrid, x, y) || LookDownwards(treeHeight, treesGrid, x, y) ||
            LookLeftwards(treeHeight, treesGrid, x, y) || LookRightwards(treeHeight, treesGrid, x, y))
        {
            counter++;
            Console.Write("T");
        }
        else Console.Write("F");
    }
    Console.WriteLine();
}
Console.WriteLine(counter);