        
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
        public void Inorder(TNode Root,int count = 0)
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
