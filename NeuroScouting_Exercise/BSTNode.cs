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
        public BSTNode left;
        public BSTNode right;

        public BSTNode(int data)
        {
            this.left = null;
            this.right = null;
            this.data = data;
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

        public BSTNode Insert(BSTNode root, int data)
        {
            if(root == null)
            {
                root = new BSTNode(data);
            }
            else if(data <= root.data)
            {
                root.left = Insert(root.left, data);
            } else
            {
                root.right = Insert(root.right, data);
            }
            return root;
        }

        public int FindHeight(BSTNode root)
        {
            if(root == null)
            {
                return -1;
            }
            int leftHeight = FindHeight(root.left);
            int rightHeight = FindHeight(root.right);
            int max = leftHeight > rightHeight ? leftHeight : rightHeight;
            return (max + 1);
        }
    };
}
