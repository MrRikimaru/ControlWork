// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями,
// лучше обойтись исключительно массивами.

Console.Write("Введите размер массива:");
string? temp = Console.ReadLine();
if (!int.TryParse(temp, out int size) || (size < 0)) Console.WriteLine("Ошибка ввода!"); //Проверка на вводимое значение пользователем. 
else                                                                                     //Значение должно быть численным и больше либо равно 0
{
    string[] words = new string[size];
    Console.WriteLine("Заполните массив:");
    FillArray(words);
    Console.WriteLine($"\nИсходный массив:");
    PrintArray(words);
    string[] selectedWords = WordSelect(words);
    Console.WriteLine($"\nМассив после выборки:");
    PrintArray(selectedWords);
}


void FillArray(string[] array) //Метод заполнения массива
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{i}:");
        string? temp = Console.ReadLine();
        if (temp != null) array[i] = temp;
    }
}

void PrintArray(string[] array) //Метод вывода массива
{
    for (int i = 0; i < array.Length; i++)
    {
        if (i != array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}.\n");
    }
}

string[] AddWord(string[] array, string value) //Метод для добавления элемента в массив
{
    string[] buffer = new string[array.Length + 1];
    for (int i = 0; i < array.Length; i++) buffer[i] = array[i];
    buffer[buffer.Length - 1] = value;
    return buffer;
}

string[] WordSelect(string[] array) //Метод для выборки необходимых по условию значений
{
    string[] result = new string[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3) result = AddWord(result, array[i]);
    }
    return result;
}