// Напишите программу, которая будет создавать копию заданного массива 
// с помощью поэлементного копирования.

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


int[] Fibonachi(int something)
{

    if (something <= 1)
    {
        return new int[1];
    }



    int[] array = new int[something];
    array[0] = 0;
    array[1] = 1;

    for (int i = 2; i < array.Length; i++)
    {
        array[i] = array[i - 1] + array[i - 2];
    }

    return array;
}
int[] Copy(int[] massive)
{
    int[] copyArray = new int[massive.Length];
    for (int i = 0; i < massive.Length; i++)
    {
        copyArray[i] = massive[i];
    }
    return copyArray;
}
int[] origin = new int[] { 0, 1, 2, 3 };
int[] array = origin;
origin[0] = 100;
PrintArray(origin);
PrintArray(array);
int[] copired = Copy(origin);
origin[1] = 200;
PrintArray(origin);
PrintArray(copired);