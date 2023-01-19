// Напишите программу,которая на вход принимает число (N), а на выходе показывает все четные числа от 1 до N
Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int everNumber = 2;
if(number > 1)
{
    while(everNumber <= number)
{
    Console.Write(everNumber + ",");
    everNumber = everNumber + 2;
}
}

