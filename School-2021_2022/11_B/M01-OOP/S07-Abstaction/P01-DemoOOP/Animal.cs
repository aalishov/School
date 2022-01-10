using System;

namespace P01_DemoOOP
{
    public abstract class Animal
    {
        private string name;
        private int age;

        public Animal(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        public string Name
        {
            get { return name; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException($"{this.GetType().Name} {nameof(this.Name).ToLower()}....");
                }
                name = value;
            }
        }
        public int Age
        {
            get
            {
                if (age <= 0)
                {
                    return 1;
                }
                else
                {
                    return age;
                }
            }
            set
            {
                age = value;
            }
        }

        public abstract void MakeNoise();

        public override string ToString()
        {
            return $"{this.GetType().Name} {nameof(this.Name).ToLower()}: {this.Name},  {nameof(this.Age)}: {this.Age}";
        }
    }
}
