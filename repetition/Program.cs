FightSim();

static void FightSim()
{
int p1Hp = 100;
int p2Hp = 75;

string p1Name = "David";
string p2Name = "Goliath";

Console.WriteLine($"{p1Name} vs {p2Name} - FIGHT!");

while (p1Hp > 0 && p2Hp > 0)
{
    Console.WriteLine($"{p1Name}: {p1Hp}");
    Console.WriteLine($"{p2Name}: {p2Hp}");

    int p1Damage = Random.Shared.Next(25);
    p2Hp -= p1Damage;
    Console.WriteLine($"{p1Name} gör {p1Damage} på {p2Name}");

    int p2Damage = Random.Shared.Next(15);
    p1Hp -= p2Damage;
    Console.WriteLine($"{p2Name} gör {p2Damage} på {p1Name}");
    Console.ReadLine();
}

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
}