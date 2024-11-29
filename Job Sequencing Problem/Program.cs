using Job_Sequencing_Problem;

Solution solution = new();
//Console.WriteLine(string.Join(" ", solution.JobScheduling([ new(1, 4, 20), new(2, 1, 10), new(3, 1, 40), new(4, 1, 30)], 4)));
Console.WriteLine(string.Join(" ", solution.JobScheduling([new(1, 2, 100), new(2, 1, 19), new(3, 2, 27), new(4, 1, 25), new(5, 1, 15)], 5)));
