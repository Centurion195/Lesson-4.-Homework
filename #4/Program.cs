// Найти сумму чисел одномерного массива стоящих на нечетной позиции

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

int Sum(int[] array){
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
        if (i%2!=0) sum += array[i];
    return sum;
}

int length = ReadInt("Введите длину массива: ");
int lowest = 0;
int hightest = 10;
int[] array = CreateArray(length, lowest, hightest);
PrintArray(array);
Console.WriteLine($"Сумма чисел одномерного массива, стоящих на нечетных позициях: {Sum(array)}");