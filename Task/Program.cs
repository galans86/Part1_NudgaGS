//Написать программу, которая из имеющегося массива строк формирует массив строк, 
//длина которых меньше либо равна 3 символа.


//начальный массив
string[] array = { "hello", "2", "world", ":-)", };  
//string[] array = { "1234", "1567", "-2", "computer science" };
//string[] array = { "Russia", "Denmark", "Kazan" };

Console.WriteLine("Исходный массив:");
PrintArray(array);
string[] newArray = CreateArray(array);
Console.WriteLine("Результат:");
PrintArray(newArray);


//Определение длины нового массива
int GetSize(string[] array)
{
    int size = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
            size++;
    }
    return size;
}

//Создание нового массива
string[] CreateArray(string[] array)
{
    int size = GetSize(array);
    if (size <= 0)
    {
        string[] empArray = { "" };
        return empArray;
    }

    string[] newArray = new string[size];
    int j = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            newArray[j] = array[i];
            j++;
        }
    }
    return newArray;
}

//Вывод массива 
void PrintArray(string[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length - 1; i++)
        Console.Write($"{array[i]}, ");
    Console.WriteLine($"{array[array.Length - 1]}] ");
}

