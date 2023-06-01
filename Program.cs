// Напишите программу, которая принимает на вход координаты двух точек 
// и находит расстояние между ними в N-мерном пространстве. 
// Сначала задается N с клавиатуры, потом задаются координаты точек.


System.Console.WriteLine("Введите мерность пространства: ");
int N = int.Parse(Console.ReadLine());
double [] x = new double [N];
double [] y = new double [N];
double [] z = new double [N];
double [] temp = new double[N];
double dist = 0;

for (int i = 0; i<N; i++ ) 
{
    x[i] = InPut("Введите координату первой точки: ");
}
for (int i = 0; i <N; i++)
{
    y[i] = InPut("Введите координату второй точки: ");
}
for (int i = 0; i < N; i++)
{
    double result = y[i] - x[i];
    z[i] = result*result;
}
for (int i = 0; i < N; i++)
{   
    double result = (z[i]*z[i]);
    temp[i] = result;
}
System.Console.WriteLine(String.Join(" ",temp));
for (int i = 0; i < N; i++)
{
    dist += temp[i];
}

System.Console.WriteLine(dist);
int InPut(string message)
{
    int value = 0;
    System.Console.WriteLine(message);
    value = int.Parse(Console.ReadLine());
    return value;  
}



// int x1 = InPut("Введите координату X первой точки: ");
// int y1 = InPut("Введите координату Y первой точки: ");
// int z1 = InPut("Введите координату Z первой точки: ");
// int x2 = InPut("Введите координату X второй точки: ");
// int y2 = InPut("Введите координату Y второй точки: ");
// int z2 = InPut("Введите координату Z второй точки: ");

// int a = x2 - x1;
// int b = y2 - y1;
// int c = z1 - z2;

// double result = Math.Sqrt(a*a + b*b + c*c);
// System.Console.WriteLine($"Расстояние между точками {result}");



// using System;
// namespace New_Project
// { class Program
// { public static void Main()
// { double [] x = new double [6];
// double d, distance = 0.0;
// Console.WriteLine("x1 y1 z1 x2 y2 z3:");
// var line = Console.ReadLine().Split();
// for (int i = 0; i < 3; i++)
// { d = Convert.ToDouble(line[i + 3])
// - Convert.ToDouble(line[i]);
// distance += d * d; }
// Console.WriteLine("r = " + Math.Sqrt(distance)); } } }

// int[] a = new int[100];
//             Random random = new Random();
//             Console.Write("Массив: ");
//             for (int i = 0; i < a.Length; i++)
//             {
//                 a[i] = random.Next(100);               
//                 Console.Write("{0} ", a[i]);               
//             }
//             Console.WriteLine();
//             Console.WriteLine();
//             Console.Write("Индексы: ");
//             for (int i = 0; i < a.Length; i++)
//             {
//                 Console.Write("{0} ", i + 1);
//             }
//             Console.WriteLine();


// int i;
// double summ = 0;
// for(i=0; i<n; i++){
//     double temp = a[i] - b[i];
//     summ += temp*temp;
// }
// return sqrt(summ);