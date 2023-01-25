// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве

int x1 = ReadInt("Введите координату x первой точки: ");
int y1 = ReadInt("Введите координату y первой точки: ");
int z1 = ReadInt("Введите координату z первой точки: ");
int x2 = ReadInt("Введите координату x второй точки: ");
int y2 = ReadInt("Введите координату y второй точки: ");
int z2 = ReadInt("Введите координату z второй точки: ");

int A = x2 - x1;
int B = y2 - y1;
int C = z1 - z2;

double length = Math.Sqrt(A * A + B * B + C * C);
Console.WriteLine($"Расстояние между точками = {length}");

int ReadInt(string message)
{
 Console.Write(message);
 return Convert.ToInt32(Console.ReadLine());
}


