using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tree_and_Binary_Tree
{
    public class BinaryTree
    {
        public Node root;

        public Node Add(int val, Node node)
        {

            if (node == null)
            {
                return new Node(val);
            }

            if (val < node.data)
            {
                node.Left = Add(val, node.Left);
            }
            else if (val > node.data)
            {
                node.Right = Add(val, node.Right);
            }

            return node;
        }

        public bool Search(int n, Node node)
        {
            if (node == null) return false;
            if (n == node.data) return true;
            if (n > node.data) return Search(n, node.Right);
            return Search(n, node.Left);
        }

    }
}
