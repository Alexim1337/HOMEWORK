Console.Clear();
int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}
// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.


// int columnsVol = ReadInt("Введите количество столбцов: ");
// int linesVol = ReadInt("Введите количество строк: ");
// double[,] array = new double[linesVol, columnsVol];
// FillArrayRandomNumbers(array);
// PrintArray(array);

// void FillArrayRandomNumbers(double[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = Convert.ToDouble(new Random().Next(-100, 100)) / 10;
//         }
//     }
// }

// void PrintArray(double[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i, j] + " ");
//         }
//         Console.WriteLine("");
//     }
// }



// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

// Console.Write("Введите строку: ");
// int pos1 = Convert.ToInt32(Console.ReadLine()) - 1;
// Console.Write("Введите столбец: ");
// int pos2 = Convert.ToInt32(Console.ReadLine()) - 1;
// int n = 5;
// int m = 7;
// Random random = new Random();
// int[,] arr = new int[n, m];
// Console.WriteLine("Исходный массив: ");

// for (int i = 0; i < arr.GetLength(0); i++)
// {
//     for (int j = 0; j < arr.GetLength(1); j++)
//     {
//         arr[i, j] = random.Next(10, 99);
//         Console.Write("{0} ", arr[i, j]);
//     }
//     Console.WriteLine();
// }

// if (pos1 < 0 | pos1 > arr.GetLength(0) - 1 | pos2 < 0 | pos2 > arr.GetLength(1) - 1)
// {
//     Console.WriteLine("Элемент не существует  ");
// }
// else
// {
//     Console.WriteLine("Значение элемента массива = {0}", arr[pos1, pos2]);
// }




//Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Random random = new Random();
// int[,] arr = new int[random.Next(1, 10), random.Next(1, 10)];
// for (int i = 0; i < arr.GetLength(0); i++)
// {
//     for (int j = 0; j < arr.GetLength(1); j++)
//     {
//         arr[i, j] = random.Next(1, 10);
//         Console.Write(arr[i, j] + " ");
//     }
//     Console.WriteLine();
// }
// Console.WriteLine("---------------------------");

// for (int j = 0; j < arr.GetLength(1); j++)
// {
//     double sum = 0;
//     for (int i = 0; i < arr.GetLength(0); i++)
//     {
//         sum += arr[i, j];
//     }
//     Console.Write($"{ sum / arr.GetLength(0)} ");
// }
