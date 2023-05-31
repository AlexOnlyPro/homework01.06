// Задача 21

// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53


int InPut(string message)
{
    int value = 0;
    System.Console.WriteLine(message);
    value = int.Parse(Console.ReadLine());
    return value;  
}
int x1 = InPut("Введите координату X первой точки: ");
int y1 = InPut("Введите координату Y первой точки: ");
int z1 = InPut("Введите координату Z первой точки: ");
int x2 = InPut("Введите координату X второй точки: ");
int y2 = InPut("Введите координату Y второй точки: ");
int z2 = InPut("Введите координату Z второй точки: ");

int a = x2 - x1;
int b = y2 - y1;
int c = z1 - z2;

double result = Math.Sqrt(a*a + b*b + c*c);
System.Console.WriteLine($"Расстояние между точками {result}");