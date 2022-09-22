//  Напишите программу, которая спирально заполнит числами от 1 до 16 
// двумерный массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07
// Указание: При заполнении массива использовать циклы.

// 1. Создать 2мерный массив 4*4
Console.WriteLine("Заполним спирально массив 4х4:");
int linesCount = 4;
int volume = linesCount * linesCount;

int [,] twoDimArray = new int[linesCount, linesCount];

// 2. Создать 1мерный массив.
int[] array = new int[volume];

for (int i=0; i<volume; i++)
{
    array[i] = i+1;
    //Console.Write(array[i]);
    //Console.Write(" ");
}
//Console.WriteLine();
int k = 0;
// 2. Заполнить 2мерный массив
for (int i=0; i<linesCount; i++)
{
    for (int j=0; j<linesCount; j++)
    {
        twoDimArray[i,j] = array[k];
        k++;
        Console.Write(twoDimArray[i,j] + " "); 
        while (i < linesCount & j == linesCount)
        {
            i++;
        }
         
    }
}
    Console.WriteLine();


