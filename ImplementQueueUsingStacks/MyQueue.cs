using System;
using System.Collections.Generic;
using System.Text;

namespace ImplementQueueUsingStacks
{
    //20min
    //Should only reverse if queue count is 0
    public class MyQueue
    {
        Stack<int> queue = new Stack<int>();
        Stack<int> utils = new Stack<int>();
        public void Push(int x)
        {
            utils.Push(x);
        }

        public int Pop()
        {
            
            while(utils.Count > 0)
            {
                queue.Push(utils.Pop());
            }

            int x = queue.Pop();

            while(queue.Count > 0)
            {
                utils.Push(queue.Pop());
            }

            return x;
        }

        public int Peek()
        {
            while (utils.Count > 0)
            {
                queue.Push(utils.Pop());
            }

            int x = queue.Peek();

            while (queue.Count > 0)
            {
                utils.Push(queue.Pop());
            }

            return x;
        }

        public bool Empty()
        {
            return utils.Count == 0;
        }
    }
}
