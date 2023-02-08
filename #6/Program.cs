// В Указанном массиве вещественных чисел найдите разницу между максимальным и минимальным элементом

int ReadInt(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}

double[] CreateArray(int length, int lowest, int hightest){
    double[] array = new double[length];
    Random random = new Random();
    for (int i = 0; i < array.Length; i++)
        array[i] = Math.Round(random.NextDouble()*(hightest-lowest), 2);
    return array;
}

void PrintArray(double[] array){
    foreach (double element in array)
        Console.Write($"| {element} ");
    Console.WriteLine();
}

double DifferenceMaxMin(double[] array){
    double min = array[0];
    double max = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i]>max) max = array[i];
        if (array[i]<min) min = array[i];
    }
    return max-min;
}

int length = ReadInt("Введите длину массива: ");
int lowest = 0;
int hightest = 20;
double[] array = CreateArray(length, lowest, hightest);

PrintArray(array);
Console.WriteLine($"Разница между максимальным и минимальным элементом в массиве: {DifferenceMaxMin(array)}");