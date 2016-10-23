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
            BSTNode root = null;
            //Some function which will be later declared.
            root = MakeTree(root, height);
            root.print(root);
            System.Console.ReadKey();
        }

        static BSTNode MakeTree(BSTNode root, int height)
        {
            //Root will always be added.
            Queue<BSTNode> queue = new Queue<BSTNode>();
            root = new BSTNode(1);
            int curHeight = 1;
            queue.Enqueue(root);
            while(curHeight < height)
            {
                BSTNode tempNode = queue.Dequeue();
                BSTNode leftNeighbour = GetLeftNeighbour(tempNode, queue);
                if (leftNeighbour == null)
                {
                    tempNode.left = new BSTNode(1);
                }
                else
                {
                    tempNode.left = new BSTNode(tempNode.data + leftNeighbour.data);
                }
                queue.Enqueue(tempNode.left);

                BSTNode rightNeighbour = GetRightNeighbour(tempNode, (curHeight + 1) , queue);
                if (rightNeighbour == null)
                {
                    tempNode.right = new BSTNode(1);
                }
                else
                {
                    tempNode.right = new BSTNode(tempNode.data + rightNeighbour.data);
                }
                queue.Enqueue(tempNode.right);
                curHeight = curHeight + 1;
            }
            return root;
        }

        static BSTNode GetLeftNeighbour(BSTNode node, Queue<BSTNode> queue)
        {
            int x = queue.ToList().IndexOf(node);
            if (x == -1 ) return null;
            return queue.ElementAt(x - 1);
        }

        static BSTNode GetRightNeighbour(BSTNode node, int Height, Queue<BSTNode> queue)
        {
            int x = queue.ToList().IndexOf(node);
            if (x == - 1) return null;
            return queue.ElementAt(x + 1);
        }

    }
}
