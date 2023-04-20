using System;

public class Program
{
    public static void Main()
    {
        var s = string.Empty;
        var s1 = "";
        var s2 = "   ";
        var s3 = "First line Read line";

        char c = s3[2];

        Console.WriteLine(s3);
        var r1 = s3.IndexOf("line");
        Console.WriteLine($"s3.IndexOf(\"line\") => {r1}");
        var r2 = s3.LastIndexOf("line");
        Console.WriteLine($"s3.LastIndexOf(\"line\") =>{r2}");
        var r3 = s3.LastIndexOf("read");
        Console.WriteLine($"s3.LastIndexOf(\"read\") => {r3}");
        var r4 = s3.IndexOf("read");
        Console.WriteLine($"s3.IndexOf(\"read\") => {r4}");
        var r5 = s3.Substring(6, 4);
        Console.WriteLine($"s3.Substring(6, 4) => {r5}");
        var r6 = s3.Replace("line", "*");
        Console.WriteLine($"s3.Replace(\"line\", \"*\") => {r6}");
        var r7 = s3.ToLower();
        Console.WriteLine($"s3.ToLower() => {r7}");
        var r8 = s3.ToUpper();
        Console.WriteLine($"s3.ToUpper() => {r8}");
        var r9 = s3.ToCharArray();
        for (int i = 0; i < r9.Length; i++)
        {
            if (i % 2 == 0)
            {
                int code = r9[i] + 10;
                r9[i] = (char)code;
            }
            else
            {
                int code = r9[i] - 5;
                r9[i] = (char)code;
            }
        }
        var r10 = new string(r9);
        Console.WriteLine(r10);
        var r11 = r10.ToCharArray();
        for (int i = 0; i < r9.Length; i++)
        {
            if (i % 2 == 0)
            {
                int code = r11[i] - 10;
                r11[i] = (char)code;
            }
            else
            {
                int code = r11[i] + 5;
                r11[i] = (char)code;
            }
        }
        var r12 = new string(r11);
        Console.WriteLine(r12);

        var r13 = s3.Remove(6, 5);
        Console.WriteLine($"s3.Remove(6, 5) => {r13}");

        string s4 = "   asda    ";
        string s5 = s4.TrimEnd() + "asdasd";
        Console.WriteLine(s5);
    }
}
public class Student
{
    public Student(string firstName)
    {
        FirstName = firstName;
    }

    public string FirstName { get; private set; }
}
