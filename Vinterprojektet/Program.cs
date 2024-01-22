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

    Console.WriteLine(Methods.ContinueWait(choice1, Princesshp, name1));

string choice2 = Console.ReadLine().ToLower();

if (choice2 == "a")
{
    Console.WriteLine(Methods.breakdoor(choice2, Princesshp, name1));
}

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
        Console.WriteLine(Methods.fallorsafe(Princesshp, name1));
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

    if (choice3b == "a")
    {
        Console.WriteLine(Methods.fallorsafe(Princesshp, name1));
    }

    if (choice3b == "b")
    {
        Console.WriteLine("You carefully grip onto the coarse rocks of the tower, slowly using both your hands and feet to carefully make it down to the tower safely. All you do is make sure not to look down. Once on your feet, you reluctantly walk into the dark forest surrounding the tower. On your way, you find various apples hanging from tree, fresh and untouched, practicaly calling your name. You grab three and same them for later, as you wish to eat them in a more friendly environment. As you walk through the forrest, you feel a dark presence following you. You try to shake off the horrible feeling, but you eventually turn around, face to face with a dragon. It stands over you, its stature haunting and aura threatening, you have no choice but to fight if you want to live.");
        Console.WriteLine("Entering Battle!");
    }
}


// ---------------- Methods ---------------------
internal partial class Program
{
    private static void Main(string[] args)
    {

        Methods.Rungame();

    }
}