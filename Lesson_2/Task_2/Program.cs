List<Person> person = new List<Person>()
{
    new Person("Mishanya", 14),
    new Person("Sanyok", 25),
    new Person("Evgeniy", 18),
    new Person("Sergey", 41),
    new Person("Moysha", 30)
};

Console.Write("Enter first number: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter second number: ");
int secondNumber = Convert.ToInt32(Console.ReadLine());

var selected = from x in person where x.Age >= firstNumber where x.Age <= secondNumber select x;
Console.WriteLine("-======-======-======-");
foreach(var human in selected)
{
    Console.WriteLine($"{human.Name}: {human.Age}");
}


class Person
{
    public string Name { get; }
    public int Age { get; }
    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }
}