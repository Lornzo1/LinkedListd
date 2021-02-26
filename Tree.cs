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
        private List<TNode> positions = new List<TNode>();
        private TNode root = new TNode();
        public Tree(int[] numbers)
        {
            foreach (int i in numbers)
            {
                TNode current;
                TNode newTNode  = new TNode(i); 
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
    }
}
