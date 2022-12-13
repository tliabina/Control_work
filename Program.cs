/*Задача: Написать программу, которая из имеющегося массива строк формирует
 новый массив из строк, длина которых меньше, либо равна 3 символам. 
 Первоначальный массив можно ввести с клавиатуры, либо задать 
 на старте выполнения алгоритма. При решении не рекомендуется пользоваться 
 коллекциями, лучше обойтись исключительно массивами.

Примеры:

[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
[“1234”, “1567”, “-2”, “computer science”] → [“-2”]
[“Russia”, “Denmark”, “Kazan”] → []*/

int CountFilteredItems(string[] input, int maxLength)
{
    int count = 0;

    for (int i = 0; i < input.Length; i++)
    {
        if (input[i].Length <= maxLength)
        {
            count++;
        }
    }

    return count;
}

string[] GetFilteredItems(string[] input, int maxLength)
{
    int count = CountFilteredItems(input, maxLength);
    string[] result = new string[count];
    int k = 0;

    for (int i = 0; i < input.Length; i++)
    {
        if (input[i].Length <= maxLength)
        {
            result[k] = input[i];
            k++;
        }
    }

    return result;
}

void PrintArray(string[] array)
{
    if (array.Length > 0)
    {
        Console.WriteLine("\"" + String.Join("\", \"", array) + "\"");
    }
    else
    {
        Console.WriteLine("пустой массив");
    }
}


string[] input = new string[] { "Hello", "2", "World", ":-)" };
string[] result = GetFilteredItems(input, 3);

PrintArray(input);
Console.WriteLine("~~~~~~~~~~~~~~");
PrintArray(result);
