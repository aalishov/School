LinkedList<int> nums = new LinkedList<int>();
nums.AddFirst(7);
nums.AddFirst(1);
nums.AddLast(10);
nums.AddBefore(nums.Find(7), 6);
Console.WriteLine(String.Join(", ",nums));