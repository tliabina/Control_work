/*Создать репозиторий на GitHub
Нарисовать блок-схему алгоритма (можно обойтись блок-схемой основной содержательной части,
 если вы выделяете её в отдельный метод)
Снабдить репозиторий оформленным текстовым описанием решения (файл README.md)
Написать программу, решающую поставленную задачу
Использовать контроль версий в работе над этим небольшим 
проектом (не должно быть так, что всё залито одним коммитом,
 как минимум этапы 2, 3, и 4 должны быть расположены в разных коммитах)

Задача: Написать программу, которая из имеющегося массива строк формирует
 новый массив из строк, длина которых меньше, либо равна 3 символам. 
 Первоначальный массив можно ввести с клавиатуры, либо задать 
 на старте выполнения алгоритма. При решении не рекомендуется пользоваться 
 коллекциями, лучше обойтись исключительно массивами.

Примеры:

[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
[“1234”, “1567”, “-2”, “computer science”] → [“-2”]
[“Russia”, “Denmark”, “Kazan”] → []
// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

string[] input = new string[] {"Hello",   "2",    "World",    ":-)"};*/

// метод принимает массив и критерий поиска,
// возвращает количество подходящих элементов,
// чтобы использовать его для создания нового массива
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

// будет копировать подходящие под критерий поиска
// элементы из старого массива в новый массив

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


// сделать метод, которая напечатает массив
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
