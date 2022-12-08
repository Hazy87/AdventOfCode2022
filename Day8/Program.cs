var treesGrid = (await File.ReadAllLinesAsync("input.txt")).ToList()
    .Select(x => x.ToCharArray().Select(y => int.Parse(y.ToString())).ToList()).ToList();


int LookUpwards(int treeHeight, List<List<int>> list, int x, int y)
{
    var scenicScore = 1;
    if (x == 0) return 1;
    for (int j = x; j >= 1; j--)
    {
        if (list[j - 1][y] >= treeHeight)
        {
            return scenicScore;
        }

        scenicScore++;
    }

    return scenicScore -1;
    }

int LookDownwards(int treeHeight, List<List<int>> list, int x, int y)
{    if (x == 0) return 0;

    var scenicScore = 1;

    for (int j = x; j < list.Count() - 1; j++)
    {
        if (list[j + 1][y] >= treeHeight)
        {
            return scenicScore;
        }

        scenicScore++;
    }

    return scenicScore -1;
}

int LookLeftwards(int treeHeight, List<List<int>> list, int x, int y)
{    if (y == 0) return 0;

    var scenicScore = 1;

    for (int j = y; j >= 1; j--)
    {
        if (list[x][j - 1] >= treeHeight)
        {
            return scenicScore;
        }

        scenicScore++;
    }

    return scenicScore -1;
}

int LookRightwards(int treeHeight, List<List<int>> list, int x, int y)
{    if (y == 0) return 0;

    var scenicScore = 1;

    for (int j = y; j < list.Count - 1; j++)
    {
        if (list[x][j + 1] >= treeHeight)
        {
            return scenicScore;
        }

        scenicScore++;
    }

    return scenicScore -1;
}

var counter = new List<int>();
for (int x = 0; x <= treesGrid.Count - 1; x++)
{
    for (int y = 0; y <= treesGrid[x].Count - 1; y++)
    {
        var treeHeight = treesGrid[x][y];
        var lookUpwards = LookUpwards(treeHeight, treesGrid, x, y);
        var lookDownwards = LookDownwards(treeHeight, treesGrid, x, y);
        var lookLeftwards = LookLeftwards(treeHeight, treesGrid, x, y);
        var lookRightwards = LookRightwards(treeHeight, treesGrid, x, y);
        var scenicScore = lookUpwards * lookDownwards *
                          lookLeftwards * lookRightwards;
        counter.Add(scenicScore);
    }

    Console.WriteLine();
}

Console.WriteLine(counter.Max());