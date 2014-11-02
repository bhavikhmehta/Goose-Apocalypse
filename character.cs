using System;
using System.IO;

class Character
{
	public string name;
	public int morality;
	Resistor currentResistor;
	public int health;

	public Character( )
	{
		this.morality = 0;
		this.health = 100;	
		this.currentResistor = new Resistor( 1d, 0.2 );
	}
	public string Name
	{
		get
		{
			return name;
		}
		set
		{
			this.name = value;
		}
	}
	public int Morality
	{
		get
		{
			return morality;
		}
		set
		{
			this.morality = value;
		}
	}
	public int Health
	{
		get
		{
			return health;
		}
		set
		{
			this.health = value;
		}
	}
	public double Resistance
	{
		get
		{
			return currentResistor.Resistance;
		}
	}
	public double Tolerance
	{
		get
		{
			return currentResistor.Tolerance;
		}
	}
}
