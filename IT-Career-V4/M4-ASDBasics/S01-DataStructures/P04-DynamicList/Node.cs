namespace P04_DynamicList
{
    public class Node
    {
        // Елемент
        private object element;
        public object Element
        {
            get { return this.element; }
            set { this.element = value; }
        }

        // Следващ елемент
        private Node next;
        public Node Next
        {
            get { return this.next; }
            set { this.next = value; }
        }

        // Конструктор
        public Node(object element, Node prevNode)
        {
            this.element = element;
            prevNode.next = this;
        }

        // Конструктор
        public Node(object element)
        {
            this.element = element;
            next = null;
        }

    }
}
