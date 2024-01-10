using System;
using System.ComponentModel;
using System.Globalization;
using System.Reflection;
using System.Runtime.InteropServices;

int Princesshp = 100;


Console.WriteLine("In a cold and desolate stone tower, you reside, alone and shivering. You have no idea who brought you here, for what purpose, or even if you'll ever get out. All you known is that you're a princess. Well, you assume so. Not many common folk proudly display a pure golden crown adorned with jewels atop their head. Not like you would know regardless. All you've ever known is the inside of this tower, inside this bedroom, and all you have to your name is.. actually, do you even have a name?");

string name1 = Console.ReadLine().ToLower();

if (name1 == "")
{
    Console.WriteLine("I can't call you Princess nothing. If we want to continue this story, our glorious heroine needs a proper name! Try again.");
    string name2 = Console.ReadLine().ToLower();

    if (name2 == "")
    {
        Console.WriteLine("Since you seem to determined to not take this seriously, you freeze to death in the tower cold and alone. The only ones to discover you are the rats who feed on your corpse after your passing. There, now get out.");

        Console.ReadLine();
    }
}
else
{
    Console.WriteLine("Ah, yes. Pardon me, Princess " + name1 + ". Now, where was I? Right. All you have to your name is the long floor length dress you're currently wearing, and the aforementioned crown atop your head. You don't know why, but you sit in hope of a handsome hero to come and rescue you. It just feels like thats what you're supposed to do, though a nagging feeling in your head is telling you that no one is coming. What will you do?");
    Console.WriteLine("a. Sit and wait");
    Console.WriteLine("b. Do something about your predicament");
}

string choice1 = Console.ReadLine().ToLower();

 ContinueWait(choice1, Princesshp, name1);

string choice2 = Console.ReadLine().ToLower();

if (choice2 == "b")
{
    int glass = 5;
    Princesshp -= glass;

    Console.WriteLine("You look up the window, rolling up your sleeves as you try to use the tall furniture to climb all the way up. First you jump on the bed, using its the force of the jump to hang on the high shelves. With the help of a few conviniently placed ones, you manage to reach the window, crushing the glass with the help of an item on one of the shelves. You crawl out successfully, but you take a bit of damage from the cut glass.");
    Console.WriteLine("Princess " + name1 + " takes 5 damage!");
    Console.WriteLine("Princess " + name1 + " has " + Princesshp + " hp left!");
    Console.WriteLine("You crawl out of the window, hurt, but determined. Finally breathing in fresh air out in the open, you try to scan your memory for a time you've ever felt this feeling before, but nothing. You remeber nothing but your name, and the fact that youre a princess. Shaking off the lack of deja vu, you look down at the ground and discover the tower is not that high up, but it still isn't a comfortable distance to jump from. You notice a conviniently placed rope on the outside of the window, maybe someone's been here before? It does look like it'll come in handy, but it also looks rather brittle, making you doubt if it can support your weight. What will you do, Princess " + name1 + "?");
    Console.WriteLine("a. Jump down (high risk for injury)");
    Console.WriteLine("b. Take the rope down");

    string choice3a = Console.ReadLine().ToLower();

    if (choice3a == "a")
    {
        Console.WriteLine(fallorsafe);
    }

    if (choice3a == "b")
    {
        Console.WriteLine("You take the rope down for your own safety, and you end up making it down just fine. Once on your feet, you reluctantly walk into the dark forest surrounding the tower. On your way, you find various apples hanging from tree, fresh and untouched, practicaly calling your name. You grab three and same them for later, as you wish to eat them in a more friendly environment. As you walk through the forrest, you feel a dark presence following you. You try to shake off the horrible feeling, but you eventually turn around, face to face with a dragon. It stands over you, its stature haunting and aura threatening, you have no choice but to fight if you want to live.");
        Console.WriteLine("Entering Battle!");
    }
}

if (choice2 == "c")
{
    Console.WriteLine("You approach the stone walls and feel around the area with your hands, caressing the coarse texture of every stone with your hands. Every wall feels rigid and firm, making yiou doubt if theres any way you could possibly break it. However, just as you finish that thought, you feel a small cold breeze suddenly brush your hand. You remove it, thinking you touched something you shouldn't have, but insterad you're greeted by a small hole. You found a weak point! You use your elbow to breaj open the wall, making all of the loose stones crack from the foundation and forming a big hole in the tower's wall.Finally breathing in fresh air out in the open, you try to scan your memory for a time you've ever felt this feeling before, but nothing. You remeber nothing but your name, and the fact that youre a princess. Shaking off the lack of deja vu, you look down at the ground and discover the tower is not that high up, but it still isn't a comfortable distance to jump from. What will you do now?");
    Console.WriteLine("a. Jump down (high risk for injury)");
    Console.WriteLine("b. Climb down");

    string choice3b = Console.ReadLine().ToLower();

    if (choice3b == "b")
    {
        Console.WriteLine("You carefully grip onto the coarse rocks of the tower, slowly using both your hands and feet to carefully make it down to the tower safely. All you do is make sure not to look down. Once on your feet, you reluctantly walk into the dark forest surrounding the tower. On your way, you find various apples hanging from tree, fresh and untouched, practicaly calling your name. You grab three and same them for later, as you wish to eat them in a more friendly environment. As you walk through the forrest, you feel a dark presence following you. You try to shake off the horrible feeling, but you eventually turn around, face to face with a dragon. It stands over you, its stature haunting and aura threatening, you have no choice but to fight if you want to live.");
        Console.WriteLine("Entering Battle!");
    }

    if (choice3b == "a")
    {
        Console.WriteLine(fallorsafe);
    }
}


// ---------------- Methods ---------------------

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

static int fallorsafe(int Princesshp, string name1)
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
    if (choice2 == "a")
    {
        int bruise = 10;
        Princesshp -= bruise;

        Console.WriteLine("You look up at the imposing door in front of you, gulping as you approach. You hadn't really thought through exactly what to do to break down a literal metal door, but you figured enough brute force could solve the problem. Spoken like a true heroine! You prepare to strike against the door by facing the door with your right side. With conviction and determination, you slam against the metal door with the side of your arm, a loud THUD echoing through the tower. An aching pain shoots through shoulder, making you slide down to the floor. You pull up your sleeves to heck the damage, and you can already see a bruise forming.");
        Console.WriteLine("Princess " + name1 + " has taken 10 damage!");
        Console.WriteLine("Remaining hp:" + Princesshp);
        Console.WriteLine("You get back up on your feet, gently rubbing your shoulder to soothe the pain. You take another look around, realizing you just wasted time for no reason. How fun. The same options are at your disposal, what will you do now?");

        Console.WriteLine(ContinueWait);
    }
    return Princesshp;
}

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
                    int princessheal = heal.Next(5,10);
                    Princesshp += princessheal;
                    availableapples--;
                    Console.WriteLine("You grab one of the fresh red apples you picked earlier, chewing through it lack a mad man to restore your energy.");
                    Console.WriteLine("Princess " + name1 + " ate an apple and healed herself!");
                    break;


                
            }
        }
    }
}