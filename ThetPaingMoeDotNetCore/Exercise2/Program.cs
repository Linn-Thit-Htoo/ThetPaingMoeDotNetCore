public class Program
{
    static string adminEmail = "linnthit77387@gmail.com";
    static string adminPassword = "123123";
    public static void Main(string[] args)
    {
        string? email = "";
        string? password = "";

        Console.Write("Please enter your email: ");
        email = Console.ReadLine();
        ValidateEmail(email);

        Console.Write("\nPlease enter your password: ");
        password = Console.ReadLine();
        ValidatePassword(password);

        Console.WriteLine("\nSuccess!");
    }

    public static void ValidateEmail(string email)
    {
        if (email != adminEmail || string.IsNullOrEmpty(email))
        {
            do
            {
                Console.Write("\nYour email is invalid.\nPlease enter again: ");
                email = Console.ReadLine();
                if (email == adminEmail && !string.IsNullOrEmpty(email))
                    break;
            } while (true);
        }
    }
    public static void ValidatePassword(string password)
    {
        if (password != adminPassword || string.IsNullOrEmpty(password))
        {
            do
            {
                Console.Write("\nYour password is invalid.\nPlease enter again: ");
                password = Console.ReadLine();
                if (password == adminPassword && !string.IsNullOrEmpty(password))
                    break;
            } while (true);
        }
    }
}