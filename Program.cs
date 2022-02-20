/* Написать программу, которая из имеющегося массива строк формирует массив из строк, 
длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, 
либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
лучше обойтись исключительно массивами.*/

int SelectStringsSizeLess4(string[] firstArray)
{
    int sizeSecondArray = 0;
    for (int i = 0; i < firstArray.Length; i++)
    {
        if (firstArray[i].Length < 4)
        {
            sizeSecondArray++;
        }
    }
    return sizeSecondArray;
}

string[] CreateArrayStringsSizeLess4 (string[] enteredArray, int sizeResultArray)
{
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

void ShowArrayStringsSizeLess4 (string[] stringArray)
{
    Console.Write("[");
    for (int i = 0; i < stringArray.Length; i++)
    {
        Console.Write ($"\"{stringArray[i]}\"");
        if (i < stringArray.Length-1)
        {
           Console.Write(", "); 
        }
    }
    Console.Write("]");
}

Console.Clear();
string[] stringArray = { "hello", "2", "world", ":-)"};
int sizeFinalArray = SelectStringsSizeLess4(stringArray);
string[] finalArray = CreateArrayStringsSizeLess4(stringArray, sizeFinalArray);
ShowArrayStringsSizeLess4(stringArray);
Console.Write(" -> ");
ShowArrayStringsSizeLess4(finalArray);

