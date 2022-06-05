MyArrayList<int> nums = new MyArrayList<int>();

nums.Add(5);
nums.Add(6);
nums.Add(1);
nums.Add(7);

//Console.WriteLine(nums.RemoveAt(0));
Console.WriteLine(nums.RemoveAt(-1));

Console.WriteLine($"Capacity: {nums.Capacity}");
Console.WriteLine($"Count: {nums.Count}");
nums.Print();