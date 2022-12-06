// Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа.
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

// Например:
// [hello, 2, world, :-)] -> [2, :-)]
// ["1234","1567","-2","computer science"] -> ["-2"]
// ["Russia","Denmark","Kazan"] -> []

void PrintArray(string[] array, string message)
{
    string result = message;
    if (array.Length == 0) result += "В массиве нет элементов.";
    for (int i = 0; i < array.Length; i++)
    {
        result += $"{array[i]}, ";
    }
    System.Console.WriteLine(result.TrimEnd(' ', ',')); 
}

string[] ParseArray(string[] arraySource)
{
    string[] arrayTemp = new string[0];
    for (int i = 0; i < arraySource.Length; i++)
    {
        if (arraySource[i].Length <= 3)
        {
            Array.Resize(ref arrayTemp, arrayTemp.Length + 1);
            arrayTemp[arrayTemp.Length - 1] = arraySource[i];
        }
    }
    return arrayTemp;
}

void Main()
{
    System.Console.Clear();
    System.Console.WriteLine("Программа, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа.");
    System.Console.WriteLine();
    
    string[] arraySource = new string[] { "hello", "2", "world", ":-)" };

    PrintArray(arraySource, "Исходный массив: ");
    string[] arrayFinal = ParseArray(arraySource);
    PrintArray(arrayFinal, "Массив с учетом условий задачи: ");
    System.Console.WriteLine();
}

Main();
