namespace P01_Trees
{
    using System.Collections.Generic;
    using System.Text;
    public class Tree<T>
    {
        // Стойност на възела
        private T value;
        // Деца на възела
        private IList<Tree<T>> children;
        /// Конструктор
        public Tree(T value, params Tree<T>[] children)
        {
            this.value = value;
            this.children = children;
        }
        //Рекурсивен метод за представяне на дървото, като стринг
        public string PrintS(int indent = 0)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(new string(' ', 2 * indent));
            sb.AppendLine(this.value.ToString());
            foreach (var child in this.children)
            {
                sb.Append(child.PrintS(indent + 1));
            }
            return sb.ToString();
        }
        // Търсене в дълбочина
        private void DFS(Tree<T> tree, List<T> order)
        {
            foreach (var child in tree.children)
            {
                this.DFS(child, order);
            }
            order.Add(tree.value);
        }
        /// Ред на посещаване на възлите от дървото
        public IEnumerable<T> OrderDFS()
        {
            List<T> order = new List<T>();
            this.DFS(this, order);
            return order;
        }
        public IEnumerable<T> OrderBFS()
        {
            List<T> order = new List<T>();
            Queue<Tree<T>> visited = new Queue<Tree<T>>();
            visited.Enqueue(this);
            while (visited.Count > 0)
            {
                var next = visited.Dequeue();
                order.Add(next.value);
                foreach (var child in next.children)
                {
                    visited.Enqueue(child);
                }
            }
            return order;
        }
    }
}