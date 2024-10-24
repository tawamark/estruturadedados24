using System.Collections.Generic;

namespace ArvoresBasicas
{
    public class Node<T>
    {
        public T Data { get; set; }
        public List<Node<T>> Children { get; set; } = new List<Node<T>>();
    }

    public class Tree<T>
    {
        public Node<T> Root { get; set; }

        public void PrintTree(Node<T> node, string indent = "")
        {
            if (node == null) return;

            Console.WriteLine(indent + node.Data);
            foreach (var child in node.Children)
            {
                PrintTree(child, indent + "  ");
            }
        }
    }
}