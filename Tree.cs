using System;
using System.Collections.Generic;
using System.Text;
namespace LinkedLists
{
    class Tree
    {
        public class TNode
        {
            public TNode NextL;
            public TNode NextR;
            public int data;
            public TNode(int data = default)
            {
                this.data = data;
            }
        }
        private TNode root = new TNode();
        public Tree(int[] numbers)
        {
            foreach (int i in numbers)
            {
                insert((int)i);
            }
        }
        public void insert(int i)
        {
            TNode current;
            TNode newTNode = new TNode((int)i);
            current = root;
            if (root.data == default)
            {
                root.data = i;
            }
            else
            {
                do
                {
                    if (current.data > i)
                    {
                        if (current.NextL == null)
                        {
                            current.NextL = newTNode;
                            break;
                        }
                        current = current.NextL;
                    }
                    else
                    {
                        if (current.NextR == null)
                        {
                            current.NextR = newTNode;
                            break;
                        }
                        current = current.NextR;
                    }
                } while (current.data != i);
            }
        }
        public void Remove(char i)
        {
            this.root = Remove(this.root, (int)i);
        }
        private TNode Remove(TNode parent, int key)
        {
            if (parent == null) return parent;

            if (key < parent.data) parent.NextL = Remove(parent.NextL, key);
            else if (key > parent.data)
                parent.NextR = Remove(parent.NextR, key);
            else
            {
                if (parent.NextL == null)
                    return parent.NextR;
                else if (parent.NextR == null)
                    return parent.NextL;
                parent.data = MinValue(parent.NextR);
                parent.NextR = Remove(parent.NextR, parent.data);
            }

            return parent;
        }
        private int MinValue(TNode node)
        {
            int minv = node.data;

            while (node.NextL != null)
            {
                minv = node.NextL.data;
                node = node.NextL;
            }

            return minv;
        }
        public bool BinarySearch(int Nemo, int count = 0, TNode Dory = default)
        {
            if (count == 0) Dory = root;
            if (Dory == null) return false;
            if (Dory.data == Nemo) return true;
            if (Dory.data > Nemo)
            {
                return BinarySearch(Nemo, count = 1, Dory.NextL);
            }
            return BinarySearch(Nemo, count = 1, Dory.NextR);
        }
        public void Preorder(TNode Root = null, int count = 0)
        {
            if (count == 0) Root = root;
            if (Root != null)
            {
                Console.Write((char)Root.data);
                Preorder(Root.NextL, count = 1);
                Preorder(Root.NextR, count = 1);
            }
        }
        public void Inorder(TNode Root = null, int count = 0)
        {
            if (count == 0) Root = root;
            if (Root != null)
            {
                Inorder(Root.NextL, count = 1);
                Console.Write((char)Root.data);
                Inorder(Root.NextR, count = 1);
            }
        }
        public void Postorder(TNode Root = null, int count = 0)
        {
            if (count == 0) Root = root;
            if (Root != null)
            {
                Postorder(Root.NextL, count = 1);
                Postorder(Root.NextR, count = 1);
                Console.Write((char)Root.data);
            }
        }
    }
}
