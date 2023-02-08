// Задать массив из 8 элементов, заполненных нулями и единицами вывести их на экран

byte[] CreateArray(int length, int lowest, int hightest){
    byte[] array = new byte[length];
    Random random = new Random();
    for (int i = 0; i < array.Length; i++)
        array[i] = Convert.ToByte(random.Next(lowest,hightest+1));
    return array;
}

void PrintArray(byte[] array){
    foreach (byte element in array)
        Console.Write($"| {element} ");
}
int length = 8;
int lowest = 0;
int hightest = 1;

PrintArray(CreateArray(length, lowest, hightest));