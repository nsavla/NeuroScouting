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
            Console.WriteLine("Height =" + height);
            BSTNode root = null;
            //Some function which will be later declared.
            root = MakeTree(root, 4);
            System.Console.ReadKey();
        }

        static BSTNode MakeTree(BSTNode root, int level)
        {
            // Empty for now.
            return root;
        }
    }
}
