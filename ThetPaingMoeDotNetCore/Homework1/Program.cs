public class Program
{
    public static void Main(string[] args)
    {
        TestFunction();

        Console.ReadKey();
    }

    public static void TestFunction()
    {
        string? userName;
        string? email;
        string? role;
        string? password;

        Console.Write("Enter UserName: ");
        userName = Console.ReadLine();

        Console.Write("\nEnter Email: ");
        email = Console.ReadLine();

        Console.Write("\nEnter Role: ");
        role = Console.ReadLine();

        Console.Write("\nEnter Password: ");
        password = Console.ReadLine();

        if (string.IsNullOrEmpty(userName) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(role) || string.IsNullOrEmpty(password))
        {
            Console.WriteLine("Please Fill All Fields!");
            return;
        }
        Console.WriteLine($"User Name is: {userName} Email is: {email} Role is: {role}");
    }
}
