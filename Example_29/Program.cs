// Напишите программу, которая задаёт массив
// из 8 элементов и выводит их на экран.

int [] array = ReadArray();
PrintArray(array);


int [] ReadArray()
{
    int[] result = new int [8];
    for(int i = 0; i < 8; i++)
    {
        Console.WriteLine("Введите число:\t");
        result[i] = int.Parse(Console.ReadLine()!);
    }
    return result;
}

void PrintArray(int[] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]}, ");
    }
    Console.WriteLine();

}







