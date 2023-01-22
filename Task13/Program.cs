// Напишите программу которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет
Console.Write("Введите число: ");
int anyNumber = Convert.ToInt32(Console.ReadLine());
string anyNumberText = Convert.ToString(anyNumber);
if(anyNumberText.Length > 2)
{
    System.Console.WriteLine(("Третья цифра ->" + anyNumberText[2]));
}
else
{
    System.Console.WriteLine("-> третьей цифры нет");
}