using System.Security.Cryptography.X509Certificates;

public class Animal
{
    public string Name;
    public int Age;
    public Animal(string name,int age)
    {
        Name = name;
        Age = age;
    }
    public void speak()
    {
        Console.WriteLine($"Name:{Name} Age{Age}");
    }
}
 public class Dog :Animal
{
    public string Breed;
    public Dog(string name, int age, string breed) : base(name, age)
    {
        Breed = breed;
    }
}
public class Cat:Animal
{
 public Cat(string name,int age):base(name, age) { }
    public void Meow()
    {
        Console.WriteLine("Meow!");
    }
}
class Program
{
     static void Main()
    {
        Dog dog = new Dog("Buddy", 5, "Golden Retriever");
        dog.speak();
        Cat cat = new Cat("Whiskers", 3);
        cat.speak();
        cat.Meow();
    }
}