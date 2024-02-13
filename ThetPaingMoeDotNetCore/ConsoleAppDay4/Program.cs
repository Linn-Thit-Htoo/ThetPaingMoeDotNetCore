public class Program
{
    public static void Main(string[] args)
    {
        string role = "member";

        if (role == "user")
        {
            // do user related things
        }
        else if (role == "member")
        {
            // do member related things
        }
        else if (role == "admin")
        {
            // do admin related things
        }
        else
        {
            // return error
        }

        DateTime date = DateTime.Now;

        switch (date.DayOfWeek)
        {
            case DayOfWeek.Monday:
                Console.WriteLine("Today is Monday.");
                break;
            case DayOfWeek.Tuesday:
                Console.WriteLine("Today is Tuesday.");
                break;
            case DayOfWeek.Wednesday:
                Console.WriteLine("Today is Wednesday.");
                break;
            case DayOfWeek.Thursday:
                Console.WriteLine("Today is Thursday.");
                break;
            case DayOfWeek.Friday:
                Console.WriteLine("Today is Friday.");
                break;
            case DayOfWeek.Saturday:
                Console.WriteLine("Today is Saturday.");
                break;
            case DayOfWeek.Sunday:
                Console.WriteLine("Today is Sunday.");
                break;
            default:
                Console.WriteLine("Invalid date!");
                break;
        }


        // iteration
        //for (int i = 1; i <= 10; i++)
        //{
        //    Console.WriteLine(i);
        //}

        int a = 0;

        //while (a <= 9)
        //{
        //    Console.WriteLine(a);
        //    a++;
        //}

        //do
        //{
        //    Console.WriteLine("hello");
        //} while (a > 0);

        //string adminPassword = "123123";
        //bool isPasswordCorrect = false;

        //do
        //{
        //    Console.WriteLine("Please enter your password: ");
        //    string? password = Console.ReadLine();

        //    if (password == adminPassword)
        //    {
        //        isPasswordCorrect = true;
        //        Console.WriteLine("Password is correct!");
        //    }

        //} while (!isPasswordCorrect);


        // arrays
        string[] names = { "Leo", "Kelvin", "Linn Thit" };

        //Array.ForEach(names, x => Console.WriteLine(x));
        //foreach (string name in names)
        //{
        //    Console.WriteLine(name);
        //}

        int[] nums = { 1, 2, 3 };
        List<int> marks = new()
        {
            40,
            50,
            60,
            70,
        };
        marks.ForEach(x => Console.WriteLine(x));

        Console.WriteLine("Specific mark: " + marks[1]);

        Console.ReadKey();
    }
}