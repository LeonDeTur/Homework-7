// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int m = new Random().Next(1,11);
int n = new Random().Next(1,11);

int[,] doubleArray = new int[m,n];
doubleArray = InputRandomNumbersInArray (doubleArray);
PrintDoubleArray(doubleArray);
int[] result = GetSumDoubleArrayСolumns (doubleArray);
PrintResult (result);


// Методы
int[,] InputRandomNumbersInArray (int[,] DoubleArray)
{
    for(int i = 0; i < m; i++)
    {
            for (int j = 0; j < n; j++)
        {
            DoubleArray[i,j] = new Random().Next(-100,101);
        }
    }
    return DoubleArray;
}

void PrintDoubleArray(int[,] doubleArray)
{
    for(int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            Console.Write($"{doubleArray[i,j]} ");
        }
        Console.WriteLine();
    }
}

int[] GetSumDoubleArrayСolumns (int[,] doubleArray)
{
    int[] array = new int[n];  
    for(int j = 0; j < n; j++)
    {
        int columnSum = 0;
        for (int i = 0; i < m; i++)
        {
            columnSum += doubleArray[i,j];
        }
        array[j] = columnSum;
    }
    return array;
}

void PrintResult (int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine($"Сумма {i+1}-ого столбца равна {array[i]}");
    }
}