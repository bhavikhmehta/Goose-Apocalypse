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
		/*

		//scenario 1
		TextDisplay.SlowTypeHor("You wake up from the CHE102 lecture and mumble something about converting pounds to kg");
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
	
		*/
		TextDisplay.NegativeBannerMessage("Engagement: Enraged Goose");
		TextDisplay.Continue();
		battle = new Combat(mainChar);

		TextDisplay.SlowTypeHor("You succesfully avenged Bob's passing and exit the room in search of sanctuary");
		TextDisplay.SlowTypeHor("The halls are empty and you feel very strange walking through them");
		TextDisplay.SlowTypeHor("You see the shadow of what seems to be an older individual around the corner");
		TextDisplay.SlowTypeHor("");

	}
}