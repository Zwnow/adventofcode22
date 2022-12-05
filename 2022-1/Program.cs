List<int> totals = new List<int>();
int total = 0;
foreach (string line in System.IO.File.ReadLines(@".\input.txt"))
{  
    try
    {
        total += Int32.Parse(line);
    }
    catch
    {
        totals.Add(total);
        total = 0;
    }
}
int max = totals[0];
var highest = totals.OrderBy(x => x).ToArray();
//Puzzle 1
Console.WriteLine(highest[highest.Length-1]);
//Puzzle 2
Console.WriteLine(highest[highest.Length-1]+highest[highest.Length-2]+highest[highest.Length-3]);