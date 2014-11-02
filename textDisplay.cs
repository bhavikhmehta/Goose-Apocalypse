using System;
using System.IO;

	class TextDisplay
	{
		
		//Used for negative events
		public static void NegativeBannerMessage(string centeredText)
		{
			string halfBorder = new string('-', (Console.WindowWidth - centeredText.Length) / 2);
			string fullBorder = new string('-', Console.WindowWidth);

			Console.BackgroundColor = ConsoleColor.DarkRed;
			Console.ForegroundColor = ConsoleColor.White;
			Console.Write(fullBorder);
			if(centeredText.Length % 2 == 0)
			{
				Console.Write(halfBorder + centeredText + halfBorder);
			}
			else
			{
				Console.Write(halfBorder + centeredText + halfBorder + '-');
			}
			Console.Write(fullBorder);
			Console.BackgroundColor = ConsoleColor.Black;
			Console.ForegroundColor = ConsoleColor.White;
		}
		
		//Used for positive events
		public static void PositiveBannerMessage(string centeredText)
		{
			string halfBorder = new string('-', (Console.WindowWidth - centeredText.Length) / 2);
			string fullBorder = new string('-', Console.WindowWidth);

			Console.BackgroundColor = ConsoleColor.DarkGreen;
			Console.ForegroundColor = ConsoleColor.White;
			Console.Write(fullBorder);
			if(centeredText.Length % 2 == 0)
			{
				Console.Write(halfBorder + centeredText + halfBorder);
			}
			else
			{
				Console.Write(halfBorder + centeredText + halfBorder + '-');
			}
			Console.Write(fullBorder);
			Console.BackgroundColor = ConsoleColor.Black;
			Console.ForegroundColor = ConsoleColor.White;
		}
		
		//for dialogue
		public static void SlowTypeHor(string myText)
		{
			for(int i = 0; i < myText.Length; i++)
			{
				Console.Write(myText[i]);
				System.Threading.
				Thread.Sleep(50);
			}
			Console.WriteLine();
			ContinueText();
		}

		//flashing cursor continue
		public static void ContinueText()
		{
			ConsoleKeyInfo continueKey;
			continueKey = Console.ReadKey();
		}

		//press any key to continue (also clears screen)
		public static void Continue()
		{
			ConsoleKeyInfo continueKey;
			Console.WriteLine("Press any key to continue...");
			continueKey = Console.ReadKey();
			Console.Clear();
		}
	}