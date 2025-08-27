FightSim();

static void FightSim()
{
    int p1Hp = 100;
    int p2Hp = 100;

    string p1Name = "David";
    string p2Name = "Goliath";

    Console.WriteLine($"{p1Name} vs {p2Name} - FIGHT!");

    while (p1Hp > 0 && p2Hp > 0)
    {
        Console.WriteLine($"{p1Name}: {p1Hp}");
        Console.WriteLine($"{p2Name}: {p2Hp}");
        Console.ReadLine();

        int p1Damage = Attack("David");
        p2Hp -= p1Damage;
        if (p1Damage > 0)
        {
            Console.WriteLine($"{p1Name} gör {p1Damage} skada på {p2Name}.");
            Console.ReadLine();
        }

        int p2Damage = Attack("Goliath");
        p1Hp -= p2Damage;
        if (p1Damage > 0)
        {
            Console.WriteLine($"{p2Name} gör {p2Damage} skada på {p1Name}.");
            Console.ReadLine();
        }
    }
    Console.ReadLine();


    if (p2Hp <= 0 && p1Hp <= 0)
    {
        Console.WriteLine($"{p1Name} och {p2Name} svimmade båda!");
    }
    else if (p1Hp <= 0)
    {
        Console.WriteLine($"{p2Name} vann!");
    }
    else
    {
        Console.WriteLine($"{p1Name} vann!");
    }
    Console.ReadLine();

    static int Attack(string attacker)
    {
        int baseDamage = Random.Shared.Next(1, 20);
        int roll = Random.Shared.Next(100);

        if (roll < 20)
        {
            Console.WriteLine($"{attacker} missade attacken!");
            Console.ReadLine();
            return 0;
        }
        else if (roll < 50)
        {
            Console.WriteLine($"KRITISK TRÄFF av {attacker}!");
            Console.ReadLine();
            return baseDamage * 2;
        }

        return baseDamage;
    }
}