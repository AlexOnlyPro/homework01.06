// Задача 19 - HARD необязательная

// Напишите программу, которая принимает на вход целое число любой разрядности и проверяет, 
// является ли оно палиндромом. Через строку нельзя решать само собой.

System.Console.WriteLine("Введите пятизначное число: ");
int num = int.Parse(Console.ReadLine());
int count = 0;
System.Console.WriteLine(num);

void fis()
{
    while (num > 0)
    {
        num = num / 10;
        count++;
    }
}
fis();
System.Console.WriteLine(count);
System.Console.WriteLine(num);

int[] front = new int[count];
int[] back = new int[count];

for (int i = 0; i < count; i++)
    if (i == 0) front[i] = num % 10;
    else
    {
        num = num / 10;
        front[i] = num % 10;
    }

System.Console.WriteLine(String.Join(" ", front));

// int y = num % 10;
// int y2 = num/10 % 10;
// int x = num / 10000;
// int x2 = num / 1000 % 10;
//     if (num >9999 && num<100000)
//         if(y == x && y2 == x2)
//             System.Console.WriteLine("Палиндром");
//         else
//             System.Console.WriteLine("Не палиндром");
//     else
//     System.Console.WriteLine("Нужно ввести пятизначное число");