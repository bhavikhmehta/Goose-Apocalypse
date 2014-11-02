using System;

class TextDisplayTest
{
	static void Main()
	{
		TextDisplay.Continue();

		TextDisplay.SlowTypeHor("You wake up from the CHE102 lecture and mumble something about converting pounds to kg");
		TextDisplay.SlowTypeHor("This is a sample line");
		TextDisplay.SlowTypeHor("This is another sample line");

		TextDisplay.Continue();

		TextDisplay.NegativeBannerMessage("You Died");
		TextDisplay.Continue();
		
		TextDisplay.PositiveBannerMessage("You found a 1 ohm Resistor!");
		TextDisplay.Continue();
	}
}