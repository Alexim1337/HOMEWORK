int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

Console.Clear();
// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.


int num = ReadInt("Введите число:");
int num1 = ReadInt("Введите степень в которую хотите возвести число:");
int prod = num;

for (int i = 1; i < num1; i++)
{
    prod = prod * num;
}
Console.WriteLine($"{num} в степени {num1} = {prod}");


// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.


int number = ReadInt("Введите число: ");
int sum = 0;
while (number > 0)
{
    int i = number % 10;
    number = number / 10;
    sum = sum + i;
}
Console.Write($"{sum}");


// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.


int[] nums = new int[8];
Console.Write("[");

for (int i = 0; i < nums.Length; i++)
{
    nums[i] = new Random().Next(0, 11);
    Console.Write(" " + Method(i) + " ");
}
Console.Write("]");

int Method(int a)
{
    return nums[a];
}