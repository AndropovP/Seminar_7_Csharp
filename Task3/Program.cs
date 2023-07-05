// Задача 3: Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

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

void PrintArray(double[] array)                            //Выводит значения
{
    foreach (double item in array)
    {
        Console.Write($"{item};  ");
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

double[] FaindColumns(int[,] array)
{
    double[] arr = new double[array.GetLength(1)];
    for (int j = 0; j < array.GetLength(1); j++)
    {
        int sum = 0; 
        for (int i = 0; i < array.GetLength(0); i++)
        {   
            sum += array[i, j];
        }
        System.Console.Write($"Сумма {(sum)},  ");
        arr[j]  = sum / array.GetLength(1);
        System.Console.WriteLine($"arr[j] = {arr[j]:f}  ");
    }
    return arr;
     
}

int[,] arr = CreateArray(3,4);
ShowArray(arr);
System.Console.WriteLine();
double[] average = FaindColumns(arr);
System.Console.WriteLine();
System.Console.WriteLine(average.Length);
System.Console.Write($"Среднее арифметическое каждого из {average.Length} столбцов: ");
PrintArray(average);


