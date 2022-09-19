// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.

// 0,5 7 -2 -0,2

// 1 -3,3 8 -9,9

// 8 7,8 -7,1 9

int m = 3;
int n = 4;
double[,] twoDemensionArray = new double[m,n];
Console.WriteLine("Двумерный массив размером 3х4, заполненный вещественными числами:");
Console.WriteLine();
InputRandomNumbersInArray(twoDemensionArray);

void InputRandomNumbersInArray (double[,] DoubleArray)
{
    for(int i = 0; i < m; i++)
    {
            for (int j = 0; j < n; j++)
        {
            DoubleArray[i,j] = Math.Round(new Random().NextDouble() + new Random().Next(-1000,1001), 3);
            if (DoubleArray[i,j] > -1)
            {
                Console.Write($" {DoubleArray[i,j]} ");
            }
            else
            {
                Console.Write($"{DoubleArray[i,j]} ");
            }
        }
        Console.WriteLine();
    }
}
