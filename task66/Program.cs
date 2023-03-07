// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int ReadInt(string text)
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int SumElements(int numM, int numN)
{
    if (numM == numN)
    {
        return numN;
    }
    return numM + SumElements(numM + 1, numN);
}

int numM = ReadInt("Введите число М: ");
int numN = ReadInt("Введите число N: ");
System.Console.WriteLine();
System.Console.WriteLine("Сумма элементов в промежутке от М до N равна: " + SumElements(numM, numN));