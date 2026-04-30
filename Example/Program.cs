namespace Example;

class Program
{
    static void Main(string[] args)
    {


        Warrior warrior2 = new();
        warrior2.name = "ユースケ";
        warrior2.hp = 8;
        Console.WriteLine(warrior2.name);
        Console.WriteLine(warrior2.hp);


        Warrior warrior3 = new("三郎");
        Console.WriteLine(warrior3.name);
        Console.WriteLine(warrior3.hp);
    }
}

