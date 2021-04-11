using System;
using System.Collections.Generic;
using System.Text;

namespace Abstraction
{
    class queue<T>
    {
        private T[] new_queue;
        public int tail = -1;
        public int head = 0;
        private bool empty = true;
        public queue(int s)
        {
            new_queue = new T[s];
            int len = s;
        }
        public T[] Push(T ToBe)
        {
            int a = new_queue.Length;
            if ((tail+1)%a != head || empty)
            {
                tail = (tail + 1) % a;
                new_queue[tail] = ToBe;
            }
            else Console.WriteLine("overflow");
            empty = false;
            return new_queue;
        }
        public dynamic Dequeue( )
        {
            int l = new_queue.Length-1;
            T a = default;
            if (tail != head+1 && empty == false)
            {
                a = new_queue[head];
                new_queue[head] = default;
                head = (head + 1) % (l+1);
                if (head-1 == tail)
                {
                    empty = true;
                }
            }
            else
            {
                return "Queue is already empty";
            }
            return a;
        }
        public void Output()
        {
            for (int i = 0; i < new_queue.Length; i++)
            {
                Console.Write(new_queue[i]);
            }
            Console.WriteLine(' ');
        }
    }
}
