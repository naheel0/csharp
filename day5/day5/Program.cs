class Person
{
    public string Name;
    public int Age;
    public string City;

    public Person(string name, int age, string city)
    {
        Name = name;
        Age = age;
        City = city;
    }
}

class Program
{
    static void Main()
    {
        List<Person> people = new List<Person>()
        {
            new Person("Anu", 30, "Kochi"),
            new Person("Rahul", 22, "Malappuram"),
            new Person("Suresh", 28, "Kozhikode"),
            new Person("Vimal", 24, "Thrissur"),
            new Person("Meera", 35, "Malappuram"),
            new Person("Arjun", 23, "Kochi"),
            new Person("Vishnu", 26, "Malappuram"),
        };
        var result = people
            .Where(p => p.Age > 25 && p.City == "Malappuram")
            .Select(p => new { p.Name, p.Age });
        foreach (var person in result)
        {
            Console.WriteLine($"Name:{person.Name} Age:{person.Age}");
        }
    }
}
