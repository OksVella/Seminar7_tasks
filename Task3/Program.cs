// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Console.WriteLine("введите количество строк");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите количество столбцов");
int columns = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[rows, columns];
FillArray(matrix);
PrintArray(matrix);
AverageColumns(matrix, columns, rows);

void FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(1, 10);
        }
    }
}

void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
}

void AverageColumns(int[,] matr, int columns, int rows)
{
    Console.Write("Average value of each column: ");

    for (int count = 0; count < columns; count++)
    {
        double sum = 0;
        for (int i = 0; i < matr.GetLength(0); i++)
        {
            sum = sum + matr[i, count];
        }

        double average = Math.Round(sum / rows, 2); 
        Console.Write(average);

        if (count < columns - 1)
        {
            Console.Write("; ");
        }
    }
}