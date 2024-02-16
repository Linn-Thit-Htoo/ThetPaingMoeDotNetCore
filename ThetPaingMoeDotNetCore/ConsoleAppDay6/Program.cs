public class Program
{
    public static void Main(string[] args)
    {
        Greeting("Hello User!"); // param
        //Sum(1, 2, 3);
        //Console.WriteLine(Sum(1.5, 2.5));

        Console.ReadKey();
    }
    public static void Greeting(string? str = "") // argument
    {
        Console.WriteLine(str);
    }

    public static int Sum(int a, int b)
    {
        return a + b;
    }

    public static int Sum(int a, int b, int c)
    {
        return a + b + c;
    }

    public static double Sum(double a, double b)
    {
        return a + b;
    }

    public static double Sum(double a, double b, double c)
    {
        return a + b + c;
    }
}