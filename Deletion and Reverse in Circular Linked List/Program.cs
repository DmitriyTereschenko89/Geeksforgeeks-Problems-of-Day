using Deletion_and_Reverse_in_Circular_Linked_List;

// 2->5->7->8->10, key = 8
Node head = new(2);
Node first = new(5);
Node second = new(7);
Node third = new(8);
Node fourth = new(10);
head._next = first;
first._next = second;
second._next = third;
third._next = fourth;
fourth._next = head;

Solution solution = new();
head = solution.DeleteNode(head, 8);
head = solution.Reverse(head);
// 1->7->8->10, key = 8
Node head1 = new(1);
Node one = new(7);
Node two = new(8);
Node three = new(10);
head1._next = one;
one._next = two;
two._next = three;
three._next = head1;
