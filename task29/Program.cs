//Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
//1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
//6, 1, 33 -> [6, 1, 33]

System.Console.Clear();


int[] RandomNumberArray(int size)
{
    int[] numbersArray = new int[size];
    var rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        numbersArray[i] = rnd.Next(456);
    }
    return numbersArray;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write(array[i] + " ");
    }
    System.Console.WriteLine();
}

System.Console.WriteLine("Выберите размер массива");
int size = int.Parse(System.Console.ReadLine()!);

int[] array = RandomNumberArray(size);
PrintArray(array);