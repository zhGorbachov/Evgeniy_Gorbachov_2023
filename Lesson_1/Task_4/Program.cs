Console.Write("Enter your first text: ");
string string1 = Console.ReadLine();

Console.Write("Enter your second text: ");
string string2 = Console.ReadLine();

int lengthString1 = string1.Length;
int lengthString2 = string2.Length;

if (lengthString1 > lengthString2)
{
    Console.WriteLine("First string is bigger then second: ");
    string result = string1 + " "  + string2;
    Console.WriteLine(result);
}

else if (lengthString1 == lengthString2)
{
    Console.WriteLine("First and second strings are equal: ");
}

else
{
    Console.WriteLine("Second string is bigger then first: ");
    string[] splitedStrings = string2.Split(string1[0]);
    string result = string.Join("", splitedStrings);
    Console.WriteLine(result);
}
