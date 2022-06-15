string[] CreateArray(int size)
{
    string[] str = new string[size];
    for (int i = 0; i < size; i++)
    {
        Console.Write($"Input {i + 1} word: ");
        str[i] = Console.ReadLine();
    }
    return str;
}
string[] SortArray(string[] array)
{
    int count = 0;
    int size = 0;
    string[] newArray = new string[size];
    string charsCount = string.Empty;
    for (int i = 0; i < array.Length; i++)
    {
        charsCount = array[i];
        for (int j = 0; j < charsCount.Length; j++)
        {
            count = j + 1;
        }
        if (count <= 3)
        {
            size++;
            newArray[i] = array[i];
        }
    }
    return newArray;
}
void ShowArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(i + " ");
    }
    Console.WriteLine();
}
Console.Write("Input array size: ");
int arraySize = Convert.ToInt32(Console.ReadLine());
string[] originalArray = CreateArray(arraySize);
ShowArray(originalArray);
ShowArray(SortArray(originalArray));