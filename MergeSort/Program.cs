// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
List<int> list = new List<int>(new int[]{ 6, 3, 6, 8, 5, 7, 2, 3, 6, 9 });
QuickSort(list).ForEach(c => Console.Write(c));
List<int> QuickSort(List<int> input)
{
    List<int> result = new List<int>();
    List<int> left = new List<int>();
    List<int> right = new List<int>();
    if (input.Count == 0)
        return result;
    if (input.Count == 1)
        return input;
    for (int i = 1; i < input.Count; i++)
    {
        if (input[0] >= input[i])
            left.Add(input[i]);
        else
            right.Add(input[i]);
    }
    result.AddRange(QuickSort(left));
    result.Add(input[0]);
    result.AddRange(QuickSort(right));
    return result;
}
List<int> MergeSort(List<int> input)
{
    List<int> result = new List<int>();
    if(input.Count == 0)
        return result;
    if (input.Count == 1)
        return input;
    int middle = input.Count / 2 + input.Count % 2;
    return Merge(
        MergeSort(
            input.GetRange(0, middle)),
        MergeSort(
            input.GetRange(middle, input.Count / 2))
            );
}
List<int> Merge(List<int> a, List<int> b)
{
    List<int> c = new();
    int i = 0;  int j = 0;
    while (i < a.Count && j < b.Count)
    {
        if (a[i] <= b[j])
        {
            c.Add(a[i]);
            i++;
        }
        else
        {
            c.Add(b[j]);
            j++;
        }    
    }
    c.AddRange(a.GetRange(i, a.Count - i));
    c.AddRange(b.GetRange(j, b.Count - j));
    return c;
}