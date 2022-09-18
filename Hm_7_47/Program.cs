// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.

// 0,5 7 -2 -0,2

// 1 -3,3 8 -9,9

// 8 7,8 -7,1 9

int m = 3;
int n = 4;
double[,] twoDemensionArray = new double[m,n];
Console.WriteLine(twoDemensionArray[0,1]);

InputRandomNumbersInArray(twoDemensionArray);

void InputRandomNumbersInArray (double[,] DoubleArray)
{
    for(int i = 0; i < 3; i++)
    {
            for (int j = 0; j < n; j++)
        {
            DoubleArray[i,j] = new Random.NextDouble();
            Console.WriteLine(DoubleArray[i,j]);
        }
    }
        DoubleArray[i,j] = new Random.NextDouble();
        Console.WriteLine(DoubleArray[i,j]);
    }

}