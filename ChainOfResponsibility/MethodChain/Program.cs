// See https://aka.ms/new-console-template for more information
using MethodChain;

var goblin = new Creature("Goblin", 1, 1);
Console.WriteLine(goblin);

var root = new CreatureModifier(goblin);

while (true)
{
    Console.WriteLine("1-Double attack by 2; 2-Increase defense by 3; 3-Kill goblin");
    Console.Write("Select an option: ");
    int choice = int.Parse(Console.ReadLine());

    switch(choice) 
    {
        case 1: root.Add(new DoubleAttackModifier(goblin)); break;
        case 2: root.Add(new IncreasedDefenseModifier(goblin)); break;
        case 3: root.Add(new KillModifier(goblin)); break;
    }

    if (choice == 3) break;
}

Console.WriteLine("---------------------------");
Console.WriteLine("Steps: ");
root.Handle();

Console.WriteLine(goblin);
