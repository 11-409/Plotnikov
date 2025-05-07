using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackReverseString
{
    class StackReverse
    {
        public void ReverseString()
        {
            Stack <int> stack = new Stack<int>();
            string inputString = Console.ReadLine();
            foreach (char letter in inputString)
            {
                stack.Push(letter);
            }
            if (stack.Count > 0)
            {
                Console.WriteLine(stack.Pop);
            }
        }
    }
}
