// В одномерном массиве из 123 чисел найти количество элементов из отрезка [10,99] ????
Console.WriteLine($"Количество элементов из отрезка [10,99]: {99-10+1}");


// Из одномерного массива из 123 чисел ВЫВЕСТИ ЭЛЕМЕНТЫ из отрезка [10,99]
/*
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
}

int[] CreateNewArray(int[] array, int newLowest, int newHightest){
    int length = newHightest-newLowest+1;
    int[] newArray = new int[length];
    for (int i = 0; i < length; i++)
    {
        newArray[i] = array[newLowest-1];
        newLowest++;
    }
    return newArray;
}

int length = 123;
int lowest = 0;
int hightest = 999;
int newLowest = 10;
int newHightest = 99;

int[] array = CreateArray(length, lowest, hightest);

PrintArray(array);
Console.WriteLine();
Console.WriteLine();
PrintArray(CreateNewArray(array, newLowest, newHightest));
*/