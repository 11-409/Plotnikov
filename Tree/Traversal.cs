using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tree
{
    public class Traversal()
    {
        public int Depth(Node node)
        {
            if (node != null)
            {
                int h = 1 + Math.Max(Depth(node.Left), Depth(node.Right));
                return h;
            }
            return 0;
        }
        public int ElementsSum(Node node)
        {
            if (node == null) return 0;
            return node.data + ElementsSum(node.Left) + ElementsSum(node.Right);
        }
    }
}
