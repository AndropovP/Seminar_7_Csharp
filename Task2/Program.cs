// Задача 2: Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает 
// значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// 1, 7 -> такого числа в массиве нет
// 2, 1 -> 4

int[,] CreateArray(int rows, int column)
{
    int[,] arrayD2 = new int[rows, column];
    for (int i = 0; i < arrayD2.GetLength(0); i++)
    {
        for (int j = 0; j < arrayD2.GetLength(1); j++)
        {
            arrayD2[i, j] = new Random().Next(1, 10);
        }
    }
    return arrayD2;
}

void ShowArray(int[,] array)
{
     for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write($"{array[i,j]}\t");
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

int Fine1Element(int[,] array, int rows, int column)       
{
    if (rows > 0 && rows <= array.GetLength(0) && column > 0 && column <= array.GetLength(1)) 
        return array[rows - 1, column - 1];
    else return (-1);
}


int row = ReadInt("Введите номер столроки ->\t");
int col = ReadInt("Введите номер столбца ->\t");
int[,] arr = CreateArray(4,4);
int num = Fine1Element(arr, row, col);
if (num == -1)
{
    System.Console.WriteLine($"Tакого числа в массиве нет.");
}
else
{
ShowArray(arr);
System.Console.WriteLine($"В массиве с координатами: строка {row}, столбец {col} находится элемент {num}.");
}