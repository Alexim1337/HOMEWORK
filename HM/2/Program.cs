// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// Console.Write(("Введите трехзначное число: "));
//     int num = Convert.ToInt32(Console.ReadLine());


// if (num < 100 || num > 1000)
// {
//     Console.WriteLine("Вы ввели не трехзначное число");
// }
// else
// {
//     int result = ((num / 10) % 10);
//         Console.WriteLine($"Вторая цифра числа {num}: {result}");
// }


// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.


Console.Write(("Введите число: "));
    int number = Convert.ToInt32(Console.ReadLine());


if (number < 100)
{
    Console.WriteLine("Третья цифра отсутствует");
}
else
{
 string thirdNum = number.ToString();
Console.WriteLine(($"Третья цифра числа {number}: {thirdNum[2]}"));
}




// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// Console.Write("Введите день недели: ");
// int dayOfWeek = Convert.ToInt32(Console.ReadLine());

//  if (dayOfWeek >= 1 && dayOfWeek <= 5) 
// {
//         Console.Write(" Нет, это не выходной"); 
// }
//  else if (dayOfWeek >= 6 && dayOfWeek <= 7) 
// {
//         Console.Write(" Да, это выходной"); 
// }
//  else 
// {
//         Console.Write(" Не существует такого дня недели"); 
// }

