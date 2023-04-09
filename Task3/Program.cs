// Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// 45 -> 101101
// 3  -> 11
// 2  -> 10
int ReadInt(string message)
{
    System.Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}
int[] Binary(int number)
{
    int[] array = new int[10];
    for (int i = array.Length - 1; i >= 0; i--)
    {
        array[i] = number % 2;
        number = number / 2;
    }
    return array;
}
void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write(array[i] + " ");
    }
    System.Console.WriteLine();
}
int number = ReadInt($" Введите число ");
int [] massive = Binary(number);
PrintArray (massive);