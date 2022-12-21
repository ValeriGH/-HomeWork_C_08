// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, 
// добавляя индексы каждого элемента.

void InputArray(int[,,] array)
{
    int kk = array.GetLength(0) * array.GetLength(1) * array.GetLength(2);
    int[] rand = new int[kk];
    int l = 0;
    int num;
    while (l < rand.Length)
    {
        num = new Random().Next(10, 100);
        bool b = true;
        for (int j = 0; j < l; j++)
        {
            if (num == rand[j])
            {
                b = false;
                break;
            }
        }
        if (b)
        {
            rand[l] = num;
            l++;
        }

    }
    //Console.WriteLine($"{string.Join(" ", rand)}");

    l = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                array[i, j, k] = rand[l++];               
                Console.Write($"{array[i, j, k]}({i},{j},{k}) ");
            }
            Console.WriteLine();
        }
    }
}

Console.Clear();
Console.Write("Введите размер массива: ");
int[] size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
int[,,] array = new int[size[0], size[1], size[2]];
InputArray(array);