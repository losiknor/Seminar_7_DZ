// Задача 51: Задать двумерный массив следующим правилом: Aₘₙ = m+n.
int[,] array = new int[new Random().Next(3, 10), new Random().Next(3, 10)];
Console.WriteLine("Задан двумерный массив:");
Console.WriteLine($"Строк {array.GetLength(0)}; столбцов {array.GetLength(1)}");
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i, j] = i + j;
        Console.Write(array[i, j] + " ");
    }
    Console.WriteLine("");
}
