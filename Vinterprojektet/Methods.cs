using System;
using System.ComponentModel;
using System.Globalization;
using System.Reflection;
using System.Runtime.InteropServices;

public class Methods
{
    public static void Rungame()
    {
        class Battle
        {
            static void Game(int Princesshp, string name1)
            {
                int Dragonhp = 200;
                int availableapples = 4;

                Console.WriteLine("Dragon prepares itself to fight againt you, flapping its gorgeous wings with all its might. It seems its waiting for you to strike first.");

                while (Princesshp > 0 && Dragonhp > 0)
                {
                    Console.WriteLine("What will you do, Princess " + name1 + "?");
                    Console.WriteLine("a. Throw your crown");
                    Console.WriteLine("b. Kick");
                    Console.WriteLine("c. Punch");
                    Console.WriteLine("d. Heal");

                    string input = Console.ReadLine().ToLower();

                    switch (input)
                    {
                        case "a":
                            Random crowndmg = new Random();
                            int crowndamage = crowndmg.Next(5, 20);
                            Dragonhp -= crowndamage;
                            Console.WriteLine("You threw your crown at the savage beast, the sharp points piercing it's skin with ease.");
                            Console.WriteLine("Princess" + name1 + " did " + crowndamage + " damage!");
                            break;
                        case "b":
                            Random kickdmg = new Random();
                            int kickdamage = kickdmg.Next(5, 20);
                            Dragonhp -= kickdamage;
                            Console.WriteLine("You ran at full speed towards the beast, kicking it as hard as you could in any sensitive area you could reach.");
                            Console.WriteLine("Princess" + name1 + " did " + kickdamage + " damage!");
                            break;
                        case "c":
                            Random punchdmg = new Random();
                            int punchdamage = punchdmg.Next(10, 30);
                            Dragonhp -= punchdamage;
                            Console.WriteLine("You ran at the beast, raising your fist in the air and preparing for impact before unleashing an unmerciful punch.");
                            Console.WriteLine("Princess" + name1 + " did " + punchdamage + " damage!");
                            break;
                        case "d":
                            Random heal = new Random();
                            int princessheal = heal.Next(5, 10);
                            Princesshp += princessheal;
                            availableapples--;
                            Console.WriteLine("You grab one of the fresh red apples you picked earlier, chewing through it lack a mad man to restore your energy.");
                            Console.WriteLine("Princess " + name1 + " ate an apple and healed herself!");
                            break;
                    }
                }
            }
        }
        

        static void ContinueWait(string choice1, int princesshp, string name1)
        {
            if (choice1 == "a")
            {
                Console.WriteLine("You continue to wait for someone to rescue you, getting on your knees and clasping your hands together, hoping whatever divine entity out there has mercy on you. Hours turn into days, days into weeks. You seriously begin to wonder if you'll ever leave before you turn to a pile of bones.. In reality, its only been about 30 minutes, but its enough to make you rise to your feet again. You first notice the big metal door blocking your way down into the stairscase of the tower. Its large and imposing, making you feel like an ant compared to its great height and width. You look around the room and notice the cracks in the stone walls of your encloseure, making you wonder if you could somehow break through them and jump down. You'd always assumed that you were high up. but you had no way of knowing, as the only window was on the ceiling, letting the occasional sunlight shine through. What will you do?");
                Console.WriteLine("a. Try to break down the door");
                Console.WriteLine("b. Climb to the window on the ceiling");
                Console.WriteLine("c. Find a weakness and try to break the stone walls");

                princesshp = breakdoor(choice1, princesshp, name1);
            }

            if (choice1 == "b")
            {
                Console.WriteLine("Determined to find a way out on your own, you rise to your feet and frantically look around the room.  You first notice the big metal door blocking your way down into the stairscase of the tower. Its large and imposing, making you feel like an ant compared to its great height and width. You look around the room and notice the cracks in the stone walls of your encloseure, making you wonder if you could somehow break through them and jump down. You'd always assumed that you were high up. but you had no way of knowing, as the only window was on the ceiling, letting the occasional sunlight shine through. What will you do?");
                Console.WriteLine("a. Try to break down the door");
                Console.WriteLine("b. Climb to the window on the ceiling");
                Console.WriteLine("c. Find a weakness and try to break the stone walls");

                princesshp = breakdoor(choice1, princesshp, name1);
            }
        }

        public static int fallorsafe(int Princesshp, string name1)
        {
            Random random = new();

            int fate = random.Next(2);

            if (fate == 0)
            {
                int leap = 50;
                Princesshp -= leap;

                Console.WriteLine("You decide to take a leap of faith, believing that you'd at most sprain your ankle. You jumped down with your eyes closed, feet first. Unfortunately, after just sitting there for so long, your bones aren't exactly the strongest. Maybe thats something i should've told you before giving you the choice.. whoops. Anyways, you severly damage your ankles, making you groan in pain. Thankfully they're not broken, but it hurts to stand.");
                Console.WriteLine("Princess " + name1 + " takes 50 damage!");
                Console.WriteLine("Princess " + name1 + " has " + Princesshp + " hp left!");
                Console.WriteLine("Despite the pain, you stagger forward into the dark forrest surrounding the tower you fell from. On your way, you find various apples hanging from tree, fresh and untouched, practicaly calling your name. You grab three and same them for later, as you wish to eat them in a more friendly environment. As you walk through the forrest, you feel a dark presence following you. You try to shake off the horrible feeling, but you eventually turn around, face to face with a dragon. It stands over you, its stature haunting and aura threatening, you have no choice but to fight if you want to live.");
                Console.WriteLine("Entering Battle!");
            }

            else
            {
                Console.WriteLine("You decide to take a leap of faith, believing that you'd at most sprain your ankle. You jumped down with your eyes closed, feet first. Fortunately, despite sitting in that tower for so long, you landed with minimal injury. Sure, your ankles feel a bit tense but youre fine! Once on your feet, you reluctantly walk into the dark forest surrounding the tower. On your way, you find various apples hanging from tree, fresh and untouched, practicaly calling your name. You grab three and same them for later, as you wish to eat them in a more friendly environment. As you walk through the forrest, you feel a dark presence following you. You try to shake off the horrible feeling, but you eventually turn around, face to face with a dragon. It stands over you, its stature haunting and aura threatening, you have no choice but to fight if you want to live.");
                Console.WriteLine("Entering Battle!");
            }

            return Princesshp;
        }


        static int breakdoor(string choice2, int Princesshp, string name1)
        {
            int bruise = 10;
            Princesshp -= bruise;

            Console.WriteLine("You look up at the imposing door in front of you, gulping as you approach. You hadn't really thought through exactly what to do to break down a literal metal door, but you figured enough brute force could solve the problem. Spoken like a true heroine! You prepare to strike against the door by facing the door with your right side. With conviction and determination, you slam against the metal door with the side of your arm, a loud THUD echoing through the tower. An aching pain shoots through shoulder, making you slide down to the floor. You pull up your sleeves to heck the damage, and you can already see a bruise forming.");
            Console.WriteLine("Princess " + name1 + " has taken 10 damage!");
            Console.WriteLine("Remaining hp:" + Princesshp);
            Console.WriteLine("You get back up on your feet, gently rubbing your shoulder to soothe the pain. You take another look around, realizing you just wasted time for no reason. How fun. The same options are at your disposal, what will you do now?");

            Console.WriteLine(ContinueWait);
            return Princesshp;
        }
    }
}
