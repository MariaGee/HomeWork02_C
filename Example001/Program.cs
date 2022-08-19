//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
//456 -> 5      782 -> 8      918 -> 1

int number = new Random().Next(100,1000);
Console.WriteLine("Было заданно число: " + number);

int SecondNumber (int count)
{
    int index = count / 10 % 10;
    return index;
}

int result = SecondNumber(number);
Console.WriteLine("Вторая цифра в числе: " + result);

