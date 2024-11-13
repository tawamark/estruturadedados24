using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExercicioTree
{
    public class Node
    {
        public Person? Data { get; set; }
        public Node? Parent { get; set; }
        public List<Node>? Children { get; set;} = new List<Node>();
    }
}