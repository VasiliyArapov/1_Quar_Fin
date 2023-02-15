int n;
Console.WriteLine("Введите число элементов массива");
n = Convert.ToInt16(Console.ReadLine());
string [] array = new string[n];
int i = 0;
while (i < n)
{
   Console.WriteLine("Введите элемент массива");
    array[i] = Console.ReadLine();
    Console.WriteLine();
    i++;
}

Console.WriteLine($"[{String.Join(",", array)}]");
string [] new_array = SelectSmallUnits(array);
Console.WriteLine($"[{String.Join(",", new_array)}]");

// ------------Methods------------
string[] SelectSmallUnits(string[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i].Length <= 3)
            count++;
    }
    int size = count;
    string[] res = new string[size];
    count = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i].Length <= 3)
        {
            res[count] = array[i];
            count++;
        }
    }
    return res;
}