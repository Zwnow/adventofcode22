List<List<string>> crates = new List<List<string>>();
crates.Add(new List<string>{"T","F","V","Z","C","W","S","Q"});
crates.Add(new List<string>{"B","R","Q"});
crates.Add(new List<string>{"S","M","P","Q","T","Z","B"});
crates.Add(new List<string>{"H","Q","R","F","V","D"});
crates.Add(new List<string>{"P","T","S","B","D","L","G","J"});
crates.Add(new List<string>{"Z","T","R","W"});
crates.Add(new List<string>{"J","R","F","S","N","M","Q","H"});
crates.Add(new List<string>{"W","H","F","N","R"});
crates.Add(new List<string>{"B","R","P","Q","T","Z","J"});

foreach(string line in System.IO.File.ReadLines("./input.txt"))
{
    string[] move = line.Split(new string[]{"move","from","to", " "}, StringSplitOptions.RemoveEmptyEntries);
    int a = Int16.Parse(move[0]),from = Int16.Parse(move[1]),to = Int16.Parse(move[2]);
    crates = MoveCrates(crates, from, to, a);
}

List<List<string>> MoveCrates(List<List<string>> crates, int from, int to, int amount)
{
    for(int i = 0; i<amount; i++)
    {
        //task 1
        //crates[to-1].Insert(0,crates[from-1][i]);
        //task 2
        crates[to-1].Insert(0,crates[from-1][amount-(i+1)]);
    }
    for(int i = 0; i<amount; i++)
    {
        crates[from-1].RemoveAt(0);
    }
    return crates;
}

string result = "";

for(int i = 0; i<crates.Count; i++)
{
    result += crates[i][0];
}
Console.WriteLine(result);