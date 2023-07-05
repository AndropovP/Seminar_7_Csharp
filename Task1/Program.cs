// Задача 1: Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5  7    -2   -0,2
// 1   -3,3   8   -9,9
// 8    7,8  -7,1  9

double[,] CreateArray(int rows, int column)
{
    double[,] arrayD2 = new double[rows, column];
    Random random = new Random();
    for (int i = 0; i < arrayD2.GetLength(0); i++)
    {
        for (int j = 0; j < arrayD2.GetLength(1); j++)
        {
            arrayD2[i, j] = 10 * random.NextDouble();
        }
    }
    return arrayD2;
}

void ShowArray(double[,] array)
{
     for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write($"{array[i,j]:f1}\t");
        }
        System.Console.WriteLine();
    }
}

    int ReadInt(string message)
    {
        Console.Write($"{message} ");
        string inputedString = Console.ReadLine();
        if (int.TryParse(inputedString, out int convertedInt))
        {
            return convertedInt;
        }

        System.Console.WriteLine("Вы ввели не число!");
        Environment.Exit(0);
        return 0;
    }

    int rows = ReadInt("Введите количество строк -> \t");
    int column = ReadInt("Введите количество столбцов -> \t");
    double[,] arr = CreateArray(rows, column);
    ShowArray(arr);
