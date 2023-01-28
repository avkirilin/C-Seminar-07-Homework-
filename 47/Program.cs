//Задайте двумерный массив размером m * n,
//заполненный случайными вещественными числами

double[,] GetArray(int rows, int columns, int minValue, int maxValue)                      //метод получения вещественного двумерного массива с рандомными значениями
{
    double[,] result = new double[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            result[i, j] = Math.Round((new Random().Next(minValue, maxValue) + new Random().NextDouble()), 3);
        }
    }
    return result;
}

void PrintArray(double[,] inArray)                                                          //метод вывода двумерного массива с корректными отступами 
{                                                                                           //и округлением значений до 3 знака после запятой
    Console.WriteLine();
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            if (inArray[i, j] >= 0 && inArray[i, j] < 10) Console.Write($"    {inArray[i, j]:f3}");
            if (inArray[i, j] >= 10 && inArray[i, j] < 100) Console.Write($"   {inArray[i, j]:f3}");
        }
        Console.WriteLine();
    }
}

Console.WriteLine("Введите кол-во строк и кол-во столбцов массива через пробел");
string[] countRowsAndColumnsInArray = Console.ReadLine()!.Split(' ', StringSplitOptions.RemoveEmptyEntries)!;
int rowsArray = int.Parse(countRowsAndColumnsInArray[0]);
int columnsArray = int.Parse(countRowsAndColumnsInArray[1]);
Console.WriteLine("Введите минимальное и максимальное значения элементов массива в диапазоне 0-99, через пробел");
string[] arrayMinAndMaxNum = Console.ReadLine()!.Split(' ', StringSplitOptions.RemoveEmptyEntries)!;
int minNum = int.Parse(arrayMinAndMaxNum[0]);
int maxNum = int.Parse(arrayMinAndMaxNum[1]);
double[,] myArray = GetArray(rowsArray, columnsArray, minNum, maxNum);
PrintArray(myArray);