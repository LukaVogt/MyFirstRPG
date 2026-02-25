namespace First_Project
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Character Profile
            string name = "Grimm";
            string race = "Half-Orc";
            string characterClass = "Barbar";
            string background = "Soldier";

            // Attributes
            int strength = 17;
            int dexterity = 12;
            int health = 15;
            int level = 1;
            int armorClass = 10;

            // Skills
            int athletics = 5;
            int survival = 3;

            // Equipment
            string mainWeapon = "Combataxe";
            int weaponDamage = 9;
            int gold = 10;

            // Dice
            Random d20 = new Random();
            

            // Status
            bool isAlive = true;

            // Display Profile
            Console.WriteLine("Name: " +  name);
            Console.WriteLine("Race: " + race);
            Console.WriteLine("Class: " + characterClass);
            Console.WriteLine("Background: " + background);

            Console.WriteLine();

            // Display Attributes
            Console.WriteLine("Strength: " + strength);
            Console.WriteLine("Dexterity: " + dexterity);
            Console.WriteLine("Health: " + health);
            Console.WriteLine("Level: " + level);
            Console.WriteLine("Armorclass: " + armorClass);

            // Display Skills
            Console.WriteLine("athletics: " + "+" + athletics);
            Console.WriteLine("Survival: " + "+" + survival);

            Console.WriteLine();

            //Display Equipment
            Console.WriteLine("Weapon: "  + mainWeapon);
            Console.WriteLine("Damage: " + weaponDamage);
            Console.WriteLine("Gold: " + gold);

            Console.WriteLine();
            Console.WriteLine("Gamestart");
            Console.WriteLine();

            // Start
            Console.WriteLine("Grimm is standing in a mud pit and is looking for a tail");
            int survivalthrow = d20.Next(1, 21) + survival;
            Console.WriteLine("Survivalthrow");
            Console.WriteLine("You need a 14");
            Console.WriteLine("You got a " + survivalthrow);
            
            if(survivalthrow >= 14)
            {
                Console.WriteLine("Succeed! The trail goes to the east.");

            }else
            {
                Console.WriteLine("Fail! Grimm just looks at an old rock");
            }
            

            





        }
    }
}
