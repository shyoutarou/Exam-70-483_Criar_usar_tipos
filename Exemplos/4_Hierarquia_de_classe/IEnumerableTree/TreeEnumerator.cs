using System;
using System.Collections;
using System.Collections.Generic;

namespace IEnumerableTree
{
    class TreeEnumerator : IEnumerator<TreeNode>
    {
        // The tree's nodes in their proper order.
        private List<TreeNode> Nodes;

        // The index of the current node.
        private int CurrentIndex;

        // Constructor.
        public TreeEnumerator(TreeNode root)
        {
            Nodes = root.Preorder();
            Reset();
        }

        public TreeNode Current
        {
            get { return GetCurrent(); }
        }
        object IEnumerator.Current
        {
            get { return GetCurrent(); }
        }
        private TreeNode GetCurrent()
        {
            if (CurrentIndex < 0)
                throw new InvalidOperationException();
            if (CurrentIndex >= Nodes.Count)
                throw new InvalidOperationException();
            return Nodes[CurrentIndex];
        }

        public bool MoveNext()
        {
            CurrentIndex++;
            return (CurrentIndex < Nodes.Count);
        }

        public void Reset()
        {
            CurrentIndex = -1;
        }

        public void Dispose()
        {
        }
    }
}
