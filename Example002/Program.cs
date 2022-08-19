//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
//645 -> 5      78 -> третьей цифры нет     32679 -> 6

int number = new Random().Next(1, 1000000);
Console.WriteLine("Было заданно число: " + number);

string numberString = Convert.ToString(number);

if (numberString.Length < 3) Console.WriteLine("У числа нет третьей цифры");
else Console.WriteLine("Третье число: " + numberString[2]);