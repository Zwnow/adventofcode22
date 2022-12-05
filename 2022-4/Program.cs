using System.Numerics;
int overlapping = 0;
//Puzzle 1
// foreach(string line in System.IO.File.ReadLines("./input.txt"))
// {
//     string[] ranges = line.Split(new char[]{'-',','});
//     int from1 = Int16.Parse(ranges[0]), to1 = Int16.Parse(ranges[1]);
//     int from2 = Int16.Parse(ranges[2]), to2 = Int16.Parse(ranges[3]);
//     if(from1 <= from2 && to1 >= to2)
//     {
//         overlapping++;
//     }
//     else if(from2 <= from1 && to2 >= to1)
//     {
//         overlapping++;
//     }
// }
//Puzzle 2
foreach(string line in System.IO.File.ReadLines("./input.txt"))
{
    string[] ranges = line.Split(new char[]{'-',','});
    int from1 = Int16.Parse(ranges[0]), to1 = Int16.Parse(ranges[1]);
    int from2 = Int16.Parse(ranges[2]), to2 = Int16.Parse(ranges[3]);
    if(from1 >= from2 && from1 <= to2)
    {
        overlapping++;
    }
    else if(from2 >= from1 && from2 <= to1)
    {
        overlapping++;
    }
}
Console.WriteLine(overlapping);