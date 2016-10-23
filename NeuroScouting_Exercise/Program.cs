using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeuroScouting_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Height");
            string tempString = Console.ReadLine();
            int height = Int32.Parse(tempString);
            BTNode root = null;
            //Some function which will be later declared.
            root = MakeTree(root, height);
            root.print(root);
            System.Console.ReadKey();
        }

        static BTNode MakeTree(BTNode root, int height)
        {
            //Root will always be added.
            Queue<BTNode> queue = new Queue<BTNode>();
            root = new BTNode(1,1);
            int curHeight = 1;
            queue.Enqueue(root);
            //Comparing current height with he given height.
            while (curHeight < height)
            {
                curHeight = curHeight + 1;
                int i = 0;
                //Determing the level of each elements in queue. All elements should be at a given level.
                while (queue.ElementAt(i).level == curHeight - 1)
                {
                    BTNode tempNode = queue.ElementAt(i);
                    //Checking the left neighbour and adding the child.
                    BTNode leftNeighbour = GetLeftNeighbour(tempNode, (curHeight - 1), queue);
                    if (leftNeighbour == null)
                    {
                        tempNode.left = new BTNode(1, curHeight);
                    }
                    else
                    {
                        tempNode.left = new BTNode(tempNode.data + leftNeighbour.data, curHeight);
                    }
                    queue.Enqueue(tempNode.left);

                    //Checking the right neighbour and adding the child.
                    BTNode rightNeighbour = GetRightNeighbour(tempNode, (curHeight - 1), queue);
                    if (rightNeighbour == null)
                    {
                        tempNode.right = new BTNode(1, curHeight);
                    }
                    else
                    {
                        tempNode.right = new BTNode(tempNode.data + rightNeighbour.data, curHeight);
                    }
                    queue.Enqueue(tempNode.right);
                    i++;
                }
                //Deleting all elements at a given level still present in queue.
                while (queue.Peek().level == (curHeight - 1))
                    queue.Dequeue();
            }
            return root;
        }

        static BTNode GetLeftNeighbour(BTNode node, int Height, Queue<BTNode> queue)
        {
            int x = queue.ToList().IndexOf(node);
            if (x == -1 || x == 0) return null;
            return queue.ElementAt(x - 1);
        }

        static BTNode GetRightNeighbour(BTNode node, int Height, Queue<BTNode> queue)
        {
            int x = queue.ToList().IndexOf(node);
            if (x == - 1 || x== (Math.Pow(2, Height - 1) - 1)) return null;
            return queue.ElementAt(x + 1);
        }

    }
}
