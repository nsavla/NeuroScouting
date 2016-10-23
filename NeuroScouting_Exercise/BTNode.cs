using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeuroScouting_Exercise
{
    public class BTNode
    {
        public int data;
        public int level;
        public BTNode left;
        public BTNode right;

        public BTNode(int data, int level)
        {
            this.left = null;
            this.right = null;
            this.data = data;
            this.level = level;
        }

        public void print(BTNode root)
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
