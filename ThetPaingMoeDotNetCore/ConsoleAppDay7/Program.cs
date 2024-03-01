public class Animal
{
    public string _name;
    public static int age = 0;
    public Animal(string name)
    {
        _name = name;
    }
    public static void Main(string[] args)
    {
        Animal animal = new("Aung Aung");
        Console.WriteLine($"Animal name is: {animal._name}");
        Console.WriteLine($"Animal's age: {Animal.age}");

        Console.ReadKey();
    }
    // MVC => Html, CSS, JS DOM, Bootstrap, C#
}