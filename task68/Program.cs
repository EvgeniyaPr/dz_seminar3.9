// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n. 
// m = 2, n = 3 -> A(m,n) = 29

int ReadInt(string text)
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int Akkerman(int numM, int numN)
{
    if (numM == 0)
    {
        return numN + 1;
    }
    else if (numM > 0 && numN == 0)
    {
        return Akkerman(numM - 1, 1);
    }
    else if (numM > 0 && numN > 0)
    {
        return Akkerman(numM - 1, Akkerman(numM, numN - 1));
    }
    else return 0;
}

int numM = ReadInt("Введите число М: ");
int numN = ReadInt("Введите число N: ");
System.Console.WriteLine();
System.Console.WriteLine("Значение функции Аккермана равно: " + Akkerman(numM, numN));