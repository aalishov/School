using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainsSkeleton
{
    public class Deque<T>
    {
        private const int DefaultCapacity = 16;
        private T[] frontBuffer;
        private T[] backBuffer;

        public Deque(int capacity)
        {
            frontBuffer = new T[capacity];
            backBuffer = new T[capacity];
        }
        public Deque() : this(DefaultCapacity) { }
        public Deque(IEnumerable<T> collection)
                : this(collection.Count()) { }


        public int BackCount { get; private set; }
        public int FrontCount { get; private set; }
        public int Count
        {
            get
            {
                return BackCount + FrontCount;
            }
        }

        public void AddBack(T item)
        {
            if (backBuffer.Length == BackCount)
            {
                GrowBack();
            }
            this.backBuffer[this.BackCount] = item;
            this.BackCount++;
        }

        private void GrowBack()
        {
            T[] copy = backBuffer.ToArray();
            backBuffer = new T[copy.Length * 2];
            Array.Copy(copy, backBuffer, copy.Length);
        }

        public void AddFront(T item)
        {
            if (frontBuffer.Length == FrontCount)
            {
                GrowFront();
            }
            this.frontBuffer[frontBuffer.Length - (1 + this.FrontCount)] = item;
            this.FrontCount++;
        }
        private void GrowFront()
        {
            T[] copy = frontBuffer.ToArray();
            frontBuffer = new T[copy.Length * 2];
            Array.Copy(copy, 0, frontBuffer, frontBuffer.Length - copy.Length, copy.Length);
        }

        public T GetFront()
        {
            if (FrontCount <= 0)
            {
                return default(T);
            }
            return frontBuffer[frontBuffer.Length - FrontCount];
        }

        public T GetBack()
        {
            if (BackCount <= 0)
            {
                return default(T);
            }
            return backBuffer[BackCount - 1];
        }

        public T RemoveBack()
        {
            if (BackCount <= 0)
            {
                return default(T);
            }
            T item = backBuffer[BackCount - 1];
            backBuffer[BackCount - 1] = default(T);
            BackCount--;
            return item;
        }

        public T RemoveFront()
        {
            if (FrontCount <= 0)
            {
                return default(T);
            }
            T item = frontBuffer[frontBuffer.Length - FrontCount];
            frontBuffer[frontBuffer.Length - FrontCount] = default(T);
            FrontCount--;
            return item;
        }
    }
}
