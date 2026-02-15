public class Program
{
    public static void Main()
    {
        bool isTrue = true; //false
        bool isTrue1 = 5 > 2 * 3;
        bool isTrue2 = 10 != 10;

        bool isTrue3 = 2 > 1 && 5 > 10; //false
        bool isTrue4 = 2 > 1 || 5 > 10; //true

        bool isTrue5 = 'A' == 'B' && 2 * 5 == 8 + 2 && 10 > 5;

        int a = 5;
        bool isTrue6 = a < -5 && a > -10;

        bool isTrue7 = a*2>15 || a< 2*2;

        bool isTrue8 = !true; //false
    }
}

