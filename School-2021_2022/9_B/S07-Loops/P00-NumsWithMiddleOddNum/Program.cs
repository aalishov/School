for (int i = 100; i < 1000; i++)
{
    //171/10=17
    //17%10=7
    int num = i / 10;
    int remainder = num % 10;
    if (remainder % 2 == 1)
    {
        Console.WriteLine(i);
    }
};
