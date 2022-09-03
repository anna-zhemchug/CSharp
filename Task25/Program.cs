// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.WriteLine("Введите число А: ");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число В: ");
int b = int.Parse(Console.ReadLine());

int Exter(int mult)
{
    int c = 1;
    for (int i = 1; i <= b; i++)
    {
        c = c * a;
    }
    return c;
}

Console.WriteLine(Exter(a));