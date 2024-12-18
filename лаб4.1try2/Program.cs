using System;

class Program
{
    static void Main()
    {
        int[,] A = new int[5, 10];
        Random random = new Random();
        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 10; j++)
            {
                A[i, j] = random.Next(-100, 101);
            }
        }
        Console.WriteLine("Исходный массив:");
        PrintArray(A);
        int maxAbsElement = FindMaxAbsElement(A);
        Console.WriteLine($"Наибольший по модулю элемент: {maxAbsElement}");
        double[,] B = new double[5, 10];
        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 10; j++)
            {
                B[i, j] = (double)A[i, j] / maxAbsElement;
            }
        }
        Console.WriteLine("Новая матрица:");
        PrintArray(B);
    }
    static int FindMaxAbsElement(int[,] array)
    {
        int maxAbs = array[0, 0];

        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                if (Math.Abs(array[i, j]) > Math.Abs(maxAbs))
                {
                    maxAbs = array[i, j];
                }
            }
        }

        return maxAbs;
    }
    static void PrintArray<T>(T[,] array)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                Console.Write($"{array[i, j],4} ");
            }
            Console.WriteLine();
        }
    }
}
