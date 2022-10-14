//Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
Console.Clear();
Console.WriteLine("Введите целое число и я покажу все четные числа от 1 до него");
int num = int.Parse(Console.ReadLine());
int n = 2;
if (num <= 1)
{
    Console.WriteLine("Число должно быть больше 1");
}
else while (n<=num)
{
    Console.Write($"{n}, ");
    n=n+2;
}