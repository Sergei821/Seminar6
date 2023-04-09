// Задача 1: Напишите программу, которая перевернёт одномерный массив 
// (последний элемент будет на первом месте, а первый - на последнем и т.д.)
// [1 2 3 4 5] -> [5 4 3 2 1]
// [6 7 3 6] -> [6 3 7 6]

int ReadInt(string message)
{
    System.Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

double[] GenerateArray(int len, int minLimit, int maxLimit)
{
    double[] answer = new double[len];
    Random rnd = new Random();
    for (int i = 0; i < answer.Length; i++)
    {
        answer[i] = Math.Round(rnd.Next(minLimit, maxLimit) + rnd.NextDouble(), 4);
    }

    return answer;
}

void PrintArrayDouble(double[] array)
{
    foreach (double item in array)
    {
        System.Console.Write($"{item:F2}\t");
    }
    System.Console.WriteLine();
}

double[] Reverse(double[] array)
{
    for (int i = 0; i < array.Length / 2; i++)
    {
        double tmp = array[i];
        array[i] = array[array.Length - 1 - i];
        array[array.Length - 1 - i] = tmp;
    }
    
    return array;
}

int len = ReadInt("Количество элементов массива > ");
int minRange = ReadInt("Минимальное случайное значение > ");
int maxRange = ReadInt("Максимальное случайное значение > ");

double[] array = GenerateArray(len, minRange, maxRange);
PrintArrayDouble(array);
PrintArrayDouble(Reverse(array));

