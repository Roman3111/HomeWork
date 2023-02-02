// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] 
System.Console.WriteLine("Введите размер массива");
int size = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[size];
FillArrayRandomNumbers(numbers);
System.Console.WriteLine("Это наш массив");
PrintArray(numbers);
int count = 0;

for(int j = 0; j < numbers.Length; j++)
if(numbers[j] % 2 == 0)
count++;

System.Console.WriteLine($"Здесь {numbers.Length} чисел, {count} четные из них ");

void FillArrayRandomNumbers(int[] numbers)
{
    for(int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = new Random().Next(100, 1000);
    }
}
void PrintArray(int[] numbers)
{
    System.Console.Write("[");
    for(int i = 0; i < numbers.Length; i++)
    {
        System.Console.Write(numbers[i] + " ");
    }
    System.Console.Write("]");
    System.Console.WriteLine();
}