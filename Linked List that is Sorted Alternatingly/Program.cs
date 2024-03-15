using Linked_List_that_is_Sorted_Alternatingly;

int n = int.Parse(Console.ReadLine());
string[] nums = Console.ReadLine().Trim().Split(' ');
Solution solution = new();
Node head = new(0);
Node node = head;
for (int i = 0; i < n; ++i)
{
	node.next = new(int.Parse(nums[i]));
	node = node.next;
}
Node sortedList = solution.Sort(head.next);
while (sortedList != null)
{
	Console.WriteLine(sortedList.data);
	sortedList = sortedList.next;
}