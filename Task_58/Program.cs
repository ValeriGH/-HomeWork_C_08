// Задайте две матрицы. 
// Напишите программу, которая будет находить произведение двух матриц

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
void MultiplyMatrix(int[,] first, int[,] second)
{
    for (int i = 0; i < first.GetLength(0); i++)
    {
        for (int j = 0; j < first.GetLength(1); j++)
        {
            Console.Write($"{first[i, j] * second[i, j]}\t");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

Console.Clear();
int n = new Random().Next(2, 6);
int m = new Random().Next(2, 6);
Console.WriteLine($"Первая матрица размером {n} x {m}:");
int[,] firstMatrix = new int[n, m];
InputMatrix(firstMatrix);
PrintMatrix(firstMatrix);
Console.WriteLine($"Вторая матрица размером {n} x {m}:");
int[,] secondMatrix = new int[n, m];
InputMatrix(secondMatrix);
PrintMatrix(secondMatrix);
Console.WriteLine("Результирующая матрица:");
MultiplyMatrix(firstMatrix, secondMatrix);