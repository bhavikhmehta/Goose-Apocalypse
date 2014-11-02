using System;

static class Timers
{
	public static string CurrentTime()
	{
		return string.Format( "{0:t}", DateTime.Now );
	}
}