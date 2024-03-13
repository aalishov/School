public class Program
{
    public static void Main()
    {
        bool[] arr1 = new bool[5];
        double[] arr2 = new double[10];
        arr2[5] = 5;
        int[] arr3 = new int[] { 5, 10, 15 };

        string items1 = "10 35 20 25 20";
        string items2 = "False,True,False,True";
        int[] arr4 = items1.Split(" ").Select(int.Parse).ToArray();
        bool[] arr5 = items2.Split(",").Select(bool.Parse).ToArray();

        bool first = arr5[0];
        bool last = arr5[arr5.Length - 1];

        foreach (var item in arr4)
        {
            Console.WriteLine(item);
        }


        Array.Sort(arr4);
        Array.Reverse(arr4);
        Console.WriteLine(string.Join(" ", arr4));
        

        int[] arr6 = new int[10];
        //for (int i = 0; i < 2; i++)
        //{
        //    arr6[i] = arr4[i];
        //}
        Array.Copy(arr4, arr6, 2);


        //Array.Copy(arr4, 2, arr6, 8, 2);
        MyArrayCopy(arr4, 2, arr6, 7, 3);
        Console.WriteLine(string.Join(" ", arr6));

        Console.WriteLine(Array.LastIndexOf(arr6,90));
        Console.WriteLine(Array.LastIndexOf(arr6, 20));
        Console.WriteLine(Array.IndexOf(arr6, 20));
    }
    public static void MyArrayCopy<T>(T[] sorceArr, int sourceStartIndex, T[] destinationArr, int destinationStartIndex, int length)
    {
        for (int i = destinationStartIndex; i < (destinationStartIndex + length); i++)
        {
            destinationArr[i] = sorceArr[sourceStartIndex];
            sourceStartIndex++;
        }
    }
}
