using System;

class Combat
{	
	Character c;
	int gooseDamage = 1;
	int gooseHealth = 3;
	Random rand = new Random();

	public Combat( Character c )
	{
		this.c = c;
		while( ! (c.Health <= 0 || gooseHealth <= 0) )
		{
			Display();
			c.Health = c.Health - gooseDamage;

			if( rand.Next( 1, 101 ) >= c.Tolerance * 100 )
			{
				gooseHealth = gooseHealth - (int) c.Resistance;
				TextDisplay.BattleTurn(c.Resistance);
			}
			else
			{
				Console.WriteLine("You missed!");
				TextDisplay.ContinueText();
			}
		}
		
		//replace Yes with randomized phrase
		TextDisplay.PositiveBannerMessage("Yes! You won!");
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
//		Character c = new Character( "john" );
//		Combat n = new Combat(c);
//	}
//}