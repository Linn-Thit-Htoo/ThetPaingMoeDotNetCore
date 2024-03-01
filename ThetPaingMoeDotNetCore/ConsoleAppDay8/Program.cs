//public class AnimalDataModel
//{
//    public List<AnimalDetailsModel> Data { get; set; }
//}

//public class AnimalDetailsModel
//{
//    public string Name { get; set; }
//    public int Age { get; set; }
//    public string Color { get; set; }
//}

//public class Program
//{
//    public static void Main(string[] args)
//    {
//        var model = new AnimalDataModel()
//        {
//            Data = new List<AnimalDetailsModel>()
//            {
//              new AnimalDetailsModel()
//              {
//                  Name = "Aung Aung",
//                  Age = 5,
//                  Color = "green"
//              }
//            }
//        };

//        Console.WriteLine(model);
//    }
//}

public class Animal // parent class, main class, super class
{
    public string _name { get; set; } // zero length (empty string)
    public int _legs { get; set; }
    protected int? _age; // 0 null
    private string _color = "green";

    // getter
    public string GetColor()
    {
        return _color;
    }

    // setter
    public void SetColor(string color)
    {
        _color = color;
    }
}

public class Cat : Animal // derived class, child class, sub class
{
    public static void Main(String[] args)
    {
        Cat cat = new() // Object Initializer Syntax
        {
            _name = "name",
            _legs = 4
        };
        Console.WriteLine(cat._age);
        Console.WriteLine(cat._age == null);
        cat.SetColor("red");
        Console.WriteLine(cat._name);
    }
}