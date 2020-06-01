
        private int InOrderTraversal(TreeNode root)
        {
            // base case
            if (root == null)
            {
                return root.val;
            }

            Stack<TreeNode> stack = new Stack<TreeNode>();
            int sum = 0;
            TreeNode tmp = root;

            while( stack.Count > 0 || tmp != null)
            {
                while(tmp != null)
                {
                     stack.Push(tmp);
                     tmp = tmp.left;
                }
                tmp = stack.Pop();
                sum += tmp.val;

                tmp = tmp.right;
            }

            return sum;
        }