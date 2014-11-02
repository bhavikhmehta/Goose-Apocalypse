using System;
using System.IO;

class character
{
	public string name;
	public int morality;
	//Resistor currentResistor;
	public int health;

	public character( string name )
	{
		this.name = name;
		this.morality = 0;
		this.health = 100;

		//finish resistor contructor later
		//this.currentResistor = new Resistor( ) 
	}
	public string Name
	{
		get
		{
			return name;
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
}
