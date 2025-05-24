using Tree_and_Binary_Tree;

Traversal travel = new Traversal();
BinaryTree binTree = new BinaryTree();

Node root = new Node(1);
Node node2 = new Node(2);
Node node3 = new Node(3);
Node node4 = new Node(4);
Node node5 = new Node(5);

root.Left = node2;
root.Right = node3;
node2.Left = node4;
node2.Right = node5;

binTree.Add(3, root);
binTree.Add(5, root);

Console.WriteLine(travel.Depth(root));
Console.WriteLine(travel.ElementsSum(root));
Console.WriteLine(binTree.Search(3, root));
Console.WriteLine(binTree.Search(7, root));