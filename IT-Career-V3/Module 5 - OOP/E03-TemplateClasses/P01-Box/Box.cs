namespace P01_Box
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class Box<T>
    {
        private Stack<T> data;

        public string Color { get; set; }

        public Box(string color)
        {
            this.Color = color;
            this.data = new Stack<T>();
        }

        public void Add(T element)
        {
            this.data.Push(element);
        }

        public T Remove()
        {
            T returnThisElement = data.Pop();

            return returnThisElement;
        }

        public string PrintBoxElements()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{this.Color} box:");
            foreach (var item in data.ToList())
            {
                sb.AppendLine($"Type: {item.GetType().Name}, Value: {item}");
            }
            return sb.ToString().TrimEnd();
        }
    }
}
