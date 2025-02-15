﻿namespace FindRoot
{
    public class Tree<T>
    {
        public T Value { get; set; }
        public Tree<T> Parent { get; private set; }
        public List<Tree<T>> Children { get; private set; }

        public Tree(T value, params Tree<T>[] children)
        {
            this.Value = value;
            if (children == null)
            {
                this.Children = new List<Tree<T>>();
            }
            else
            {
                this.Children = children.ToList();
                foreach (var child in children)
                {
                    child.Parent = this;
                }
            }
        }

        public void AddChild(Tree<T> newChild)
        {
            this.Children.Add(newChild);
        }

        public void SetParent(Tree<T> newParent)
        {
            this.Parent = newParent;
        }
    }
}
