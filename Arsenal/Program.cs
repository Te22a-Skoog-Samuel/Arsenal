using System.Text.Json;

string contents = File.ReadAllText("weapon.json");

Weapon StickyStick = JsonSerializer.Deserialize<Weapon>(contents);

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
    int damage = StickyStick.Attack();
    Console.WriteLine($"+{damage}");
    damageSum += damage;
}

Console.ResetColor();

Console.WriteLine($"Du gjorde totalt {damageSum} points of damage");

Console.ReadLine();

Weapon Stick = new() {
  Name = "StickyStick"
};

string serialized = JsonSerializer.Serialize(Stick);

File.WriteAllText("weapon.json", serialized);