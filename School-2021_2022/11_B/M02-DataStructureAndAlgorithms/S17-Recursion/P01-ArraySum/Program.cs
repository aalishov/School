// See https://aka.ms/new-console-template for more information

int[] arr= new int[] { 1,2,3,4,5};
Console.WriteLine(ArraySum(arr));

static int ArraySum(int[] arr, int index=0)
{
    if (index == arr.Length-1)
    {
        return arr[index];
    }

    return arr[index]+ArraySum(arr,index+1);
}