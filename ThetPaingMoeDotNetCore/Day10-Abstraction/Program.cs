public abstract class Animal
{
    public abstract void AnimalSound(); // abstract method (does not have a body)
    public void Sleep() => Console.WriteLine("zzz"); // regular method
    //private abstract void PrivateMethod(); cannot be private
}

public class Cat : Animal
{
    public override void AnimalSound()
    {
        Console.WriteLine("Cat is making sound...");
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Animal cat = new Cat();
        cat.AnimalSound();
    }
}