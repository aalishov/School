
public class Program
{
    public static void Main()
    {

        string[] names = Console.ReadLine().Split(", ").ToArray();
        for (int i = 0; i < names.Length; i++)
        {
            if (names[i].Length >= 3 && names[i].Length <= 9)
            {
                bool isValid = true;
                foreach (char symbol in names[i])
                {
                    if (!(char.IsLetter(symbol) || char.IsNumber(symbol) || symbol == '-' || symbol == '_'))
                    {
                        isValid = false;
                        break;
                    }
                }
                if (isValid)
                {
                    Console.WriteLine(names[i]);
                }
            }
        }
    }
}

public class MyStack<T>
{

    T[] items;
    int currentItemIndex = 0;

    public MyStack()
    {
        items= new T[10];
    }
    public void Push(T item)
    {
        items[currentItemIndex]=item;
    }

    public T Pop()
    {
        return items[items.Length - 1];
    }
}