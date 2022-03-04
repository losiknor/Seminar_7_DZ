// Задача 53: В двумерном массиве показать позиции числа, заданного пользователем, или указать, что такого элемента нет.
int[,] array = new int[new Random().Next(9, 19), new Random().Next(9, 19)];
Console.WriteLine("Задан двумерный массив:");
Console.WriteLine($"Строк {array.GetLength(0)}; столбцов {array.GetLength(1)}");
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i, j] = new Random().Next(100, 999);
        Console.Write(array[i, j] + " ");
    }
    Console.WriteLine("");
}
Console.WriteLine("Задайте число для поиска: ");
int num = int.Parse(Console.ReadLine());
bool yes = false;
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        if (array[i, j] == num)
        {
            Console.Write($"Позиция заданного числа: {i + 1} строка, {j + 1} столбец");
            yes = true;
        }
    }
}
if (yes == false)
    Console.WriteLine("Такого элемента нет.");