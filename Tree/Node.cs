using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tree
{
    public class Node
    {
        public int data; //данные
        public Node Left;
        public Node Right;

        public Node(int x)
        {
            data = x;
            Left = null;
            Right = null;
        }
    }
}
