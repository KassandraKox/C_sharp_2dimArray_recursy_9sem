// Задайте двумерный массив. Напишите программу, которая упорядочит
// по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

// 1. Создать двумерный массив.
Console.WriteLine("Введи количество строк:");
int linesCount = int.Parse(Console.ReadLine());
Console.WriteLine("Введи количество столбцов:");
int columnsCount = int.Parse(Console.ReadLine());

int [,] twoDimArray = new int[linesCount, columnsCount];
Random rnd = new Random();

// 2. Заполнить 2мерный массив
for (int i=0; i<linesCount; i++)
{
    for (int j=0; j<columnsCount; j++)
    {
        twoDimArray[i,j] = rnd.Next(1, 100);
        Console.Write(twoDimArray[i,j] + " ");
    }
    Console.WriteLine();
}

// 3. Отсортировать массив
void OrderArrayLines(int[,] twoDimArray)
{
  for (int i = 0; i < twoDimArray.GetLength(0); i++)
  {
    for (int j = 0; j < twoDimArray.GetLength(1); j++)
    {
      for (int k = 0; k < twoDimArray.GetLength(1) - 1; k++)
      {
        if (twoDimArray[i, k] < twoDimArray[i, k + 1])
        {
          int temp = twoDimArray[i, k + 1];
          twoDimArray[i, k + 1] = twoDimArray[i, k];
          twoDimArray[i, k] = temp;
        }
      }
    }
  }
}
void WriteArray(int[,] twoDimArray)
{
  for (int i = 0; i < twoDimArray.GetLength(0); i++)
  {
    for (int j = 0; j < twoDimArray.GetLength(1); j++)
    {
      Console.Write(twoDimArray[i, j] + " ");
    }
    Console.WriteLine();
  }
}

// 4. Вывод массива.
OrderArrayLines(twoDimArray);
Console.WriteLine();
WriteArray(twoDimArray);