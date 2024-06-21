using AddTwoNumbersRepresentedByLinkedLists;

Solution solution = new();
Node num1 = new(4, new(5));
Node num2 = new(3, new(4, new(5)));
Node num3 = new(0, new(0, new(6, new(3))));
Node num4 = new(0, new(7));
var sum = solution.AddTwoLists(num1, num2);
var sum1 = solution.AddTwoLists(num3, num4);
while (sum != null)
{
    Console.Write(sum.data + " ");
    sum = sum.next;
}
Console.WriteLine();
while (sum1 != null)
{
    Console.Write(sum1.data + " ");
    sum1 = sum1.next;
}
Console.WriteLine();