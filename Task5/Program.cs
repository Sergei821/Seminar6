// Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8

int ReadInt(string message)
{
    System.Console.Write(message + " ");
    return Convert.ToInt32(Console.ReadLine());
}


void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write(array[i] + " ");
    }
    System.Console.WriteLine();
}


int[] Fibonachi (int something)
{

    if (something <= 1 )
    {
        return new int[1];
    }
    


    int[] array = new int[something];
    array[0] = 0;
    array[1] = 1;

    for (int i = 2; i<array.Length; i++)
    {
        array[i] = array[i-1]+array[i-2];
    }

    return array;

}

int number = ReadInt("Введите число");
PrintArray(Fibonachi(number));
int[] CreateArray(int dlina, int max, int min)
{
    int[] array = new int[dlina];
    Random rnd = new Random();
    for (int i = 0; i < dlina; i++)
    {
        array[i] = rnd.Next(min, max + 1);

    }
    return array;
}