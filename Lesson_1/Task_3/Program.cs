List<int> array = new List<int>();

for(int i = 0; i < 10; i++)
{
    Console.Write($"Enter {i + 1} number of array: ");
    array.Add(Convert.ToInt32(Console.ReadLine()));
}

Console.Write("Enter a number: ");
int number = Convert.ToInt32(Console.ReadLine());

for(int i = 0; i < 10; i++)
{
    if (array[i] == number)
    {
        array.Insert(i + 1, number);
        i++;
    }
}
for (int i = 0; i < array.Count; i++)
{
    Console.WriteLine($"{i+1} number of array = {array[i]}");
}