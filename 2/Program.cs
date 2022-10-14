// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
Console.Clear();
Console.WriteLine("Введите два целых числа и я скажу какое из них больше");
int num1 = int.Parse(Console.ReadLine());
int num2 = int.Parse(Console.ReadLine());
if (num1 > num2)
{
    Console.WriteLine($"Число {num1} больше {num2}");
}
else if (num2 > num1)
{
    Console.WriteLine($"Число {num2} больше {num1}");
}
else
Console.WriteLine($"Числа {num2} и {num1} равны");