public class Program
{
    //public string name { get; set; }  program.name = "" program.name
    public string _name = "";
    public void SetName(string name)
    {
        _name = name;
    }
    public string GetName()
    {
        return _name;
    }
    public static void Main(String[] args)
    {
        int a = 0;
        //while (a < 10)
        //{
        //    if (a == 5)
        //        return; // break;
        //    Console.WriteLine(a);
        //    a++;
        //}

        //for (int i = 0; i < 10; i++)
        //{
        //    if (i == 4)
        //        continue;
        //    Console.WriteLine(i); // 0 1 2 3 5 6 7 8 9
        //}

        string firstName = "Linn ";
        string lastName = "Thit";
        string fullName = firstName + lastName;
        string subStrFirstName = firstName.Substring(0).Trim();

        Console.WriteLine(fullName.ToUpper());
        Console.WriteLine($"Lower case name: {fullName.ToLower()}");
        Console.WriteLine($"Substring name\t: {subStrFirstName.Length}");

        string email = "";
        Program program = new();
        bool isEmailInvalid = program.IsNull(email);

        program.SetName("tester");
        Console.WriteLine(program.GetName());
    }

    public bool IsNull(string str)
    {
        return string.IsNullOrEmpty(str);
    }

    public static double Sum(double a, double b)
    {
        return a + b;
    }
}