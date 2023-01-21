// Напишите программу, которая принимает на вход трехзначное число и на выходе показывае вторую цифру этого числа
Console.Clear();
System.Console.WriteLine("Введите трехзначное число: ");
int threeDigitNumber = Convert.ToInt32(Console.ReadLine());
string stringNumber = Convert.ToString(threeDigitNumber);
System.Console.WriteLine(("вторая цифра этого числа-> " +stringNumber[1]));