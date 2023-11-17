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

class Wizard: Character, ICharacter
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

class Hero: Character
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

class Sword
{
    public String name;
    public int attack = 50;

    public Sword(string name)
    {
        this.name = name;
    }
}