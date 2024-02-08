using System.Security.Cryptography.X509Certificates;

public class Program
{
    public static void Main(string[] args)
    {
        int num1 = 10; // declaration & assignment
        string name; // variable declaration
        name = "Thet Paing Moe"; // assignment
        bool isActive = false;
        char firstLetter = 'A';

        num1 = 100; // re-assign or override

        // constant fields must have declaration & assignment
        const int num2 = 15; // constant var cannot be overriden
        //Console.WriteLine(num2);

        UserGreeting();

        Console.ReadKey();
    }

    public static void UserGreeting()
    {
        Console.WriteLine("Enter your age: ");
        int age = Convert.ToInt32(Console.ReadLine());

        // string interpolation
        Console.WriteLine($"Your age in next 5 years is: {age + 5}");

        string firstName = "Linn Thit";
        string lastName = " Htoo";

        Console.WriteLine($"My name: {firstName + lastName}");
    }
}