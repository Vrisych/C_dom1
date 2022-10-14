// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
Console.Clear();
Console.WriteLine("Введите целое число и я скажу четное оно или нечетное");
int num1 = int.Parse(Console.ReadLine());
int ost = num1 % 2;
if (ost == 1)
{
    Console.WriteLine("Число нечетное");
}
else Console.WriteLine("Число четное");
