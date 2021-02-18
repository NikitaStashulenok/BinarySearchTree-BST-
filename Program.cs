using BinarySearchTree;
using System;

namespace BinaryTreeSearch
{
    class Program
    {
        static void Main(string[] args)
        {
            var tree = new Tree<int>();
            tree.Add(5);
            tree.Add(2);
            tree.Add(1);
            tree.Add(3);
            tree.Add(4);
            tree.Add(8);
            tree.Add(9);
            tree.Add(7);
            tree.Add(6);

            foreach (var item in tree.PreOrder())
            {
                Console.Write("-" + item + "-");
            }

            Console.ReadLine();

            foreach (var item in tree.PostOrder())
            {
                Console.Write("-" + item + "-");
            }

            Console.ReadLine();

            foreach (var item in tree.InOrder())
            {
                Console.Write("-" + item + "-");
            }

            Console.ReadLine();
        }
    }
}
