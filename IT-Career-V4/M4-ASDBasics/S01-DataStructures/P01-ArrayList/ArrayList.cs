namespace P01_ArrayList
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    public class ArrayList<T> : IEnumerable<T>
    {
        // Масив
        private T[] items;

        // Брой на елементите
        public int Count { get; private set; }
      
        // Капацитет
        public int Capacity { get; private set; }
    
        //Конструктор
        public ArrayList()
        {
            this.Count = 0;
            this.Capacity = 2;
            this.items = new T[this.Capacity];
        }

        //Достъпване на елемент по индекс
        public T this[int index]
        {
            get
            {
                OutOfRange(index);
                return this.items[index];
            }
            set
            {
                OutOfRange(index);
                this.items[index] = value;
            }
        }

    
        // Добавяне на елемент
        public void Add(T item)
        {
            // Разширяване
            if (this.Count == this.Capacity)
            {
                this.Capacity *= 2;
                var temp = this.items;
                this.items = new T[this.Capacity];
                for (int i = 0; i < temp.Count(); i++)
                {
                    this.items[i] = temp[i];
                }
            }
            this.items[this.Count] = item;
            this.Count++;
        }

   
        // Взимане на елемент
        public T Get(int index)
        {
            OutOfRange(index);
            return this.items[index];
        }

        //Задаване на стойност
        public void Set(int index, T item)
        {
            OutOfRange(index);
            this.items[index] = item;
        }
        
        // Премахваме определен индекс
        public T RemoveAt(int index)
        {
            OutOfRange(index);
            var item = this.items[index];
            this.items = items.Take(index).Concat(items.Skip(index + 1)).Concat(new T[1]).ToArray();
            this.Count--;
            // Свиване
            if (this.items.Count() <= this.Capacity / 2)
            {
                if (this.Count < 2) return item;
                this.Capacity /= 2;
                var temp = this.items;
                this.items = new T[this.Capacity];
                for (int i = 0; i < temp.Count(); i++)
                {
                    this.items[i] = temp[i];
                }
            }
            return item;
        }

        // Проверка дали сме в границите
        private void OutOfRange(int index)
        {
            if (index < 0 || index >= this.Count)
            {
                throw new IndexOutOfRangeException();
            }
        }

        // Нумератор
        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < this.items.Count(); i++)
            {
                yield return this.items[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}