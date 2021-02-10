using System;

public class Program
{
    static void Main()
    {
        const int a = -5;
        const int b = 0;
        const int c = 4;
        const int d = 9;

        bool isTrue1 = !(c % 2 == 0); //false

        bool isTrue2 = !(d % 2 == 0) && true; //true

        bool isTrue3 = d != c && d == a && b == 0; //false

        bool isTrue4 = !(d == c + 5) || c == 5 - 2; //false

        bool isTrue5 = c > 9 || d > 9 || b >= 0; //true

        bool isTrue6 = isTrue4 && isTrue5; //false

        bool isTrue7 = isTrue3 || isTrue2 || isTrue1; //true

    }
}

