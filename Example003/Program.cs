//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
//6 -> да    7 -> да     1 -> нет
int[] Array = {1, 2, 3, 4, 5, 6, 7};
Console.WriteLine("Введите, пожалуйста, номер дня недели");
int DayOfTheWeek = Convert.ToInt32(Console.ReadLine());

if ((DayOfTheWeek == Array[5]) | (DayOfTheWeek == Array[6]))  Console.WriteLine("Сегодня выходной");
else Console.WriteLine("Сегодня будний день");