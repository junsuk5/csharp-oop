namespace ConsoleApp2;

abstract class TangibleAsset
{
    private string _name;
    private int _price;
    private string _color;

    public TangibleAsset(string name, int price, string color)
    {
        _name = name;
        _price = price;
        _color = color;
    }

    public string Name => _name;
    public int Price => _price;
    public string Color => _color;
}

class Book : TangibleAsset
{
    private string _isbn;

    public string Isbn => _isbn;

    public Book(string name, int price, string color, string isbn) : base(name, price, color)
    {
        _isbn = isbn;
    }
}

class Computer 
{
    private string _name;
    private int _price;
    private string _color;
    private string _makerName;

    public Computer(string name, int price, string color, string makerName)
    {
        _name = name;
        _price = price;
        _color = color;
        _makerName = makerName;
    }

    public string Name => _name;
    public int Price => _price;
    public string Color => _color;
    public string MakerName => _makerName;
}