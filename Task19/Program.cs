﻿// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом

Console.Write("Введите число из пяти цифр: ");
string? number = Console.ReadLine();

void CheckingNumber(string number)
{
    if(number[0] == number[4] || number[1] == number[3])
    {
        Console.WriteLine($"Ваше число: {number} - это палиндром. ");
    }
    else Console.WriteLine($"Ваше число: {number} - не является палиндромом. ");
}

if(number!.Length == 5)
{
    CheckingNumber(number);
}
else Console.WriteLine($"Введите именно пятизначное число");