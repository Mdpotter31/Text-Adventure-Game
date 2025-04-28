using System.Media;



Console.Title = "Text Adventures";

Console.Clear();
Console.ForegroundColor = ConsoleColor.Gray;

Console.WriteLine("Welcome to Undead Whispers of the Night!");


string asciiArt = @"
 
██╗░░░██╗███╗░░██╗██████╗░███████╗░█████╗░██████╗░  ░██╗░░░░░░░██╗██╗░░██╗██╗░██████╗██████╗░███████╗██████╗░░██████╗
██║░░░██║████╗░██║██╔══██╗██╔════╝██╔══██╗██╔══██╗  ░██║░░██╗░░██║██║░░██║██║██╔════╝██╔══██╗██╔════╝██╔══██╗██╔════╝
██║░░░██║██╔██╗██║██║░░██║█████╗░░███████║██║░░██║  ░╚██╗████╗██╔╝███████║██║╚█████╗░██████╔╝█████╗░░██████╔╝╚█████╗░
██║░░░██║██║╚████║██║░░██║██╔══╝░░██╔══██║██║░░██║  ░░████╔═████║░██╔══██║██║░╚═══██╗██╔═══╝░██╔══╝░░██╔══██╗░╚═══██╗
╚██████╔╝██║░╚███║██████╔╝███████╗██║░░██║██████╔╝  ░░╚██╔╝░╚██╔╝░██║░░██║██║██████╔╝██║░░░░░███████╗██║░░██║██████╔╝
░╚═════╝░╚═╝░░╚══╝╚═════╝░╚══════╝╚═╝░░╚═╝╚═════╝░  ░░░╚═╝░░░╚═╝░░╚═╝░░╚═╝╚═╝╚═════╝░╚═╝░░░░░╚══════╝╚═╝░░╚═╝╚═════╝░


░█████╗░███████╗  ████████╗██╗░░██╗███████╗  
██╔══██╗██╔════╝  ╚══██╔══╝██║░░██║██╔════╝  
██║░░██║█████╗░░  ░░░██║░░░███████║█████╗░░  
██║░░██║██╔══╝░░  ░░░██║░░░██╔══██║██╔══╝░░  
╚█████╔╝██║░░░░░  ░░░██║░░░██║░░██║███████╗  
░╚════╝░╚═╝░░░░░  ░░░╚═╝░░░╚═╝░░╚═╝╚══════╝  

███╗░░██╗██╗░██████╗░██╗░░██╗████████╗
████╗░██║██║██╔════╝░██║░░██║╚══██╔══╝
██╔██╗██║██║██║░░██╗░███████║░░░██║░░░
██║╚████║██║██║░░╚██╗██╔══██║░░░██║░░░
██║░╚███║██║╚██████╔╝██║░░██║░░░██║░░░
╚═╝░░╚══╝╚═╝░╚═════╝░╚═╝░░╚═╝░░░╚═╝░░░";

Console.WriteLine(asciiArt);

Console.ResetColor();

Console.WriteLine("\nPress Enter to start...");
Console.ReadLine();
Console.Clear();


//Game Start



//Music Start
SoundPlayer introSoundPlayer = new SoundPlayer("C:\\Users\\myff3\\source\\repos\\C# Projects\\Text Based Adventure\\Text Based Adventure\\Tavern.wav");
introSoundPlayer.Load();
introSoundPlayer.Play();



//For keeping track of the players class
string chosenClass = "";

//For simulating typing
static void TypeText(string text, int delayMilliseconds)
{
    foreach (char c in text)
    {
        Console.Write(c);
        Thread.Sleep(delayMilliseconds);
    }
}

static void ClassStats(string playerClass, int hitPoints, string playerWeapon, int hitRange, string chanceRoll, string damageRoll)
{
    Console.WriteLine("You chose " + playerClass + ".");
    Console.WriteLine("Your hitpoints are " + hitPoints + ".");
    Console.WriteLine("Your weapon is a " + playerWeapon + ".");
    Console.WriteLine("Your range is " + hitRange + ".");
    Console.WriteLine("Your hit chance roll is " + chanceRoll + ".");
    Console.WriteLine("Your damage roll is " + damageRoll + ".");
}

static void DiceRoll(int hitChanceModifer, int damageModifier)
{
    Random random = new Random();
    int d20 = random.Next(1, 21); // Generates a number between 1 and 21
    int d6 = random.Next(1, 7);// Generates a number between 1 and 6


    int hitChanceRoll = d20 + hitChanceModifer;
    int hitDamageRoll = d6 + damageModifier;

    Console.WriteLine("You rolled a " + d20 + " for a total of " + hitChanceRoll);
    Console.WriteLine("You rolled a " + d6 + " for a total of " + hitDamageRoll);

    //Use DiceRoll(int,int);
}




TypeText("Welcome, we will start by getting your name, adventurer.", 20);
Console.WriteLine();//For new line purposes.
string name = Console.ReadLine();

Console.WriteLine("Hello " + name + ".");


while (true)
{
    Console.WriteLine("Before we begin, please pick your class. Only provide one of the numbers 1 - 3.");
    Console.WriteLine(" 1    Warrior: As a brave warrior, you excel in close combat.");
    Console.WriteLine(" 2    Wizard:  As a powerful wizard, you command the forces of magic.");
    Console.WriteLine(" 3    Ranger:  As a skilled archer, you strike from a distance with precision.");
    string classInput = Console.ReadLine();
    Thread.Sleep(100);



    if (classInput == 1)
    {
        ClassStats("warrior", 20, "Longsword", 2, "D20 + 6", "D6 + 6");
        chosenClass = "warrior"
                break;

    }
    else if (classInput == 2)
    {
        ClassStats("wizard", 15, "Staff", 7, "D20 + 4", "D6 + 4");
        chosenClass = "wizard"
                break;


    }
    else if (chosenClass == 3)

    {
        ClassStats("ranger", 17, "Bow", 13, "D20 + 6", "D6 + 2");
        classInput = "ranger"
                break;

    }
    else
    {
        Console.WriteLine("Invalid Input. Please try again.");

    }

    // For the purpose of slowing the text boxes down.
    Thread.Sleep(1000);

    Console.WriteLine("Continue? (y/n)"); //For allowing the player to confirm their choice.
    string continueInput = Console.ReadLine().ToLower();

    if (continueInput == "y")
    {
        // If the input is 'n', exit the loop
        break;
    }
    if (continueInput == "n")
    {
        Console.WriteLine("Please choose carefully");
    }

}


Console.Clear();



TypeText("Welcome, brave adventurer, to a realm cloaked in shadows and mystery.", 20);
Console.WriteLine();
TypeText("This dark fantasy Text-Based Adventure unfolds a tale of choices, riddles, and perilous combat.", 20);
Console.WriteLine();
TypeText("In this enigmatic world, every decision you make carves a path, weaving a narrative that intertwines with the unknown.", 20);
Console.WriteLine();
TypeText("As your journey unfolds, the echoes of your choices ripple through the fabric of the story, shaping its twists and turns.", 20);
Console.WriteLine();
TypeText("Beware, for your survival hinges on your class – a seasoned warrior, a wizened wizard, or a shadow-clad ranger.", 20);
Console.WriteLine();
TypeText("In the dark corners of this realm, combat is a dance with destiny, guided by the roll of unseen dice.", 20);
Console.WriteLine();
TypeText("Your class and the relics you gather along your quest will cast shadows upon the outcome of your fate.", 20);
Console.WriteLine();
TypeText("Venture forth, unravel the mysteries that lurk in the shadows, and may your choices echo through the tapestry of darkness.", 20);
Console.WriteLine();
TypeText("Thank you for embarking on this journey, and may your adventure be filled with intrigue and danger.", 20);
Console.WriteLine();


Console.WriteLine("\nPress Enter to continue...");
Console.ReadLine();
Console.Clear();

SoundPlayer gameSoundPlayer = new SoundPlayer("C:/Users/myff3/source/repos/Text Based Adventure/Text Based Adventure/Tristram.wav");
gameSoundPlayer.Load();
gameSoundPlayer.Play();
gameSoundPlayer.PlayLooping();

Thread.Sleep(2000);







//The adventure thread should start below.
TypeText("Your adventure begins...", 50);
Console.Clear();

if (chosenClass == "Warrior")
{
    TypeText("You are a seasoned and battle-worn warrior, haunted by the echoes of past conflicts.", 30);
    Console.WriteLine();
    TypeText("Your muscles are honed but scarred, and your axe thirsts for the an opponent.", 30);
}
else if (chosenClass == "Wizard")
{
    TypeText("You are a wizened wizard, cloaked in the shadows of arcane mysteries.", 30);
    Console.WriteLine();
    TypeText("With countless years behind you, your mind holds ancient spells, and your journey is guided by the unseen.", 30);
}
else if (chosenClass == "Ranger")
{
    TypeText("You are an experienced ranger, a shadow in the twilight realms.", 30);
    Console.WriteLine();
    TypeText("Your senses are attuned to the whispers of the night, and your arrows find their mark in the heart of darkness.", 30);
}


TypeText("You sit in the dimly lit inn, savoring the meager warmth of the days-old soup provided by the weary innkeeper.", 30);
Console.WriteLine();
TypeText("Your stay here is but a fleeting moment; with the first rays of dawn, you'll be on your way.", 30);
Console.WriteLine();
TypeText("The inn is almost empty, a reflection of the town's obscure existence, hidden from the bustle of the world.", 30);
Console.WriteLine();
TypeText("As you finish the last spoonful of your soup, the creaking door announces the arrival of a tired-looking man.", 30);
Console.WriteLine();
TypeText("His eyes scan the room, eventually locking onto the innkeeper. With a hesitant step, he approaches the counter,", 30);
Console.WriteLine();
TypeText("clutching a worn piece of paper. 'I'm seeking a " + chosenClass + " by the name of...'", 30); //Other person speaking
Console.WriteLine();
TypeText("His gaze shifts to the paper, confirming your identity. '" + name + ",' he says, weariness etched in his voice.", 30); //Other person speaking
Console.WriteLine();
TypeText("The innkeeper shrugs, 'I don't know him,' he responds, then glances around the room,", 30); //Other person speaking
Console.WriteLine();
TypeText("'Is there a " + name + " in here?' the stranger queries, his eyes searching the faces in the dim light.", 30); //Other person speaking
Console.WriteLine();

Console.WriteLine("Do you choose to stand up and announce yourself?"); //Option
Console.WriteLine("\nPress Enter to confirm..."); //Option
Console.ReadLine();
Console.WriteLine();

TypeText("With a deliberate motion, you rise from your seat. 'My name is " + name + ". What do you want?'", 30);//Player speaking






