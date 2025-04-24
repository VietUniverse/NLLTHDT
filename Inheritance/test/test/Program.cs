int[] so = { 1, 2, 3, 7, 18, 34, 26, 16, 30, 11 };
List<int> soChan = new List<int>();
List<int> soLe = new List<int>();
int[] khongBiet = new int[5];
foreach (int i in so)
{
    if (i % 2 == 0)
    {
        Console.WriteLine($"{i} la so chan");
        soChan.Add(i);
    }
    else
    {
        Console.WriteLine($"{i} la so le");
        soLe.Add(i);
    }
}
foreach (int i in soChan)
{
    Console.Write(i.ToString() + ' ');
}
Console.WriteLine();
foreach (int i in soLe)
{
    Console.Write(i.ToString() + ' ');
}