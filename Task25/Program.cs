// Напишите цикл, который принимает на вход два числа (А и В) и возводит число А в натуральную степень
System.Console.WriteLine("Введите число А ");
int a = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите число В ");
int b = Convert.ToInt32(Console.ReadLine());
int result = a;
for(int i = 1; i < b; i++ )
{
    result = result * a;
}
System.Console.WriteLine(" А в степени В равно: " + result);
