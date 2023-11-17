namespace ConsoleApp2;

interface IThing
{
    public double GetWeight();
    public void SetWeight(double weight);
}

abstract class Asset
{
    private string _name;
    private int _price;

    protected Asset(string name, int price)
    {
        _name = name;
        _price = price;
    }

    public string Name => _name;
    public int Price => _price;
}

abstract class TangibleAsset : Asset, IThing
{
    private string _color;
    private double _weight;

    public string Color => _color;

    protected TangibleAsset(string name, int price, string color) : base(name, price)
    {
        _color = color;
    }

    public double GetWeight()
    {
        return _weight;
    }

    public void SetWeight(double weight)
    {
        _weight = weight;
    }
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

class Computer : TangibleAsset
{
    private string _makerName;

    public string MakerName => _makerName;

    public Computer(string name, int price, string color, string makerName) : base(name, price, color)
    {
        this._makerName = makerName;
    }
}