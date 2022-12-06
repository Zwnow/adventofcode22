Dictionary<string,int> scoreTable = new Dictionary<string, int>();
Dictionary<(string,string), (int,string)> scoreMoves = new Dictionary<(string,string), (int,string)>();
scoreTable.Add("A",1);
scoreTable.Add("B",2);
scoreTable.Add("C",3);
//X = Lose, Y = Draw, Z = Win
//A = Rock, B = Paper, C = Scissors
scoreMoves.Add(("X","C"),(0,"B"));
scoreMoves.Add(("X","B"),(0,"A"));
scoreMoves.Add(("X","A"),(0,"C"));
scoreMoves.Add(("Y","A"),(3,"A"));
scoreMoves.Add(("Y","C"),(3,"C"));
scoreMoves.Add(("Y","B"),(3,"B"));
scoreMoves.Add(("Z","B"),(6,"C"));
scoreMoves.Add(("Z","A"),(6,"B"));
scoreMoves.Add(("Z","C"),(6,"A"));
int score = 0;
foreach(string line in System.IO.File.ReadLines("./input.txt"))
{
    var moves = line.Split(' ');
    score += DetermineRound(moves[0].ToString(), moves[1].ToString());
}
Console.WriteLine(score);
int DetermineRound(string a, string b)
{
    return scoreMoves[(b,a)].Item1+scoreTable[scoreMoves[(b,a)].Item2];
}