foreach(string line in System.IO.File.ReadLines("./input.txt"))
{
    //Puzzle 1
    // for(int i = 0; i<line.Length-3; i++)

    //Puzzle 2
    for(int i = 0; i<line.Length-13; i++)
    {
        List<char> chars = new List<char>();

        //Puzzle 1
        // string sub = line.Substring(i,4);
        //Puzzle 2
        string sub = line.Substring(i,14);

        for(int k = 0; k<sub.Length; k++)
        {
         if(chars.IndexOf(sub[k]) < 0)
            chars.Add(sub[k]);
        }
        //Puzzle 1
        // if(chars.Count == 4)
        // {
        //     Console.WriteLine(i+4);
        //     break;
        // }

        //Puzzle 2
        if(chars.Count == 14)
        {
            Console.WriteLine(i+14);
            break;
        }     
    }
}
