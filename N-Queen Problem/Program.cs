using N_Queen_Problem;

Solution solution = new();
foreach (var item in solution.SolveNQueens(1))
{
    Console.WriteLine(string.Join(" ", item));
}
Console.WriteLine(new string('=', 20));
foreach (var item in solution.SolveNQueens(4))
{
    Console.WriteLine(string.Join(" ", item));
}
//Console.WriteLine(new string('=', 20));
//foreach (var item in solution.SolveNQueens(10))
//{
//    Console.WriteLine(string.Join(" ", item));
//}
