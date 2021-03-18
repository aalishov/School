using System;


class Program
{
    static void Main(string[] args)
    {
        string s = "Hello World!";
        char[] arr = s.ToCharArray();
        arr[arr.Length - 1] = '?';
        //Array.Reverse(arr);  //Обръщане
        //Array.Sort(arr);      //Сортиране
        Console.WriteLine(string.Join("",arr));
    }
}

