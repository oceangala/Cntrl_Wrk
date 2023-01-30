int lenLim = 3; // макс длина искомых элементов 

string[] FillArray(int size)
{
    string[] stArray = new string[size];
    for (int i = 0; i < size; i++)
    {
        Console.Write($"Enter array element №{i + 1}: ");
        stArray[i] = Console.ReadLine();
    }
    return stArray;
}

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    { Console.Write($"{array[i]}   "); }
    Console.WriteLine();
}

int GetSize()
{
    Console.Write("Enter array size: ");
    string? input = Console.ReadLine();
    bool res = int.TryParse(input, out var number);
    if (res)
    {
        int size = Convert.ToInt16(input);
        if (size < 1)
        {
            Console.WriteLine("Array size must be number greater than 0, try again");
            return GetSize();
        }
        else return size;
    }


    else
    {
        Console.WriteLine("Array size must be number greater than 0, try again");
        return GetSize();
    }

}

string[] FindElements(string[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= lenLim) count++;
    }

    if (count > 0)
    {
        string[] resArray = new string[count];
        int i = 0;
        while (i < count)
        {
            for (int j = 0; j < array.Length; j++)
            {
                if (array[j].Length <= 3)
                {
                    resArray[i] = array[j];
                    i++;
                }
            }
        }
        return resArray;
    }
    else
    {
        string[] resArray = new string[1];
        resArray[0] = "";
        return resArray;
    }
}

string[] startArray = FillArray(GetSize());
Console.WriteLine();
Console.WriteLine("Your start array is:");
PrintArray(startArray);
string[] res = FindElements(startArray);
Console.WriteLine();
Console.WriteLine("Your result array is:");
PrintArray(res);
