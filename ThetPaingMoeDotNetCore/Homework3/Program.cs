static class Name
{
    // This is for CollectDataFunction();
    public static string? collectUserName;
    public static string? collectPassword;
    public static string? collectPasswordSec;

    // This is for UserInputFunction();
    public static string? inputUserName;
    public static string? inputPassword;

    //Options Declration
    public static string? Option1;
    public static string? Option2;
    public static string? Option3;
    public static string? Option4;

    //Balance Declaration
    public static int MainBalance;
    public static int DepositAmount;
    public static int WithDrawAmount;

    //User Input
    public static string? UserChoice;

    //Bool Declration
    public static bool ForLoop = true;
    public static bool CollectName = true;
    public static bool CollectPassword = true;
    public static bool CollectPasswordSec = true;
    public static bool CheckName = true;
    public static bool CheckPassword = true;

}
public class Program
{
    public static void Main(string[] args)
    {
        do
        {
            CollectDataFunction();

            if (Name.CollectPasswordSec)
            {
                UserInputFunction1();

                if (Name.CheckName)
                {
                    UserInputFunction2();
                }
                else
                {
                    Console.WriteLine("ERROR!!!");
                }
            }
            else
            {
                Console.WriteLine("ERROR!!!");
            }
        } while (!Name.ForLoop);
    }
    public static void CollectDataFunction()
    {
        Console.WriteLine("Sign Up!");

        do
        {
            Console.Write("Please enter your UserName : ");
            Name.collectUserName = Console.ReadLine();

            if (string.IsNullOrEmpty(Name.collectUserName))
            {
                Console.WriteLine("Please Type UserName First!");
            }

            else if (Name.collectUserName.Length <= 4)
            {
                Console.WriteLine("You need to type at least 4 characters!");
            }

            else if (Name.collectUserName.Length >= 16)
            {
                Console.WriteLine("You can just type maximum 16 characters!");
            }
            else
            {
                Name.CollectName = false;
            }
        } while (Name.CollectName);

        do
        {
            if (!Name.CollectName)
            {
                Console.Write("Please enter your Password : ");
                Name.collectPassword = Console.ReadLine();

                if (string.IsNullOrEmpty(Name.collectPassword))
                {
                    Console.WriteLine("Type Password to continue!");
                }

                else if (Name.collectPassword.Length <= 4)
                {
                    Console.WriteLine("You need to type minimum 4 characters or numbers!");
                }

                else if (Name.collectPassword.Length >= 16)
                {
                    Console.WriteLine("You can just type maximum 16 characters or numbers!");
                }
                else
                {
                    Name.CollectPassword = false;
                }
            }
            else
            {
                Console.WriteLine("ERROR!!!");
            }
        } while (Name.CollectPassword);

        do
        {
            if (!Name.CollectPassword)
            {
                Console.Write("Please enter again your password to confirm : ");
                Name.collectPasswordSec = Console.ReadLine();

                if (Name.collectPassword == Name.collectPasswordSec)
                {
                    Console.WriteLine("Your account Sign Up successful!");
                    Name.CollectPasswordSec = true;
                }

                else
                {
                    Console.WriteLine("Please Enter The Same Password As Above!");
                    Name.CollectPasswordSec = false;
                }
            }
            else
            {
                Console.WriteLine("ERROR!!!");
            }
        } while (!Name.CollectPasswordSec);
    }
    public static void UserInputFunction1()
    {
        Console.WriteLine("Log In!");

        do
        {
            Console.Write("Enter your username : ");
            Name.inputUserName = Console.ReadLine();
            Console.WriteLine("");


            if (string.IsNullOrEmpty(Name.inputUserName))
            {
                Console.WriteLine("Please Log In with UserName and Password!");
            }

            else
            {
                CheckUserNameFunction();
            }
        } while (!Name.CheckName);
    }
    public static void CheckUserNameFunction()
    {
        if (Name.inputUserName == Name.collectUserName)
        {
            Name.CheckName = true;
        }

        else
        {
            Console.WriteLine("Please Type UserName Correctly!");
            Name.CheckName = false;
        }
    }

    public static void UserInputFunction2()
    {
        do
        {
            Console.Write("Enter your password : ");
            Name.inputPassword = Console.ReadLine();
            Console.WriteLine("");

            if (string.IsNullOrEmpty(Name.inputPassword))
            {
                Console.WriteLine("Please Log In with UserName and Password!");
            }

            else
            {
                CheckPasswordFunction();
            }
        } while (!Name.CheckPassword);
    }
    public static void CheckPasswordFunction()
    {
        if (Name.inputPassword == Name.collectPassword)
        {
            FinalFunction();
            Name.CheckPassword = true;
        }

        else
        {
            Console.WriteLine("Please Type Password Correctly!");
            Name.CheckPassword = false;
        }
    }
    public static void FinalFunction()
    {
        Name.Option1 = "CheckBalance";
        Name.Option2 = "Deposit";
        Name.Option3 = "WithDraw";
        Name.Option4 = "Quit";

        Name.MainBalance = 0;

        do
        {
            ChooseFunction();
            if (Name.UserChoice == Name.Option1)
            {
                CheckBalanceFunction();
            }
            else if (Name.UserChoice == Name.Option2)
            {
                DepositFunction();
            }
            else if (Name.UserChoice == Name.Option3)
            {
                WithDrawFunction();
            }
            else if (Name.UserChoice == Name.Option4)
            {
                QuitFunction();
                break;
            }
        } while (!Name.ForLoop);
    }
    public static void ChooseFunction()
    {
        Console.WriteLine("Bank Transition!\n");
        Console.WriteLine("You can choose CheckBalance, Deposit and Withdraw!\n");
        Console.WriteLine("To CheckBalance > Type CheckBalance\n");
        Console.WriteLine("To Deposit > Type Deposit\n");
        Console.WriteLine("To Withdraw > Type WithDraw\n");
        Console.WriteLine("To Quit Bank Transition > Type Quit\n");

        Name.UserChoice = Console.ReadLine();
        Console.WriteLine("");
        Name.ForLoop = false;
    }
    public static void CheckBalanceFunction()
    {
        Console.WriteLine($"Your Main Balance is {Name.MainBalance}$\n");
        Name.ForLoop = false;
        Console.ReadKey();
    }
    public static void DepositFunction()
    {
        Console.WriteLine("How many do you want to deposit?");
        Console.Write("Type your amount please : ");
        Name.DepositAmount = Convert.ToInt32(Console.ReadLine());
        Name.MainBalance += Name.DepositAmount;
        Console.WriteLine($"Your Deposit Amount is {Name.DepositAmount}$ and Your MainBalance is {Name.MainBalance}$\n");
        Name.ForLoop = false;
        Console.ReadKey();
    }
    public static void WithDrawFunction()
    {
        Console.WriteLine("How many do you want to withdraw?");
        Console.Write("Type your amount please : ");
        Name.WithDrawAmount = Convert.ToInt32(Console.ReadLine());

        if (Name.WithDrawAmount <= Name.MainBalance)
        {
            Name.MainBalance -= Name.WithDrawAmount;
            Console.WriteLine($"Your MainBalance is {Name.MainBalance}$ and Your Withdraw Amount is {Name.WithDrawAmount}$\n");
        }
        else
        {
            Console.WriteLine("You can't withdraw if more than your MainBalance!");
        }
        Name.ForLoop = false;
        Console.ReadKey();
    }
    public static void QuitFunction()
    {
        Console.WriteLine("Have A Nice Day and See You Soon!!!");
        Name.ForLoop = true;
    }
}