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

            // Enemy(Goblin)
            int goblinHealth = 11;
            int goblinArmorClass = 12;
            int goblinStrength = 2;
            int goblinDamage = 5;

            



            // Start
            Console.WriteLine("Grimm is standing in a mud pit and is looking for a trail");
            int survivalthrow = d20.Next(1, 21) + survival;
            Console.WriteLine("Survivalthrow");
            Console.WriteLine("You need a 14");
            Console.WriteLine("You got a " + survivalthrow);
            
            if(survivalthrow >= 14)
            {
                // Stortelling
                Console.WriteLine("Succeed! The trail goes to the east.");
                Console.WriteLine("You followed the muddy tracks for a while...");
                Console.WriteLine("Suddenly you hear a rustle in a bush.");
                Console.WriteLine("A small, green Goblin stares at you with yellow eyes!");
                Console.WriteLine("It jumps out and waves with its curved sword. That means fight!");

                Console.WriteLine();

                // Fight

                Console.WriteLine("Grimm takes 3 steps closer and takes a swing");
                int strengthThrow = d20.Next(1, 21) + athletics;
                Console.WriteLine("Strengththrow!");
                Console.WriteLine("You need a " + goblinArmorClass);
                Console.WriteLine("You got a " + strengthThrow);

                if (strengthThrow >= goblinArmorClass) {
                    Console.WriteLine("Succeed!");
                    Console.WriteLine("You land a brutal shot and the goblin is now bleeding from its side");
                     goblinHealth = goblinHealth - weaponDamage;
                    Console.WriteLine("The Goblin has " + goblinHealth + " hp" + " left");

                }else
                {
                    Console.WriteLine("Fail!");
                    Console.WriteLine("It doges and you miss by inches and are now open for a counter");
                    int goblinThrow = d20.Next(1, 21) + goblinStrength;

                    if (goblinThrow >= armorClass)
                    {
                        Console.WriteLine("Ouch! The Goblin smashed your shoulderplate an gave you a deep cut ");
                        health = health - goblinDamage;
                    }
                    else
                    {
                        Console.WriteLine("Ha! Its sword just bounced off your armor");
                    }
                }



            }
            else
            {
                Console.WriteLine("Fail! Grimm just looks at an old rock");
            }
            

            





        }
    }
}
