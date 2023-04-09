// // Напишите программу, которая принимает на вход три числа 
// и проверяет,может ли существовать треугольник с сторонами такой длины.

int ReadInt(string message)
{
    System.Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int storonaA = ReadInt($"Введите сторону А ");
int storonaB = ReadInt($"Введите сторону Б ");
int storonaС = ReadInt($"Введите сторону C ");
string text = " Не может существовать";

if (storonaA < storonaB + storonaС)
{
    if (storonaB < storonaA + storonaС)
    {
        if (storonaС < storonaB + storonaA)
        {
            text = ($"Может существовать ");
        }

    }

}
System.Console.WriteLine(text);