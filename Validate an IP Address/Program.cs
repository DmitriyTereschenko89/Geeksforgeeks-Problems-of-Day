using Validate_an_IP_Address;

Solution solution = new();
Console.WriteLine(solution.IsValid("255..255.255"));
Console.WriteLine(solution.IsValid("222.111.111.111"));
Console.WriteLine(solution.IsValid("251.103.211.15"));
Console.WriteLine(solution.IsValid("251.103.211.015"));
Console.WriteLine(solution.IsValid("5555..555"));
Console.WriteLine(solution.IsValid("192.168.0.1"));
Console.WriteLine(solution.IsValid("19.132.268.45"));
