using Bottom_View_of_Binary_Tree;

//                      20
//                    /    \
//                 8       22
//                /   \     /   \
//              5      3 4     25
//                    /    \      
//                 10       14
Solution solution = new();
Node root = new(20);
Node child1 = new(8);
Node child2 = new(22);
Node child3 = new(5);
Node child4 = new(3);
Node child5 = new(4);
Node child6 = new(25);
Node child7 = new(10);
Node child8 = new(14);
root.left = child1;
root.right = child2;
child1.left = child3;
child1.right = child4;
child2.left = child5;
child2.right = child6;
child4.left = child7;
child5.right = child8;
Console.WriteLine(string.Join(" ", solution.BottomView(root)));
