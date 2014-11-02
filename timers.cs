using System;

static class Timers
{
	public static string CurrentTime()
	{
		return string.Format( "{0:t}", DateTime.Now );
	}
}

class program
{
	static void Main()
	{
		Console.WriteLine( Timers.CurrentTime());
	}
}