using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainsSkeleton
{
    class Deque<T>
    {
        private Stack<T> frontBuffer = new Stack<T>(16);
        private Stack<T> backBuffer = new Stack<T>(16);

        public int Count
        {
            get
            {
                return frontBuffer.Count+backBuffer.Count;
            }
        }

        public void AddBack(T item)
        {
            backBuffer.Push(item);
        }

        public void AddFront(T item)
        {
            frontBuffer.Push(item);
        }
        public T GetFront()
        {
            if (!frontBuffer.Any())
            {
                return default(T);
            }
            return frontBuffer.Peek();
        }

        public T GetBack()
        {
            if (!backBuffer.Any())
            {
                return default(T);
            }
            return backBuffer.Peek();
        }

        public T RemoveBack()
        {
            if (!backBuffer.Any())
            {
                return default(T);
            }
            return backBuffer.Pop();
        }

        public T RemoveFront()
        {
            if (!frontBuffer.Any())
            {
                return default(T);
            }
            return frontBuffer.Pop();
        }
    }
}
