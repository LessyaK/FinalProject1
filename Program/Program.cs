//Написать программу, которая из имеющегося массива строк формирует масси из строк, 
//длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры либо задать 
//на старте выполнения алгоритма

string[] array = EnterArray();
string[] newArray = NewStringArray(array, 3);
Console.WriteLine($"[{string.Join(", ", array)}] -> [{string.Join(", ", newArray)}]");

// Функция ввода массива строк
string[] EnterArray()
{
    Console.Write("Введите значения через пробел: ");
    return Console.ReadLine().Split(" ");
}

// Функция проверки на соответствие длине строки
int CheckLenghtString(string[] input, int n)
{
    int count = 0;

    for (int i = 0; i < input.Length; i++)
    {
        if (input[i].Length <= n)
        {
            count++;
        }
    }

    return count;
}

//Функция формирования нового массива строк
string[] NewStringArray(string[] input, int n)
{
    string[] output = new string[CheckLenghtString(input, n)];

    for (int i = 0, j = 0; i < input.Length; i++)
    {
        if (input[i].Length <= n)
        {
            output[j] = input[i];
            j++;
        }
    }

    return output;
}



