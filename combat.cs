using System;

class Combat
{	
	Character c;
	int gooseDamage = 1;
	int gooseHealth = 3;
	Random rand = new Random;

	public Combat( Character c )
	{
		this.c = c;
		while( ! (c.Health <= 0 || gooseHealth <= 0) )
		{
			Display();
			c.Health = c.Health - gooseDamage;

			if( rand.Next( 1, 101 ) >= c.Tolerance * 100 )gooseHealth = gooseHealth - (int) c.Resistance;
		}
	}

	public void Display()
	{
		Console.WriteLine();
		Console.WriteLine( "gooseHealth {0}", this.gooseHealth);
		Console.WriteLine( "playerHealth {0}", this.c.Health);
	}
}

static class Program
{
	static void Main()
	{	
		Character c = new Character( "john" );
		Combat n = new Combat(c);
	}
}