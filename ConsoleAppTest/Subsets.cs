namespace ConsoleAppTest;

public static class Subsets
{
    public static List<List<int>> CalsulateSubsets(List<int> set)
    {
        var subsets = new List<List<int>>();
        subsets.Add(new List<int>());
        subsets.Add(set);

        for (int i = 1; i < set.Count; i++)
        {
            // Create list of pointers;
            List<int> pointers = CreatePointers(i);

            subsets.Add(PointerSubset(pointers, set));

            for (int pointerIndex = 0; pointerIndex < pointers.Count; pointerIndex++)
            {
                var newPointers = new List<int>(pointers);
                for (int newPointer = pointers.Count; newPointer < set.Count; newPointer++)
                {
                    IncrementNthPointer(ref newPointers, pointerIndex, newPointer);
                    subsets.Add(PointerSubset(newPointers, set));
                }
            }
        }

        return subsets;
    }
    
    private static List<int> CreatePointers(int level){
        return new int[level].Select((x, i) => i).ToList();
    }

    private static List<int> PointerSubset(List<int> pointers, List<int> set)
    {
        var result = new List<int>();
        foreach (var pointer in pointers)
        {
            result.Add(set[pointer]);
        }
        return result;
    }

    private static void IncrementNthPointer(ref List<int> pointers, int i, int newPointer)
    {
        pointers[i] = newPointer;
    }
}