// Задача 19 - HARD необязательная

// Напишите программу, которая принимает на вход целое число любой разрядности и проверяет, 
// является ли оно палиндромом. Через строку нельзя решать само собой.

System.Console.WriteLine("Введите пятизначное число: ");
int num = int.Parse(Console.ReadLine());
int count = 0;
fis(num);
int[] front = new int[count];
int[] back = new int[count];
string mes = "Палиндром";
void fis(int bar)
{
    while (bar > 0)
    {
        bar = bar / 10;
        count++;
    }
}
void Fronti(int[] func, int bar)
{
    for (int i = 0; i < count; i++) if (i == 0) func[i] = bar % 10;
        else
        {
            bar = bar / 10;
            func[i] = bar % 10;
        }
}
Fronti(front, num);
for (int i = 0; i < count; i++)
{
    back[i] = front[i];
}
Array.Reverse(front);
// System.Console.WriteLine(String.Join(" ", front));
// System.Console.WriteLine(String.Join(" ", back));
for (int i = 0; i < count; i++)
{
    if (front[i] != back[i])
      mes = "Не Палиндром";    
}
System.Console.WriteLine(mes);
