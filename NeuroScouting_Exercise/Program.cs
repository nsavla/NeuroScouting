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
            Queue<BSTNode> queue = new Queue<BSTNode>();
            root = new BSTNode(1);
            queue.Enqueue(root);

            return root;
        }
    }
}
