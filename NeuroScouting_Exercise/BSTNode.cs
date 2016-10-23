using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeuroScouting_Exercise
{
    public class BSTNode
    {
        public int data;
        public int level;
        public BSTNode left;
        public BSTNode right;

        public BSTNode(int data, int level)
        {
            this.left = null;
            this.right = null;
            this.data = data;
            this.level = level;
        }

        public void print(BSTNode root)
        {
            if (root != null)
            {
                Console.Write(root.data + "->");
                print(root.left);
                print(root.right);
            }
        }
    };
}
