// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента
//или же указание, что такого элемента нет. 
Console.WriteLine("введите значение i");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите значение j");
int columns = Convert.ToInt32(Console.ReadLine());
int currentRows = 3;
int currentColumns = 4;
int[,] matrix = new int[currentRows, currentColumns];
FillArray(matrix);
PrintArray(matrix);

if (rows < 0 || columns < 0)
{
    Console.Write("Введите корректные значения");
}
else
{
    if (rows >= currentRows || columns >= currentColumns)
    {
        Console.Write("Такого числа в массиве нет");
    }
    else
    {
        Console.Write("Result value = " + matrix[rows, columns]);
    }
}

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
