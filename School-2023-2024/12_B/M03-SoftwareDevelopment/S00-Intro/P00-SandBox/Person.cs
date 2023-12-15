
public abstract class Person
{
        protected Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public string Name { get; private set; }
        public int Age { get; private set; }


    public virtual void PrintInfo()
        {
            Console.WriteLine($"{GetType().Name}: {Name}, {Age}");
        }

        public abstract void PrintAge();


    }
