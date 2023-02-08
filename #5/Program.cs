// Найти произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д.

int ReadInt(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}

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

int[] MultiplicationPairs(int[] array){
    int length = array.Length/2;
    int[] newArray = new int[length];
    for (int i = 0; i < length; i++)
        newArray[i] = array[i]*array[array.Length-i-1];
    return newArray;
}

int length = ReadInt("Введите длину массива: ");
int lowest = 0;
int hightest = 10;
int[] array = CreateArray(length, lowest, hightest);

PrintArray(array);
Console.WriteLine("Произведение пар в одномерном массиве:");
PrintArray(MultiplicationPairs(array));