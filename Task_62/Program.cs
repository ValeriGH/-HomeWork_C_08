// Напишите программу, которая заполнит спирально массив 4 на 4.


void InputMatrix(int[,] matrix)
{
    int count = 1;
    int istart = 0;
    int jstart = 0;
    int ilast = matrix.GetLength(0) - 1;
    int jlast = matrix.GetLength(1) - 1;
    while (count <= matrix.GetLength(0) * matrix.GetLength(1))
    {
        for (int j = jstart; j <= jlast; j++)
            matrix[istart, j] = count++;
        istart++;

        for (int i = istart; i <= ilast; i++)
            matrix[i, jlast] = count++;
        jlast--;

        if (istart <= ilast)
        {
            for (int j = jlast; j >= jstart; j--)
                matrix[ilast, j] = count++;
            ilast--;
        }
        if (jstart <= jlast)
        {
            for (int i = ilast; i >= istart; i--)
                matrix[i, jstart] = count++;
            jstart++;
        }
    }

}

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

Console.Clear();
int n = 5;
Console.WriteLine($"Матрица размером {n} x {n}:");
int[,] matrix = new int[n, n];
InputMatrix(matrix);
PrintMatrix(matrix);