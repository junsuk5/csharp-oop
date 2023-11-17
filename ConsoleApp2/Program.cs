using ConsoleApp2;

var computer = new Computer("삼성컴퓨터", 10000, "Red", "삼성");
Book book = new Book("생존코딩", 40000, "Blue", "123123");

TangibleAsset tangibleAsset1 = computer;
TangibleAsset tangibleAsset2 = book;
TangibleAsset tangibleAsset3 = new Book("11", 400, "11", "11");

List<TangibleAsset> assets = new List<TangibleAsset>();

assets.ForEach((asset) => Console.WriteLine(asset.Name));

computer.GetWeight();
computer.SetWeight(10);

var hero = new Hero("슈퍼맨");

hero.Sword = new Sword("불의 검");

var hero2 = new Hero("배트맨");

SuperHero superHero = new SuperHero("아이언맨");
superHero.IsFly = true;
superHero.Attack(hero2);

Console.WriteLine(hero2.Hp);
hero.Attack(hero2);

Console.WriteLine(hero2.Hp);

Hero.SetMoney(100);

List<IItem> items = new List<IItem>();
items.Add(new House());
items.Add(new Sword("dd"));

class Medic
{
    public void Heal(IBionic bionic)
    {
        
    }
}

class Ghost
{
    public void Emp(IMechanic mechanic)
    {
        
    }
}

interface IWeapon
{
    
}
class Gun: IWeapon
{
    
}
class Soldier
{
    public IWeapon Weapon;
}

interface IBionic {}
interface IMechanic {}

class Scv: IBionic, IMechanic
{
    
}

class SuperHero : Hero
{
    public bool IsFly = false;

    public SuperHero(string name) : base(name)
    {
    }

    public override void Attack(Hero hero)
    {
        base.Attack(hero);

        if (IsFly)
        {
            Console.WriteLine("퍼버벅!!!");
            hero.Hp -= 5;
        }
    }
}

class Wizard : Character, ICharacter
{
    public override void Jump()
    {
        throw new NotImplementedException();
    }

    public void Walk()
    {
        throw new NotImplementedException();
    }
}

interface ICharacter
{
    public void Jump();
    public void Walk();
}

abstract class Character
{
    public String Name;
    public int Hp;

    public void Run()
    {
        Console.WriteLine("우다다다");
    }

    public abstract void Jump();
}

class Hero : Character
{
    public static int Money = 500;

    public Sword Sword;

    public Hero(string name)
    {
        Name = name;
        Hp = 100;
    }

    public static void SetMoney(int value)
    {
        Money = value;
    }

    public virtual void Attack(Hero hero)
    {
        if (Sword != null)
        {
            hero.Hp -= Sword.attack;
        }
    }

    public override void Jump()
    {
        throw new NotImplementedException();
    }
}

interface IItem
{
    
}

class Sword: IItem
{
    public String name;
    public int attack = 50;

    public Sword(string name)
    {
        this.name = name;
    }
}

class House: IItem
{
    
}

