using System;

class Combat
{	

	Character c;
	double gooseDamage;
	double gooseHealth = 100;
	double charDamage;
	Random rand = new Random();

	
	public Combat( Character c )
	{
		this.c = c;
		while( ! (c.Health <= 0 || gooseHealth <= 0) )
		{

			gooseDamage = Math.Ceiling(((c.Health) * (rand.Next( 0 , 20))/100.0));
			Display();
			c.Health = c.Health - gooseDamage;
			charDamage = Math.Ceiling((gooseHealth - (c.Resistance) * (rand.Next(80,110)/100.0)));


			if( rand.Next( 1, 101 ) >= c.Tolerance * 100 )
			{
				gooseHealth = charDamage;
				TextDisplay.BattleTurn(Math.Ceiling((c.Resistance) * (rand.Next(90,110)/100.0)));
			}
			else
			{
				Console.WriteLine("You missed!");
				TextDisplay.ContinueText();
			}
		}

		//replace Yes with randomized phrase
		TextDisplay.PositiveBannerMessage(TextDisplay.UppercaseFirst(Catch.ExclaimPhrase()) + "! You won!");
	}

	public void Display()
	{
		Console.WriteLine();

		Console.WriteLine( "gooseHealth {0}", this.gooseHealth);
		Console.WriteLine( "playerHealth {0}", this.c.Health);
	}
}

//static class Program
//{
//	static void Main()
//	{	
//		Character c = new Character();
//		Combat n = new Combat(c);
//	}
//}