// Задача 29: Напишите программу, которая задаёт массив из N элементов, заполненных случайными числами из [a, b) и выводит их на экран.
// 5, 0, 20 -> [1, 2, 5, 7, 19]
// 3, 1, 35 -> [6, 1, 33]

Console.WriteLine("Введите число элементов в массиве: ");
int n = int.Parse(Console.ReadLine());
Console.WriteLine("Введите начальное значение массива: ");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите конечное значение массива: ");
int b = int.Parse(Console.ReadLine());

void RandArray()
{
    int[] arr = new int[n];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(a, b);
    }
    Console.WriteLine($"[{String.Join(", ", arr)}]");
}
RandArray();