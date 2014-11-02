using System;

class Game
{
	static void Main( )
	{
		bool xo = true;		

		TwoPlayerGame twoplayer = new TwoPlayerGame( xo );
	}

}

public class TwoPlayerGame
{
	Random rand = new Random();
	GameGrid game;
	public TwoPlayerGame( bool xo )
	{
		this.game = new GameGrid( );
		
		bool isGameActive = true;
		game.Display( );
		while( isGameActive == true )
		{
			
			
			if( xo == true ) 
			{
				Console.Write( "enter position: " );
				while( game.Assign( xo, int.Parse( Console.ReadLine( ) ) ) == false )
				{
					Console.WriteLine( "Enter an empty position: " );
				}
			}	
			else
			{
				while( game.Assign( xo, (int) rand.Next( 1, 10 ) ) == false )
				{
					Console.WriteLine( "tried");
				}
			}
			//use try catch statement
			
			
			game.Display( );
			if( game.IsDraw( ) == true )
			{
				Console.WriteLine( "Its a Draw!" );
				return;
			}
			if( game.IsXWin( ) == true )
			{
				Console.WriteLine( "X WON!" );
				return;
			}
			if( game.IsOWin( ) == true )
			{
				Console.WriteLine( "O WON!" );
				return;
			}

			xo = !xo;
		}
	}
}

public class GameGrid
{
	public GameSquare[] grid = new GameSquare[ 9 ];
	
	public GameGrid( )
	{
		for( int i = 0; i <= 8; i++ )
		{
			grid[ i ] = new GameSquare( );
		}
	}
	
	public bool Assign( bool xo, int position )
	{	
		if( grid[ position - 1 ].ToString( ) == "X" || grid[ position - 1 ].ToString( ) == "O" )
		{
			return false;
		}
		else
		{
			grid[ position - 1 ].Set( xo );
			return true;
		}
		
	}
	
	public bool IsDraw( )
	{
		for( int i = 0; i <= 8; i++ )
		{
			if( grid[ i ].ToString( ) == " " )
			{
				return false;
			}
		}
		return true;
	}
	public bool IsXWin( )
	{
		if( grid[ 0 ].ToString( ) == "X" && grid[ 1 ].ToString( ) == "X" && grid[ 2 ].ToString( ) == "X" ) return true;
		else if( grid[ 3 ].ToString( ) == "X" && grid[ 4 ].ToString( ) == "X" && grid[ 5 ].ToString( ) == "X" ) return true;
		else if( grid[ 6 ].ToString( ) == "X" && grid[ 7 ].ToString( ) == "X" && grid[ 8 ].ToString( ) == "X" ) return true;
		
		else if( grid[ 0 ].ToString( ) == "X" && grid[ 3 ].ToString( ) == "X" && grid[ 6 ].ToString( ) == "X" ) return true;
		else if( grid[ 1 ].ToString( ) == "X" && grid[ 4 ].ToString( ) == "X" && grid[ 7 ].ToString( ) == "X" ) return true;
		else if( grid[ 2 ].ToString( ) == "X" && grid[ 5 ].ToString( ) == "X" && grid[ 8 ].ToString( ) == "X" ) return true;
		
		else if( grid[ 0 ].ToString( ) == "X" && grid[ 4 ].ToString( ) == "X" && grid[ 8 ].ToString( ) == "X" ) return true;
		else if( grid[ 2 ].ToString( ) == "X" && grid[ 4 ].ToString( ) == "X" && grid[ 6 ].ToString( ) == "X" ) return true;
		else return false;
	}
	
	public bool IsOWin( )
	{
		if( grid[ 0 ].ToString( ) == "O" && grid[ 1 ].ToString( ) == "O" && grid[ 2 ].ToString( ) == "O" ) return true;
		else if( grid[ 3 ].ToString( ) == "O" && grid[ 4 ].ToString( ) == "O" && grid[ 5 ].ToString( ) == "O" ) return true;
		else if( grid[ 6 ].ToString( ) == "O" && grid[ 7 ].ToString( ) == "O" && grid[ 8 ].ToString( ) == "O" ) return true;

		else if( grid[ 0 ].ToString( ) == "O" && grid[ 3 ].ToString( ) == "O" && grid[ 6 ].ToString( ) == "O" ) return true;
		else if( grid[ 1 ].ToString( ) == "O" && grid[ 4 ].ToString( ) == "O" && grid[ 7 ].ToString( ) == "O" ) return true;
		else if( grid[ 2 ].ToString( ) == "O" && grid[ 5 ].ToString( ) == "O" && grid[ 8 ].ToString( ) == "O" ) return true;

		else if( grid[ 0 ].ToString( ) == "O" && grid[ 4 ].ToString( ) == "O" && grid[ 8 ].ToString( ) == "O" ) return true;
		else if( grid[ 2 ].ToString( ) == "O" && grid[ 4 ].ToString( ) == "O" && grid[ 6 ].ToString( ) == "O" ) return true;
		else return false;
	}
	public void Display( )
	{
		Console.Clear( );
		Console.WriteLine( );
		Console.WriteLine( "       ||     ||     " );
		Console.WriteLine( "    {0}  ||  {1}  ||  {2}  ", grid[ 0 ], grid[ 1 ], grid[ 2 ] );
		Console.WriteLine( "       1|     2|     3" );
		Console.WriteLine( "  -----++-----++-----" );
		Console.WriteLine( "  -----++-----++-----" );
		Console.WriteLine( "       ||     ||     " );
		Console.WriteLine( "    {0}  ||  {1}  ||  {2}  ", grid[ 3 ], grid[ 4 ], grid[ 5 ] );
		Console.WriteLine( "       4|     5|     6" );
		Console.WriteLine( "  -----++-----++-----" );
		Console.WriteLine( "  -----++-----++-----" );
		Console.WriteLine( "       ||     ||     " );
		Console.WriteLine( "    {0}  ||  {1}  ||  {2}  ", grid[ 6 ], grid[ 7 ], grid[ 8 ] );
		Console.WriteLine( "       7|     8|     9" );
		Console.WriteLine( );
	}
	
}

public class GameSquare
{
	bool isX;
	bool isO;
	
	public GameSquare( )
	{
		this.isX = false;
		this.isO = false;
	}
	
	public void Set( bool xo )
	{
		if( xo == true ) 
		{
		isX = true;
		isO = false;
		}
		if( xo == false ) 
		{
		isO = true;
		isX = false;
		}
	}
	
	public override string ToString( )
	{
		if( isX == true ) return "X";
		if( isO == true ) return "O";
		else return " ";
	}
}
