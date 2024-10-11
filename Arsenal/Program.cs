using System.Text.Json;

string contents = File.ReadAllText("weaponl.json");

Weapon w = JsonSerializer.Deserialize<Weapon>(contents);

Console.WriteLine("Hur många attacker?");

int numAttacks = 0;

string numAttacksStr = "";

while (!int.TryParse(numAttacksStr, out numAttacks))
{
    numAttacksStr = Console.ReadLine();
}

int damageSum = 0;

Console.ForegroundColor = ConsoleColor.Red;

for (int i = 0; i < numAttacks; i++)
{
    int damage = w.Attack();
    Console.WriteLine($"+{damage}");
    damageSum += damage;
}

