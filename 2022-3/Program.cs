string prios = "abcdefghijklmnopqrstuvwxyz";
int result = 0;

List<string> text = new List<string>();
foreach(string line in System.IO.File.ReadLines("./input.txt"))
{
    text.Add(line);
}

for(int i = 0; i<text.Count-2; i+=3)
{
    string[] inp = new string[3]{text[i],text[i+1],text[i+2]};
    var lines = inp.Select(x => x).OrderBy(x => x.Length).ToArray();
    for(int k = 0; k<lines[0].Length; k++)
    {
        if(lines[1].IndexOf(lines[0][k])>-1 && lines[2].IndexOf(lines[0][k])>-1)
        {
            if(!Char.IsUpper(lines[0][k]))
            {
                result += prios.IndexOf(lines[0][k])+1;
                break;
            }
            else
            {
                result += prios.IndexOf(Char.ToLower(lines[0][k]))+27;
                break;
            }
        }
    }
}
Console.WriteLine(result);








// foreach(string line in System.IO.File.ReadLines("./input.txt"))
// {
//     int half = line.Length/2;
    
//     string firstHalf = line.Substring(0,half);
//     char[] secondHalf = line.Substring(half).ToArray();
    
//     for(int i = 0; i<half; i++)
//     {
//         int index = Array.IndexOf(secondHalf,firstHalf[i]);
//         if(index > -1)
//         {
//             secondHalf[Array.IndexOf(secondHalf,firstHalf[i])] = ' ';
//             if(!Char.IsUpper(firstHalf[i]))
//             {
//                 result += prios.IndexOf(firstHalf[i])+1;
//             }
//             else
//             {
//                 result += prios.IndexOf(Char.ToLower(firstHalf[i]))+27;
//             }
//             break;
//         }
//     }

// }
// Console.WriteLine(result);