using MagicDestroyers.Characters;
using MagicDestroyers.Characters.Melee;
using MagicDestroyers.Characters.Spellcasters;

namespace MagicDestroyers
{
    class EntryPoint
    {
        static void Main()
        {
            Warrior warrior = new Warrior("Phil", 80);
            System.Console.WriteLine(warrior.Weapon);
            System.Console.WriteLine(warrior.BodyArmor);

            Necromancer necromancer = new Necromancer();
            System.Console.WriteLine(necromancer.Weapon);
            System.Console.WriteLine(necromancer.BodyArmor);



        }
    }
}
