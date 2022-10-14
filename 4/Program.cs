// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
Console.Clear();
Console.WriteLine("Введите три числа целых числа и я скажу какое из них самое большое");
int num1 = int.Parse(Console.ReadLine());
int num2 = int.Parse(Console.ReadLine());
int num3 = int.Parse(Console.ReadLine());
if (num1>=num2 && num1>=num3)
{
    Console.WriteLine($"Число {num1} наибольшее");
}
else if (num2>=num1 && num2>=num3)
{
    Console.WriteLine($"Число {num2} наибольшее");
}
else
{
    Console.WriteLine($"Число {num3} наибольшее");
}