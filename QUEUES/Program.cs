
using System;
using System.Collections.Generic;

namespace QUEUES
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> quese = new Queue<int>();
            quese.Enqueue(1);
            quese.Enqueue(2);
            quese.Enqueue(3);
            reverse(quese);
        }

        private static void reverse(Queue<int> quese)
        {
            
            Stack<int> stack = new Stack<int>();
            var queseLength = quese.ToArray().Length;
            var count = queseLength;

            while(stack.Count != queseLength)
            {
                stack.Push(quese.Dequeue());
            }
            while(count != 0)
            {
                quese.Enqueue(stack.Pop());
                count--;
            }
        }
    }
}
