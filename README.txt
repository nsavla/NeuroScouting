
The code for binary tree works in Visual Studio.
You can open the project and simple run it.

The program asks for the level and generates the tree according to it.

First, the program generates the root node as it will always be present. The root element is enqueued in a queue. It then determines if current Level is equal to input level. The program uses queue as it is useful for looking at elements in the same level.

Each element at a desired level, the elements are dequeued.
For each element, we look at left neighbour.
If left neighbour is null, we add 1 to its left child.
If left neighbour has a value, we add the current data and left neghbour's data to the left child.
The left neighbour is enqueued in queue.

For the same element, we look at right neighbour.
If right neighbour is null, we add 1 to its right child.
If right neighbour has a value, we add the current data and right neghbour's data to the right child.
The right neighbour is enqueued in queue.

We continue this by increasing our current level.
As once the current level is equal to desired level,
we return root.

The code is organized in two files - 
Program.cs and BTNode.cs
BTNode.cs - has the binary tree. Uses a constructor and print function.
Program.cs - Main() where data is entered, LeftNeighbour() to find the left neighbour of a node, right neighbour() to find right Neighbour of a node and MakeTree() is used for making up of the tree.
The program uses List functions to find element index in a queue.
