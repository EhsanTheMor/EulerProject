using System.Diagnostics;

var sw = Stopwatch.StartNew();



Console.WriteLine("Found Solution in {0};",sw.ElapsedMilliseconds);

void CalsulateSubsets(List<int> set)
{
    var subsets = new List<List<int>>();
    subsets.Add(new List<int>());
    
    foreach (var i in set)
    {
        subsets.Add(new List<int> { i });
    }

    foreach (var i in set)
    {
        foreach (var j in set)
        {
            
        }
    }
    
    subsets.Add(set);
}