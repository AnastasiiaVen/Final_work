/* Написать программу, которая из имеющегося массива строк формирует массив из строк, 
длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, 
либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
лучше обойтись исключительно массивами.*/

string[] CreateArrayStringsSizeLess4 (string[] enteredArray)
{
    int sizeResultArray = 0;
    for (int i = 0; i < enteredArray.Length; i++)
    {
        if (enteredArray[i].Length < 4)
        {
            sizeResultArray++;
        }
    }
    string[] arrayStringsSizeLess4 = new string[sizeResultArray];
    int j = 0;
    for (int i = 0; i < enteredArray.Length; i++)
    {
        if (enteredArray[i].Length < 4)
        {
            arrayStringsSizeLess4[j]=enteredArray[i];
            j++;
        }
    }
    return arrayStringsSizeLess4;
}


void ShowArray(string[] stringArray)
{
    Console.Write("[");
    for (int i = 0; i < stringArray.Length; i++)
    {
        Console.Write($"\"{stringArray[i]}\"");
        if (i < stringArray.Length - 1)
        {
            Console.Write(", ");
        }
    }
    Console.Write("]");
}

Console.Clear();
string[] stringArray = { "Russia", "Denmark", "Kazan" };
string[] finalArray = CreateArrayStringsSizeLess4(stringArray);
ShowArray(stringArray);
Console.Write(" -> ");
ShowArray(finalArray);

