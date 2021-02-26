

namespace LinkedLists
{
    public class LinkedLists<T>
    {

        private class Node
        {
            public Node Next;
            public T Data;
        }
        public int count { get; private set; }
        private Node head = new Node();
        private Node tail;
        public void AddNode(T t)
        {
            if (tail == null)
            {
                head.Next = head;
                head.Data = t;
                tail = head;
            }
            else
            {
                Node newNode = new Node();
                tail.Next = newNode;
                newNode.Data = t;
                tail = newNode;
            }
            count += 1;
        }

        public bool Contains(T t)
        {
            if (IndexOf(t) != -1)
            {
                return true;
            }
            return false;
        }
        public int IndexOf(T t)
        {
            Node current = head;
            int count = 0;
            do
            {
                if ((current.Data).Equals(t))
                {
                    return count;
                }
                current = current.Next;
                count += 1;
            } while (current != null);
            return -1;
        }
        public string Remove(T t)
        {
            return RemoveAt(IndexOf(t));
        }
        public string RemoveAt(int index)
        {
            Node current = head;
            if (index == 0)
            {
                head = current.Next;
                count -= 1;
            }
            else
            {
                for (int i = 0; i < index - 1; i += 1)
                {
                    current = current.Next;
                }
                current.Next = (current.Next).Next;
                count -= 1;
            }
            return "done";
        }
        public void Clear()
        {

            tail = null;
            head = null;

            count = 0;
        }
        public T This(int index)
        {
            return GetNode(index).Data;
        }

        private Node GetNode(int index)
        {
            if (index > count) return null;
            var current = tail;
            int i = 0;
            while (i < index)
            {
                i += 1;
                current = current.Next;
            }

            return current;
        }

    }
}

