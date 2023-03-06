Console.Write("Enter your first text: ");
string string1 = Console.ReadLine();

Console.Write("Enter your second text: ");
string string2 = Console.ReadLine();

int lengthString1 = string1.Length;
int lengthString2 = string2.Length;

if (lengthString1 > lengthString2)
{
    Console.WriteLine("First string is bigger then second: ");
    Console.WriteLine(AddStrings(string1, string2));
}

else if (lengthString1 == lengthString2)
{
    Console.WriteLine("First and second strings are equal: ");
    ReturnVoid();
}

else
{
    Console.WriteLine("Second string is bigger then first: ");
    Console.WriteLine(SplitStrings(string1, string2));
}

string AddStrings(string string1, string string2)
{
    return string1 + string2;
}

string SplitStrings(string string1, string string2)
{
    string[] splitedStrings = string2.Split(string1[0]);
    string result = string.Join("", splitedStrings);
    return result;
}

void ReturnVoid()
{
    return;
}