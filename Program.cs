﻿// Задача 19

// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом. Через строку решать нельзя.

// 14212 -> нет

// 12821 -> да

// 23432 -> да

System.Console.WriteLine("Введите число пятизначное число: ");
int num = int.Parse(Console.ReadLine());

if (num >9999 && num>100000)
    int y = num%10;
    int y2 = num%100;
    int x = num/1000;
    int x2 = num/100;
System.Console.WriteLine(y2);



// int num,r,sum=0,t;
// Console.Write(«Введите пятизначное число: «);
// num = Convert.ToInt32(Console.ReadLine());
// if(num>9999 && num<100000)
// {
// for(t=num;num!=0;num=num/10)
// {
// r=num % 10;
// sum=sum*10+r;
// }
// if(t==sum)
// Console.Write($»{t} является палиндромом.»);
// else
// Console.Write($»{t} не является палиндромом.»);
// } else
// Console.Write(«Введите пятизначное число! «);