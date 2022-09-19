// Задача 50. Напишите программу, которая на вход принимает число и ищет в двумерном массиве, 
// и возвращает индексы этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 7 -> 0 , 2
// 5 -> 1 , 0
// 18 -> нет такого элемента

Console.WriteLine("Введите целое число");
string? checkForInt = Console.ReadLine();
ValidateInput (checkForInt);
int num = Convert.ToInt32(checkForInt);
int m = new Random().Next(1,11);
int n = new Random().Next(1,11);

int[,] doubleArray = new int[m,n];
doubleArray = InputRandomNumbersInArray (doubleArray);
PrintDoubleArray(doubleArray);
int[] findResult = FindNum (num, doubleArray);
PrintResult(findResult);

int[,] InputRandomNumbersInArray (int[,] DoubleArray)
{
    for(int i = 0; i < 3; i++)
    {
            for (int j = 0; j < n; j++)
        {
            DoubleArray[i,j] = new Random().Next(-100,101);
        }
    }
    return DoubleArray;
}

void ValidateInput (string input)
{
    bool IsNumber = int.TryParse(input, out int number);
    if (!IsNumber) 
    {
        Console.WriteLine("Error: Пожалуйста, введите целое число .");
        Environment.Exit(0);
    }
}

int[] FindNum (int num, int[,] array)
{
    int[] result = new int[0];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            if (array[i,j] == num)
            {
                result = new int[2];
                result[0] = i;
                result[1] = j;
                return result;
            }
        }
    }
    return result;
}

void PrintResult(int[] array)
{
    if (array.Length != 2)
    {
        Console.WriteLine("Такого числа нет в массиве.");
    }
    else
    {
        Console.WriteLine($"Индекс элемента: {array[0]},{array[1]}");
    }
}

void PrintDoubleArray(int[,] doubleArray)
{
    for(int i = 0; i < 3; i++)
    {
        for (int j = 0; j < n; j++)
        {
            Console.Write($"{doubleArray[i,j]} ");
        }
        Console.WriteLine();
    }
}