// Напишите программу, которая принимает на вход координаты двух точек 
// и находит расстояние между ними в N-мерном пространстве. 
// Сначала задается N с клавиатуры, потом задаются координаты точек.
int InPut(string message)
{
    int value = 0;
    System.Console.WriteLine(message);
    value = int.Parse(Console.ReadLine());
    return value;
}

System.Console.WriteLine("Введите мерность пространства: ");
int N = int.Parse(Console.ReadLine());
double[] x = new double[N];
double[] y = new double[N];
double[] z = new double[N];
double dist = 0;

for (int i = 0; i < N; i++)
{
    if (i == 0) x[i] = InPut("Введите координату первой точки: ");
    else x[i] = InPut("Введите следующую координату первой точки: ");


}
for (int i = 0; i < N; i++)
{
    if (i == 0) y[i] = InPut("Введите координату второй точки: ");
    else y[i] = InPut("Введите следующую координату второй точки: ");
}
for (int i = 0; i < N; i++)
{
    double result = y[i] - x[i];
    dist += result * result;
}

System.Console.WriteLine(Math.Sqrt(dist));
