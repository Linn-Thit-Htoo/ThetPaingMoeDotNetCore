public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Please enter your email: ");
        string? email = Console.ReadLine();

        Console.WriteLine("Please enter your password: ");
        string? password = Console.ReadLine();

        // validation
        if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
        {
            Console.WriteLine("Please fill all fields...");
            return;
        }

        if (email == "linnthit77387@gmail.com" && password == "1234")
        {
            Console.WriteLine("Login Successful!");
        }
        else
        {
            Console.WriteLine("Login Fail!");
        }

        Console.ReadKey();
    }
}