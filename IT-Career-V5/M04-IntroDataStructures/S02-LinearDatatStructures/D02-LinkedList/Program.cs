using System.Collections;

LinkedList<int> nums = new LinkedList<int> ();

nums.AddFirst (5);
nums.AddFirst(1);
nums.AddLast (2);

LinkedListNode<int> nodeFive = nums.Find(5);
nums.AddBefore(nodeFive, 4);
nums.AddAfter(nodeFive, 6);

LinkedListNode<int> nodeAfterFive = nodeFive.Next;

Console.WriteLine(String.Join(", ",nums));

