var User = new User();


//Intro
beginning:
while (true)
{
    Console.WriteLine("Please enter your name");
    User.Name = Console.ReadLine();

    if (String.IsNullOrWhiteSpace(User.Name) != true)
    {
        break;
    }

    else
    {
        Console.WriteLine("You cannot leave your name blank!");
    }
}

User.HP = 100;
User.Block = 5;
System.Console.WriteLine("Welcome to the RPG Game, " + User.Name + ".");
Thread.Sleep(3000);
System.Console.WriteLine("In this game, you will go through three levels of enemies fighting your way to the end.");
Thread.Sleep(3200);
System.Console.WriteLine("Along the way, you may run across different equipment to help you!");
Thread.Sleep(3200);
System.Console.WriteLine("To play, simply respond to the prompt given.");
Thread.Sleep(1500);
Console.WriteLine("Respond with \"1\" to attack.");
Thread.Sleep(1500);
Console.WriteLine("Respond with \"2\" to block.");
Thread.Sleep(1500);
System.Console.WriteLine("But the enemy wont take your attacks lightly! Be prepared for the enemy to strike back!");
Thread.Sleep(2000);
System.Console.WriteLine("Good luck, " + User.Name + "..... you’ll need it");
Thread.Sleep(1500);

//First Enemy
var NightShade = new Enemy();
NightShade.Name = "NightShade";
NightShade.HP = 30;
System.Console.WriteLine("Level 1");
Thread.Sleep(1500);
System.Console.WriteLine("Your HP is 100");
Thread.Sleep(1500);
System.Console.WriteLine("A lurky shadow appears in front of you!");
Thread.Sleep(1700);
Console.WriteLine("\"I am " + NightShade.Name + " and you will feel my WRATH, " + User.Name + ".\"");

while (NightShade.HP > 0 && User.HP > 0)
{
    User.Attack = new Random().Next(2, 15);
    NightShade.Attack = new Random().Next(5, 28);
    Console.WriteLine("What do you do?");

    var userInput = (Console.ReadLine());
    if (userInput == "1")
    {
        NightShade.HP -= User.Attack;
        Console.WriteLine(NightShade.Name + " takes " + User.Attack + " damage. " + NightShade.Name + " health is " + NightShade.HP);
        Console.WriteLine("Oh No! NightShade is attacking!");
        User.HP -= NightShade.Attack;
        Console.WriteLine(NightShade.Name + " stuns for " + NightShade.Attack);
        Console.WriteLine("Your health is " + User.HP);
    }

    else if (userInput == "2")
    {
        Console.WriteLine(NightShade.Name + "prepares to hit for " + NightShade.Attack);
        NightShade.Attack -= User.Block;
        User.HP -= NightShade.Attack;
        Console.WriteLine("You put your shield up.You take ” +enemyDP");
        Console.WriteLine("Your health is " + User.HP);
    }

    else
    {
        Console.WriteLine("Enter Valid Input, fool");
    }
}
if (NightShade.HP <= 0 && User.HP > 0)
{
    Console.WriteLine("You have defeated me but there are others stronger! Mwah hahaha!");
}
else if (NightShade.HP <= 0 && User.HP <= 0)
{
    System.Console.WriteLine("Double KO! Try again!");
    goto beginning;
}
else if (User.HP <= 0)
{
    Console.WriteLine("WASTED, Play again");
    goto beginning;
}
// Second fight
User.HP = 200;
User.Block = 7;
var Mountain = new Enemy();
Mountain.Name = "The Mountain";
Mountain.HP = 50;
System.Console.WriteLine("You emerge from the battle wounded but victorious");
Thread.Sleep(1000);
System.Console.WriteLine("...");
Thread.Sleep(2000);
System.Console.WriteLine("[You spot a shining item behind the corpse of your enemy]");
Thread.Sleep(2000);
System.Console.WriteLine("[YOU PICK UP BRONZE ARMOR + IRON SWORD + MYSTERIOUS VIAL!]");
System.Console.WriteLine("...");
Thread.Sleep(1000);
System.Console.WriteLine("[ATTACK INCREASED]");
System.Console.WriteLine("[BLOCK + 3]");
Thread.Sleep(2000);
System.Console.WriteLine("[BLOCK IS NOW 7]");
Thread.Sleep(2000);
System.Console.WriteLine("[YOU DRINK THE CONTENTS IN THE VIAL...]");
Thread.Sleep(2000);
System.Console.WriteLine("[YOUR HEALTH IS NOW " + User.HP + "]");
Thread.Sleep(2000);
Console.WriteLine("[You journey continues ...]");
Thread.Sleep(3000);
System.Console.WriteLine("Level 2");
Thread.Sleep(1500);
System.Console.WriteLine("[You approach a narrow bridge and spot the shadow of a figure in the distance ...]");
Thread.Sleep(2000);
System.Console.WriteLine("(RAINFALL)");
Thread.Sleep(2000);
System.Console.WriteLine("(THUNDERCRASH)");
System.Console.WriteLine("[The figure approaches you and blocks the bridge ...]");
Thread.Sleep(3000);
System.Console.WriteLine("[The lightning alluminates the sky and reveals the identity of the figure...]");
Thread.Sleep(3000);
System.Console.WriteLine("[A knight in black armor weilding a giantsword stands in your way]");
Thread.Sleep(3000);
Console.WriteLine("\"I am " + Mountain.Name + ", Commander of the Forgotten Legion! ");
Console.WriteLine("\"" + User.Name + ", I have heard whispers of your name. Know that today, I shall put your reputation to the test. Prepare to become FORGOTTEN!\"");

while (Mountain.HP > 0 && User.HP > 0)
    while (Mountain.HP > 0 && User.HP > 0)
    {
        User.Attack = new Random().Next(3, 25);
        Mountain.Attack = new Random().Next(10, 45);
        Console.WriteLine("What do you do?");
        var userInput = (Console.ReadLine());
        if (userInput == "1")
        {
            Mountain.HP -= User.Attack;
            Console.WriteLine(Mountain.Name + " takes " + User.Attack + " damage. " + Mountain.Name + " health is " + Mountain.HP);
            Console.WriteLine("Oh No! The Mountain is attacking!");
            User.HP -= Mountain.Attack;
            Console.WriteLine(Mountain.Name + " slices for " + Mountain.Attack);
            Console.WriteLine("Your health is " + User.HP);
        }
        else if (userInput == "2")
        {
            Console.WriteLine(Mountain.Name + "winds up a swing for " + Mountain.Attack);
            Mountain.Attack -= User.Block;
            User.HP -= Mountain.Attack;
            Console.WriteLine("You put your shield up. You take " + Mountain.Attack);
            Console.WriteLine("Your health is " + User.HP);
        }
        else
        {
            Console.WriteLine("Enter Valid Input, fool");
        }
    }
if (Mountain.HP <= 0 && User.HP > 0)
{
    Console.WriteLine("Tis but a flesh wound... Know I will have my revenge.. In this life or the next.");
}
else if (Mountain.HP <= 0 && User.HP <= 0)
{
    System.Console.WriteLine("You slayed your enemy..but at the cost of your own life..");
    goto beginning;
}
else if (User.HP <= 0)
{
    Console.WriteLine("Your wounds are too many.. This is the end of the path for," + User.Name + " Play again");
    goto beginning;
}

//Final Boss
User.HP = 300;
User.Block = 10;
User.HP = 300;
User.Block = 10;

var Boss = new Enemy();
Boss.Name = "Boss Terry";
Boss.HP = 75;

Console.WriteLine("Level 3");
System.Threading.Thread.Sleep(2000);
Console.WriteLine(NightShade.Name + " dropped an obsidian sword and shield; you pick them up.");
System.Threading.Thread.Sleep(2000);
Console.WriteLine("Your HP is now " + User.HP + ".");
System.Threading.Thread.Sleep(1500);
Console.WriteLine("Your attack and defense have increased.");
System.Threading.Thread.Sleep(2000);
Console.WriteLine("You encounter...");
System.Threading.Thread.Sleep(3000);
Console.WriteLine(Boss.Name + ".");
System.Threading.Thread.Sleep(3200);
Console.WriteLine("\"..." + User.Name + "...");
System.Threading.Thread.Sleep(3200);
Console.WriteLine("IT'S TIME TO FALL ON YOUR FACE!\"");
System.Threading.Thread.Sleep(2000);

while (Boss.HP > 0 && User.HP > 0)
{
    User.Attack = new Random().Next(5, 30);
    Boss.Attack = new Random().Next(25, 75);
    Console.WriteLine("What do you do?");
    var userInput = Console.ReadLine();

    if (userInput == "1")
    {
        Console.WriteLine(Boss.Name + " attacks");
        System.Threading.Thread.Sleep(1000);
        User.HP -= Boss.Attack;
        Console.WriteLine(Boss.Name + " hits for " + Boss.Attack + ". Your health is now " + User.HP);
        System.Threading.Thread.Sleep(1000);
        Console.WriteLine(User.Name + " attacks");
        System.Threading.Thread.Sleep(1000);
        Boss.HP -= User.Attack;
        Console.WriteLine(Boss.Name + " takes " + User.Attack + " damage. " + Boss.Name + "'s health is now " + Boss.HP);
        System.Threading.Thread.Sleep(1000);
    }

    else if (userInput == "2")
    {
        Console.WriteLine(Boss.Name + " prepares to hit for " + Boss.Attack);
        System.Threading.Thread.Sleep(1000);
        Boss.Attack -= User.Block;
        User.HP -= Boss.Attack;
        Console.WriteLine("You put your shield up. You take " + Boss.Attack);
        System.Threading.Thread.Sleep(1000);
        Console.WriteLine("Your health is now " + User.HP);
        System.Threading.Thread.Sleep(1000);
    }

    else
    {
        Console.WriteLine("Enter Valid Input, fool");
    }

}

if (Boss.HP <= 0 && User.HP > 0)
{
    Console.WriteLine(User.Name + " defeated " + Boss.Name + " and found six-figures-worth of treasure.");
    System.Threading.Thread.Sleep(2000);
    Console.WriteLine("THE END");
}

else if (Boss.HP <= 0 && User.HP <= 0)
{
    Console.WriteLine(User.Name + " & " + Boss.Name + " slay each other in simultaneous attacks and waste away together");
    System.Threading.Thread.Sleep(2000);
    Console.WriteLine("THE END");
}

else if (User.HP <= 0)
{
    Console.WriteLine("You have fallen on your face.");
    System.Threading.Thread.Sleep(2000);
    Console.WriteLine("GAME OVER");
    goto beginning;
}
