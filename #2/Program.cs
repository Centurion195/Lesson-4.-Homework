// Задать массив, заполнить случайными положительными трёхзначными числами. Показать количество нечетных\четных чисел

int[] CreateArray(int length, int lowest, int hightest){
    int[] array = new int[length];
    Random random = new Random();
    for (int i = 0; i < array.Length; i++)
        array[i] = random.Next(lowest,hightest+1);
    return array;
}

void PrintArray(int[] array){
    foreach (int element in array)
        Console.Write($"| {element} ");
    Console.WriteLine();
}

int ReadInt(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}

int FindAnEvenNumber(int[] array){
    int count = 0;
    for (int i = 0; i < array.Length; i++)
        if (array[i]%2==0) count++;
    return count;
}

int length = ReadInt("Введите длину массива: ");
int lowest = 100;
int hightest = 999;
int[] array = CreateArray(length, lowest, hightest);

PrintArray(array);
Console.WriteLine($"Количество четных чисел в массиве: {FindAnEvenNumber(array)}");
Console.WriteLine($"Количество нечетных чисел в массиве: {array.Length-FindAnEvenNumber(array)}");