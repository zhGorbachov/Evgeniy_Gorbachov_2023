List<int> array = new List<int>();
for(int i = 0; i < 10; i++)
{
    Console.Write($"Enter {i + 1} number of array: ");
    array.Add(Convert.ToInt32(Console.ReadLine()));
}
for(int i = 0; i < 10; i++)
{
    for(int j = 1 + i; j < 10; j++)
    {
        if (array[i] == array[j])
            array.Add(array[i]);
    }
}
for (int i = 0; i < array.Count; i++)
{
    Console.WriteLine($"{i+1} number of array = {array[i]}");
}