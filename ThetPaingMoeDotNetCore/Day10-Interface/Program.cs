public interface IMammal // I means interface symbol
{
    public void Eat();
    public void Run();
}

public interface IAnimal // I means interface symbol
{
    public void Sleep();
}

public class Cat : IAnimal, IMammal
{
    public void Eat()
    {
        Console.WriteLine("Cat is eating...");
    }

    public void Run()
    {
        Console.WriteLine("Cat is running...");
    }

    public void Sleep()
    {
        Console.WriteLine("Cat is sleeping...");
    }
}
public class Program
{
    public static void Main(string[] args)
    {
        Cat cat = new();
        cat.Sleep();
        cat.Run();
        cat.Eat();

        Console.ReadKey();
    }
}