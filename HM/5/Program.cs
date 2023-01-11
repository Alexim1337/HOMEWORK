Console.Clear();
int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}
// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

/* 
int length = ReadInt("Введите размер массива: ");
int[] myArray = CreateRandomArray(length);
ShowArray(myArray);
int count = 0;
{
    for (int i = 0; i < myArray.Length; i++)
    {
        if (myArray[i] % 2 == 0)
            count++;
    }
}
Console.WriteLine($"всего {myArray.Length} чисел, {count} из них чётные");


int[] CreateRandomArray(int size)
{
    int[] array = new int[size];

    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(100, 1000);
    }
    return array;
}
void ShowArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}
 */



// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

/* 
int size = ReadInt("Введите размер массива: ");
int[] myArray = CreateRandomArray(size);
ShowArray(myArray);
int count = 0;

for (int i = 0; i < myArray.Length; i += 2)
    count = count + myArray[i];

Console.WriteLine($"всего {myArray.Length} чисел, сумма элементов на нечётных позициях = {count}");


int[] CreateRandomArray(int size)
{
    int[] array = new int[size];

    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(1, 100);
    }
    return array;
}
void ShowArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}
 */


// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
/* 
int size = ReadInt("Введите размер массива: ");
double[] myArray = CreateRandomArray(size);
ShowArray(myArray);
double min = myArray.Max();
double max = myArray.Min();

for (int i = 0; i < myArray.Length; i++)
{
    if (myArray[i] > max)
    {
        max = myArray[i];
    }
    if (myArray[i] < min)
    {
        min = myArray[i];
    }
}

Console.WriteLine($"всего {myArray.Length} чисел. Максимальное значение = {max}, минимальное значение = {min}");
Console.WriteLine($"Разница между максимальным и минимальным значением = {Math.Round(max - min, 1)}");

double[] CreateRandomArray(int size)
{
    double[] array = new double[size];

    for (int i = 0; i < size; i++)
    {
        array[i] = Convert.ToDouble(new Random().Next(10, 1000)) / 10;
    }
    return array;
}
void ShowArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}
 */