namespace TrainsSkeleton
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class Deque<T>
    {
        private const int DefaultCapacity = 16;

        private readonly List<T> items;
        public Deque() : this(DefaultCapacity)
        {
            //празен конструктор, задава капацитета на дека на стойността по подразбиране (16)
        }
        public Deque(int capacity)
        {
            //създава дека с точно зададен капацитет
            this.items = new List<T>(capacity);
        }
        public Deque(IEnumerable<T> collection)
             : this(collection.Count())
        {
            //създава дека с капацитет съответстващ на посочената колекция и прехвърля елементите от колекцията в дека
            this.items.AddRange(collection);
        }
        public int Capacity { get { return this.items.Capacity; } } //показва капацитета
        public int Count { get { return this.items.Count; } } //показва броят елементи

        public void AddFront(T item)
        {
            //добавя елемент отпред
            this.items.Insert(0, item);
        }
        public void AddBack(T item)
        {
            //добавя елемент отзад
            this.items.Add(item);
        }
        public T RemoveFront()
        {
            //връща и премахва елемента отпред
            if (this.items.Any())
            {
                T front = this.items[0];
                this.items.RemoveAt(0);
                return front;
            }
            throw new IndexOutOfRangeException("Index was out of range.");
        }
        public T RemoveBack()
        {
            //връща и премахва елемента отзад
            if (this.items.Any())
            {
                T back = this.items[this.Count - 1];
                this.items.RemoveAt(this.Count - 1);
                return back;
            }
            throw new IndexOutOfRangeException("Index was out of range.");
        }
        public T GetFront()
        {
            //връща, без да премахва, елемента отпред
            if (this.items.Any())
            {
                T front = this.items[0];
                return front;
            }
            throw new IndexOutOfRangeException("Index was out of range.");
        }
        public T GetBack()
        {
            //връща, без да премахва, елемента отзад
            if (this.items.Any())
            {
                T back = this.items[this.Count - 1];
                return back;
            }
            throw new IndexOutOfRangeException("Index was out of range.");
        }
    }
}
