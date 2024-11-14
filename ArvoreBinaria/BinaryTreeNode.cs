using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArvoreBinaria
{
    public class BinaryTreeNode<T>: TreeNode<T>
    {
        public BinaryTreeNode(){
            base.Children = new List<TreeNode<T>>();
        }

        public BinaryTreeNode<T> Left{
            get { return (BinaryTreeNode<T>)Children[0]; }
            set { Children[0] = value;}
        }

        
        public BinaryTreeNode<T> Right{
            get { return (BinaryTreeNode<T>)Children[1]; }
            set { Children[1] = value;}
        }

        public void TraversePreOrder
        (
            BinaryTreeNode<T> node, 
            List<BinaryTreeNode<T>> result 
        )
        {
            if (node != null)
            {
                result.Add(node);
                TraversePreOrder(node.Left, result);
                TraversePreOrder(node.Right, result);
            }
        }

        public void TraverseInOrder
        (
            BinaryTreeNode<T> node, 
            List<BinaryTreeNode<T>> result 
        )
        {
            if (node != null)
            {
                TraverseInOrder(node.Left, result);
                result.Add(node);
                TraverseInOrder(node.Right, result);
            }
        }

        public void TraversePostOrder
        (
            BinaryTreeNode<T> node, 
            List<BinaryTreeNode<T>> result 
        )
        {
            if (node != null)
            {
                TraversePostOrder(node.Left, result);
                result.Add(node);
                TraversePostOrder(node.Right, result);
            }
        }


    }
}