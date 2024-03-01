public class Animal
{
    public virtual void MakeSound()
    {
        Console.WriteLine("Animal is making sound..");
    }
}

public class Dog : Animal
{
    private string _Name;
    public int age { get; set; }

    public void SetName(string name)
    {
        _Name = name;
    }

    public string GetName() // public int GetAge(){}
    {
        return _Name;
    }

    public override void MakeSound()
    {
        //base.MakeSound();
        Console.WriteLine("Woof Woof!");
    }
}
public class Cat : Animal
{
    public override void MakeSound()
    {
        //base.MakeSound();
        Console.WriteLine("meow meow!");
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        //Animal dog = new Dog(); // polymorphism
        //dog.MakeSound();

        // Encapsulation
        Dog dog = new(); // cretae new instance
        dog.SetName("Aung Aug");
        Console.WriteLine("Dog's Name: " + dog.GetName());

        dog.age = 10;
        Console.WriteLine("Dog's age: " + dog.age);

        Console.ReadKey();
    }

    public int Sum(int a, int b)
    {
        return a + b;
    }

    public int Sum(int a, int b, int c)
    {
        return a + b + c;
    }
}