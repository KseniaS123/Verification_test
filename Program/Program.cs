// Задача: Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа.
// Первоначальный массив можно ввести с клавиатуры, либо задать на страте выполнения алгоритма.
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

// Примеры:

// ["hello", "2", "world", ":-)"] -> ["2", ":-)"] 
// ["1234", "1567", "-2", "computer science"] -> ["-2"]
// ["Russia", "Denmark", "Kazan"] -> []

void NewArray (string[] arr)
{
    string[] new_arr = new string[arr.Length];
    for (int i = 0; i < arr.Length; i++)
    {
        int j = 0;
        if (arr[i].Length <= 3)
        {
            new_arr[j] = arr[i];
            Console.Write($"{new_arr[j]} ");
            j++;
        }    
    }
    Console.WriteLine();
}

string[] arr;
Console.WriteLine("Введите массив строк через пробел: ");
string row = Console.ReadLine();
arr = row.Split(' ');
NewArray(arr);


