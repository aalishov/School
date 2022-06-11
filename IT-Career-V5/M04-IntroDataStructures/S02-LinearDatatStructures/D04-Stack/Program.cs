//LIFO - Last In - First Out

ArrayStack<int> stack = new ArrayStack<int>();
stack.Push(1);
stack.Push(2);
stack.Push(3);
stack.Push(4);

Console.WriteLine(stack.Contains(7));
Console.WriteLine(stack.Contains(2));

int element=stack.Peek();

while (stack.Count > 0)
{
    Console.WriteLine(stack.Pop());
}



