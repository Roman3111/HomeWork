// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30
System.Console.WriteLine("Введите m: ");
int m = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите n: ");
int n = Convert.ToInt32(Console.ReadLine());

SumOfNatNumbers(m, n);
// вызов функции суммы чисел от М до N
void SumOfNatNumbers(int m, int n)
{
    System.Console.WriteLine($"Сумма натуральных элементов от {m} до {n} = " + SumMN(m - 1, n));
}
// функция суммы чисел от M до N
int SumMN(int m, int n)
{
    int res = m;
    if (m == n) return 0;
    else
    {
        m++;
        res = m + SumMN(m, n);
        return res;
    }
}