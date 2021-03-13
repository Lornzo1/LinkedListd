using System;
using System.Collections.Generic;
using System.Text;
namespace LinkedLists
{
    class Tree
    { 
        private class TNode
        {
            public TNode NextL;
            public TNode NextR;
            public int data;
            public TNode (int data = default)
            {
                this.data = data;
            }
        }
        private TNode root = new TNode();
        public Tree(int[] numbers)
        {
            foreach (int i in numbers)
            {
                insert(i);
            }
        }
        public void insert(int i)
        {
            TNode current;
            TNode newTNode = new TNode(i);
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
        public bool BinarySearch(int Nemo)
        {
            TNode Dory = root;
            while (Dory.data != Nemo)
            {
                if (Dory.data > Nemo)
                {
                    Dory = Dory.NextL;
                }
                else
                {
                    Dory = Dory.NextR;
                }
                if (Dory == null) return false;
            }
            return true;
        }
        public void Preorder(TNode Root, int count = 0)
        {
            if (count == 0) Root = root;
            if (Root != null)
            {
                Console.WriteLine(Root.data);
                Preorder(Root.NextL, count = 1);
                Preorder(Root.NextR, count = 1);
            }
        }
        public void Inorder(TNode Root, int count = 0)
        {
            if (count == 0) Root = root;
            if (Root != null)
            {
                Inorder(Root.NextL, count = 1);
                Console.WriteLine(Root.data);
                Inorder(Root.NextR, count = 1);
            }
        }
        public void Postorder(TNode Root, int count = 0)
        {
            if (count == 0) Root = root;
            if (Root != null)
            {
                Postorder(Root.NextL, count = 1);
                Postorder(Root.NextR, count = 1);
                Console.WriteLine(Root.data);
            }
        }
    }
}
