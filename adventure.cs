using System;
using System.IO;

class Adventure
{
	static void Main()
	{
		//Console.SetWindowSize(190, 50);
		Character mainChar = new Character();
		Combat battle;



		//game start
		TextDisplay.EventBannerMessage("Game Initialized");

		TextDisplay.Chapter("Chapter 1: The Beginning");
		

		//scenario 1
		TextDisplay.SlowTypeHor("You wake up from the CHE102 lecture in RCH and mumble something about converting pounds to kg");
		TextDisplay.SlowTypeHor("You look around and realize the room is empty.");
		TextDisplay.SlowTypeHor("You check your watch...");

		TextDisplay.GreenBlackWrite(Timers.CurrentTime());

		TextDisplay.SlowTypeHor("You've been asleep for hours...");
		TextDisplay.SlowTypeHor("You get up and leave the lecture hall");
		TextDisplay.SlowTypeHor("You see a seemingly clueless person standing against a wall...");
		TextDisplay.TheyTalk("My name is Bob and I'm in SYDE");
		TextDisplay.YouTalk("This isn't frosh week you don't need to identify yourself by your program...Relax.");
		TextDisplay.TheyTalk("Okay :(");
		TextDisplay.YouTalk("What the actual fudge is going? Where is everyone?");
		TextDisplay.TheyTalk("I don't know, I just woke up after falling in ECE100A and no one was around...");
		TextDisplay.YouTalk("You really shouldn't be sleeping in class.");
		
		TextDisplay.NegativeBannerMessage("*Honk* *Honk*");
		
		TextDisplay.SlowTypeHor("You hear an all too familiar sound from all too familiar animal");
		TextDisplay.YouTalk("What the fudge is that!?!?!");
		TextDisplay.TheyTalk("Branta canadensis maxima or as you commoners call it: The Canada Goose");
		TextDisplay.SlowTypeHor("The geese lunges at Bob");
		TextDisplay.YouTalk("Bob!! Nooooooooooooo!");
		TextDisplay.TheyTalk("Avenge me...stranger");
		TextDisplay.YouTalk("My name is...");

		Console.Write("Enter your name: ");
		mainChar.Name = Console.ReadLine();
		

		TextDisplay.NegativeBannerMessage("Bob Died.");
		TextDisplay.Continue();
		TextDisplay.SlowTypeHor("You pick up a 5 ohm resistor with tolerance of 0.5 on the floor and use it as an effective weapon.");
	
		
		TextDisplay.NegativeBannerMessage("Engagement: Enraged Goose");
		TextDisplay.Continue();
		battle = new Combat(mainChar);

		TextDisplay.SlowTypeHor("You succesfully avenged Bob's passing and exit the room in search of sanctuary");
		TextDisplay.SlowTypeHor("The halls are empty and you feel very strange walking through them");
		TextDisplay.SlowTypeHor("You see the shadow of what seems to be an older individual around the corner");
		TextDisplay.SlowTypeHor("");
		TextDisplay.YouTalk("Who's there?");
		TextDisplay.TheyTalk("I am proffesour Hirani");
		TextDisplay.YouTalk("What can you tell me about this goose outbreak?");
		TextDisplay.TheyTalk("Nothing, until you can beat me at five rounds of rock paper scissors!");
		mainChar.Morality = Puzzles.Puzzle1();
		TextDisplay.TheyTalk("You beat me! You are truly a good student!");
		TextDisplay.YouTalk("Now tell me about this outbreak and what exactly is SYDE?");
		TextDisplay.TheyTalk("Nobody knows what SYDE is.");
		TextDisplay.TheyTalk("The geese are building a goose bomb.");
		TextDisplay.TheyTalk("They are planning to make the entire world their kingdom.");
		TextDisplay.YouTalk("How can we stop this?");
		TextDisplay.TheyTalk("Speak to Prof Muffin for more information.");
		TextDisplay.TheyTalk("He is located in DWE. Good luck!");
		TextDisplay.YouTalk("Thank you and good bye sir.");
		TextDisplay.TheyTalk("WAIT! Take this 10 ohm resistor with  a tolerance of 0.2.");
		TextDisplay.SlowTypeHor("Your current resistor value is: " + mainChar.Resistance + " Your current tolerance is: " + mainChar.Tolerance );
		TextDisplay.SlowTypeHor("Would you like to swap your weapon or.... ");
		TextDisplay.SlowTypeHor("Take a chance to your resistor in series or parallel.");
		TextDisplay.SlowTypeHor("If series, the two resistors will be combined.");
		TextDisplay.SlowTypeHor("In parallel, the resistors will be added in parallel and subtracted from your current value");
		TextDisplay.SlowTypeHor("What do you choose?");
		TextDisplay.SlowTypeHor("Type 0 to swap, 1 to take a chance, 2 to keep your current weapon. Press enter then type the value");
		int option = int.Parse(Console.ReadLine());
		if (option == 0)
		{
			mainChar.currentResistor.Swap( 10,  0.2);
		}
		else if (option == 1)
		{
			mainChar.currentResistor.Change( 10,  0.2);
		}

		TextDisplay.SlowTypeHor("Your current resistor value is: " + mainChar.Resistance + " Your current tolerance is: " + mainChar.Tolerance );

		TextDisplay.Chapter("Chapter 2: The Tale of a snoopy Goose!");
		TextDisplay.SlowTypeHor("To be continued...");

	}
}