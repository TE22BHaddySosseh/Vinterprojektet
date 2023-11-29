(int hp, string name) = (100, "bricks");

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
else {
    Console.WriteLine("Ah, yes. Pardon me, Princess " + name1 + ". Now, where was I? Right. All you have to your name is the long floor length dress you're currently wearing, and the aforementioned crown atop your head. You don't know why, but you sit in hope of a handsome hero to come and rescue you. It just feels like thats what you're supposed to do, though a nagging feeling in your head is telling you that no one is coming. What will you do?");
    Console.WriteLine("a. Give up");
    Console.WriteLine("b. Do something about your predicament");
}

string choice1 = Console.ReadLine().ToLower();

ContinueWait(choice1);

static void ContinueWait(string choice1)
{
    if (choice1 == "a")
    {
        Console.WriteLine("You continue to wait for someone to rescue you, getting on your knees and clasping your hands, hoping whatever divine entity out there has mercy on you. Hours turn into days, days into weeks.. you seriously begin to wonder if you'll leave there before you  turn to a pile of bones. In reality, its only been about 30 minutes, but its enough to make you rise to your feet again. You first notice the big metal door blocking your way down into the stairscase. Its large and imposing, making you feel like an any compared to its great height and width. You look around the room and notice the cracks in the stone walls of your encloseure, making you wonder if you could somehow break through them and jump down. You'd always assumed that you were high up. but you had no way of knowing, as the only window was on the ceiling, letting the occasional sunlight shine through. What will you do?");
        Console.WriteLine("a. Try to break down the door");
        Console.WriteLine("b. ");
        Console.WriteLine("c. ");
    }
}