using System.Xml;

public class Program
{
    public static void Main(string[] args)
    {
        // assignment operators
        int num1 = 10;
        int num2 = 20;

        num1 += 10; // num1 = num1 + 10;
        num2 -= 2; // num2 = num2 - 1;
        num2 *= 10; // num2 = num2 * 10;
        num2 /= 2; // num2 = num2 / 2;
        num2 %= 2; // num2 = num2 % 2;

        /* 
         let a = 2;
         let b = "2";
         */

        // comparison operators
        int a = 12;
        int b = 10;
        bool c = a >= b;

        string firstName = "Linn Thit";

        firstName += " Htoo";

        Console.WriteLine(firstName);

        // logical operators
        string email = "lth1212001@gmail.com";
        string password = "12345";


        // decision makings (if else if and else)
        if (email == "lth1212001@gmail.com" && password == "1234")
        {
            Console.WriteLine("Login Successful!");
        }
        else
        {
            Console.WriteLine("Login Fail!");
        }

        string date = "Monday";
        if (date == "Monday")
        {
            Console.WriteLine("Today is Monday!");
        }
        else if (date == "Tuesday")
        {
            Console.WriteLine("Today is Tuesday!");
        }
        else
        {
            Console.WriteLine("Invalid date!");
        }

        Console.ReadKey();
    }
}