// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
Console.Write("Введите число А: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число B: ");
int b = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число С: ");
int c = Convert.ToInt32(Console.ReadLine());

int max = a;
if (b > max)
{
    max = b;
}
if (c > max)
{
    max = c;
}
Console.WriteLine($"Максимальное число из трех: {max}");
Console.ReadKey();
