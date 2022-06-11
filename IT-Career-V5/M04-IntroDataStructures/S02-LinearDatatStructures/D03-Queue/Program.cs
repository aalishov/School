CircularQueue<int> q = new CircularQueue<int>();


//FIFO - FirstIn-FirstOut
Queue<int> nums = new Queue<int>();

//Добавяне
nums.Enqueue(1);
nums.Enqueue(2);
nums.Enqueue(3);
nums.Enqueue(4);

Console.WriteLine(nums.Contains(7));
Console.WriteLine(nums.Contains(2));

//Връща елемента, който трябва да бъде премахнат, не променя броя на елементите
int element = nums.Peek();


//Премахване на елементи
while (nums.Count > 0)
{
    int firstElement = nums.Dequeue();
    Console.WriteLine(firstElement);
}


