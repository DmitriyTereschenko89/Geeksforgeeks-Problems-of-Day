using Print_Bracket_Number;

Solution solution = new();
Console.WriteLine(string.Join(", ", solution.BracketNumbers("(aa(bdc))p(dee)")));
Console.WriteLine(string.Join(", ", solution.BracketNumbers("(((()(")));
