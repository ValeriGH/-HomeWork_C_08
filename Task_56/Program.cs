// Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]}\t");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

void InputMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(-100, 101);
        }
    }
}

void FindMinSum(int[,] matrix) 
{
    int[] minSum = new int[matrix.GetLength(0)];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sum += matrix[i, j];
        }
        minSum[i] = sum;
    }

    int minstr = 0;
    int temp = minSum[0];
    for (int i = 1; i < minSum.Length; i++)
    {        
        if (minSum[i] < temp)
        {
            minstr = i;
        }
    }
    Console.WriteLine($"Строка с наименьшей суммой: {minstr + 1}");
    
}

Console.Clear();
int n = new Random().Next(2, 6);
int m = new Random().Next(2, 6);
Console.WriteLine($"Матрица размером {n} x {m}:");
int[,] matrix = new int[n, m];
InputMatrix(matrix);
PrintMatrix(matrix);
FindMinSum(matrix);