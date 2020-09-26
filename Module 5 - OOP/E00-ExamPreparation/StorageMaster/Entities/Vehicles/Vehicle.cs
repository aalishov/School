

namespace StorageMaster.Entities.Vehicles
{
    using StorageMaster.Entities.Products;
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public abstract class Vehicle
    {
        private Stack<Product> productsInTrunk;

        protected Vehicle(int capacity)
        {
            this.Capacity = capacity;
            this.productsInTrunk = new Stack<Product>();
        }

        public int Capacity { get; private set; }

        public IReadOnlyCollection<Product> Trunk
        {
            get
            {
                return productsInTrunk.ToList().AsReadOnly();
            }
        }

        public bool IsFull
        {
            get
            {
                if (Trunk.Sum(p => p.Weight) >= this.Capacity)
                {
                    return true;
                }
                return false;
            }
        }

        public bool IsEmpty
        {
            get
            {
                if (Trunk.Count == 0)
                {
                    return true;
                }
                return false;
            }
        }

        public void LoadProduct(Product product)
        {
            if (IsFull)
            {
                throw new InvalidOperationException("Vehicle is full!");
            }
            this.productsInTrunk.Push(product);
        }

        public Product Unload()
        {
            if (IsEmpty)
            {
                throw new InvalidOperationException("No products left in vehicle!");
            }
            return this.productsInTrunk.Pop();
        }
    }
}
