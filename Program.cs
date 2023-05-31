// Задача 19

// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом. Через строку решать нельзя.

// 14212 -> нет

// 12821 -> да

// 23432 -> да

System.Console.WriteLine("Введите пятизначное число: ");
int num = int.Parse(Console.ReadLine());


int y = num % 10;
int y2 = num/10 % 10;
int x = num / 10000;
int x2 = num / 1000 % 10;
    if (num >9999 && num<100000)
        if(y == x && y2 == x2)
            System.Console.WriteLine("Палиндром");
        else
            System.Console.WriteLine("Не палиндром");
    else
    System.Console.WriteLine("Нужно ввести пятизначное число");
// System.Console.WriteLine($"{y},{y2},{x},{x2}");



