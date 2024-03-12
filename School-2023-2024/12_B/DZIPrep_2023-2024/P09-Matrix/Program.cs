using System.Collections.Generic;
using System.Threading.Tasks.Dataflow;

public class Program
{
    static void Main()
    {
        int rowsCount = new Random().Next(3, 9);
        int colsCount = new Random().Next(3, 9);
        int[,] arr = new int[8, 8];
        GenerateMatrix(arr);
        PrintColorMatrix(arr);
        //List<int> aboveMainDiagonal = new List<int>();
        //List<int> belowMainDiagonal = new List<int>();
        //List<int> mainDiagonal = new List<int>();
        //List<int> secondDiagonal = new List<int>();
        //int? centralElement = null;

        //AnalyzeMatrixElements(arr, aboveMainDiagonal, belowMainDiagonal, mainDiagonal, secondDiagonal, ref centralElement);
        //PritnCentralElement(centralElement);
        //PrintMainDiagonal(mainDiagonal);
        //PrintSecondDiagonal(secondDiagonal);
        //PrintElementsAboveMainDiagonal(aboveMainDiagonal);
        //PrintElementsBelowMainDiagonal(belowMainDiagonal);

        List<int> rigthTriangle = new List<int>();
        RightTriangle(arr, rigthTriangle);
        Console.WriteLine(string.Join(" ",rigthTriangle));


        List<int> topTriangle = new List<int>();
        TopTriangle(arr, topTriangle);
        Console.WriteLine(string.Join(" ", topTriangle));


        List<int> leftTriangle = new List<int>();
        LeftTriangle(arr, leftTriangle);
        Console.WriteLine(string.Join(" ", leftTriangle));

        List<int> underTriangle = new List<int>();
        UnderTriangle(arr, underTriangle);
        Console.WriteLine(string.Join(" ", underTriangle));

        PrintTriangles(arr);

    }

    private static void PrintTriangles(int[,] arr)
    {
        Console.ForegroundColor = ConsoleColor.Cyan;
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                if ((i > j) && (i + j) < arr.GetLength(0) - 1)
                {
                    Console.Write($"{arr[i, j],4}");
                }
                else if ((i < j) && (i + j) < arr.GetLength(0) - 1)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write($"{arr[i, j],4}");
                }
              
                else if ((i < j) && (i + j) > arr.GetLength(0) - 1)
                {
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.Write($"{arr[i, j],4}");
                }
                else if ((i > j) && (i + j) > arr.GetLength(0) - 1)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write($"{arr[i, j],4}");
                }
                else
                {
                    Console.Write($"{" ",4}");
                }
            }
            Console.WriteLine();
        }
        Console.ForegroundColor = ConsoleColor.White;
    }


    public static void UnderTriangle(int[,] arr, List<int> list)
    {
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            for (int j = 0; j < arr.GetLength(0); j++)
            {
                if ((i > j) && (i + j) > arr.GetLength(0) - 1)
                {
                    list.Add(arr[i, j]);
                }
            }
        }
    }
    public static void RightTriangle(int[,] arr, List<int> list)
    {
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            for (int j = 0; j < arr.GetLength(0); j++)
            {
                if ((i<j) && (i+j)>arr.GetLength(0)-1)
                {
                    list.Add(arr[i, j]);
                }
            }
        }
    }
    public static void TopTriangle(int[,] arr, List<int> list)
    {
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            for (int j = 0; j < arr.GetLength(0); j++)
            {
                if ((i < j) && (i + j) < arr.GetLength(0) - 1)
                {
                    list.Add(arr[i, j]);
                }
            }
        }
    }
    public static void LeftTriangle(int[,] arr, List<int> list)
    {
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            for (int j = 0; j < arr.GetLength(0); j++)
            {
                if ((i > j) && (i + j) < arr.GetLength(0) - 1)
                {
                    list.Add(arr[i, j]);
                }
            }
        }
    }
    private static void PritnCentralElement(int? centralElement)
    {
        if (centralElement != null)
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine($"Central element: {centralElement}");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }

    private static void AnalyzeMatrixElements(int[,] arr, List<int> aboveMainDiagonal, List<int> belowMainDiagonal, List<int> mainDiagonal, List<int> secondDiagonal, ref int? centralElement)
    {
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                if (i == j)
                {
                    mainDiagonal.Add(arr[i, j]);
                }
                else if (j > i)
                {
                    aboveMainDiagonal.Add(arr[i, j]);

                }
                else if (j < i)
                {
                    belowMainDiagonal.Add(arr[i, j]);

                }

                if (j + i == arr.GetLength(1) - 1 && arr.GetLength(1) <= arr.GetLength(0))
                {
                    secondDiagonal.Add(arr[i, j]);
                }
                else if (j + i == arr.GetLength(0) - 1 && arr.GetLength(1) > arr.GetLength(0))
                {
                    secondDiagonal.Add(arr[i, j]);
                }
                //Find central element (exist when rows or cols are odd)
                if (i == j && j + i == arr.GetLength(1) - 1 && arr.GetLength(1) <= arr.GetLength(0))
                {
                    centralElement = arr[i, j];
                }
                else if (i == j && j + i == arr.GetLength(0) - 1 && arr.GetLength(1) > arr.GetLength(0))
                {
                    centralElement = arr[i, j];
                }
            }
        }
    }

    private static void PrintMatrix(int[,] arr)
    {
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                Console.Write($"{arr[i, j],4}");

            }
            Console.WriteLine();
        }
    }

    private static void GenerateMatrix(int[,] arr)
    {
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                arr[i, j] = new Random().Next(-99, 99);
            }
        }
    }

    //Print color matrix
    private static void PrintColorMatrix(int[,] arr)
    {
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                Console.ForegroundColor = ConsoleColor.White;
                if (i == j)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                }
                else if (j > i)
                {
                    Console.ForegroundColor = ConsoleColor.White;

                }
                else if (j < i)
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                }

                //Print second diagonal
                if (j + i == arr.GetLength(1) - 1 && arr.GetLength(1) <= arr.GetLength(0))
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                }
                else if (j + i == arr.GetLength(0) - 1 && arr.GetLength(1) > arr.GetLength(0))
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                }

                //Print element when main diagonal cross second diagonal (central element)
                if (i == j && j + i == arr.GetLength(1) - 1 && arr.GetLength(1) <= arr.GetLength(0))
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                }
                else if (i == j && j + i == arr.GetLength(0) - 1 && arr.GetLength(1) > arr.GetLength(0))
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                }
                Console.Write($"{arr[i, j],4}");
            }
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();
        }
    }

    private static void PrintMainDiagonal(List<int> mainDiagonal)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"Main diagonal: {string.Join(", ", mainDiagonal)}");
        Console.WriteLine($"\tCount:{mainDiagonal.Count()}");
        Console.WriteLine($"\tSum:{mainDiagonal.Sum()}");
        Console.WriteLine($"\tAverage:{mainDiagonal.Average():f2}");
        Console.WriteLine($"\tMax:{mainDiagonal.Max():f2}");
        Console.WriteLine($"\tMin:{mainDiagonal.Min():f2}");
        Console.ForegroundColor = ConsoleColor.White;
    }

    private static void PrintSecondDiagonal(List<int> secondDiagonal)
    {
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine($"Second diagonal: {string.Join(", ", secondDiagonal)}");
        Console.WriteLine($"\tCount:{secondDiagonal.Count()}");
        Console.WriteLine($"\tSum:{secondDiagonal.Sum()}");
        Console.WriteLine($"\tAverage:{secondDiagonal.Average():f2}");
        Console.WriteLine($"\tMax:{secondDiagonal.Max():f2}");
        Console.WriteLine($"\tMin:{secondDiagonal.Min():f2}");
        Console.ForegroundColor = ConsoleColor.White;
    }

    private static void PrintElementsAboveMainDiagonal(List<int> aboveMainDiagonal)
    {
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine($"Elements above main diagonal: {string.Join(", ", aboveMainDiagonal)}");
        Console.WriteLine($"\tCount:{aboveMainDiagonal.Count()}");
        Console.WriteLine($"\tSum:{aboveMainDiagonal.Sum()}");
        Console.WriteLine($"\tAverage:{aboveMainDiagonal.Average():f2}");
        Console.WriteLine($"\tMax:{aboveMainDiagonal.Max():f2}");
        Console.WriteLine($"\tMin:{aboveMainDiagonal.Min():f2}");
        Console.ForegroundColor = ConsoleColor.White;
    }

    private static void PrintElementsBelowMainDiagonal(List<int> belowMainDiagonal)
    {
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine($"Elements below main diagonal: {string.Join(", ", belowMainDiagonal)}");
        Console.WriteLine($"\tCount:{belowMainDiagonal.Count()}");
        Console.WriteLine($"\tSum:{belowMainDiagonal.Sum()}");
        Console.WriteLine($"\tAverage:{belowMainDiagonal.Average():f2}");
        Console.WriteLine($"\tMax:{belowMainDiagonal.Max():f2}");
        Console.WriteLine($"\tMin:{belowMainDiagonal.Min():f2}");
        Console.ForegroundColor = ConsoleColor.White;
    }


}

