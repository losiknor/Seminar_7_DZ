// Задача 49: Показать двумерный массив размером m×n, заполненный вещественными числами.
double[,] array = new double[new Random().Next(3, 10), new Random().Next(3, 10)];
Console.WriteLine($"Задан двумерный массив размером {array.GetLength(0)} на {array.GetLength(1)}");
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i, j] = new Random().NextDouble() * 100;
        Console.Write(array[i, j] + " ");
    }
    Console.WriteLine("");
}
