﻿// Напишите программу, которая принимает на вход число и выдает сумму цифр в числе
System.Console.WriteLine("Введите число");
int i = Convert.ToInt32(Console.ReadLine());
int sum = 0;
while(i > 0)
{
int number = i % 10;
i = i / 10;
sum = sum + number;
}
System.Console.WriteLine("Сумма цифр в этом числе = " + sum);