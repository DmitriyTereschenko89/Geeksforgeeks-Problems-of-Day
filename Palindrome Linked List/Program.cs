using Palindrome_Linked_List;

//1->2->1->1->2->1
Node head1 = new(1, new(2, new(1, new(1, new(2, new(1))))));
Node head2 = new(123, new(345));
Node head3 = new(281, new(642));
Solution solution = new();
//Console.WriteLine(solution.IsPalindrome(head1));
//Console.WriteLine(solution.IsPalindrome(head2));
Console.WriteLine(solution.IsPalindrome(head3));
