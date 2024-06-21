//7,3,5,2,6,4,1,8
using MergeSortDoubleLinkedList;

Node head = new(7);
Node node1 = new(3);
Node node2 = new(5);
Node node3 = new(2);
Node node4 = new(6);
Node node5 = new(4);
Node node6 = new(1);
Node node7 = new(8);
head._next = node1;
node1._next = node2;
node1._prev = head;
node2._next = node3;
node2._prev = node1;
node3._next = node4;
node3._prev = node2;
node4._next = node5;
node4._prev = node3;
node5._next = node6;
node5._prev = node4;
node5._next = node6;
node5._prev = node4;
node6._next = node7;
node6._prev = node5;
node7._prev = node6;

Solution solution = new();
Node sortNode = solution.SortDoubly(head);
while (sortNode != null)
{
    Console.WriteLine(sortNode._data);
    sortNode = sortNode._next;
}