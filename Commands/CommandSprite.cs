using Sprint0;
using System;

public class CommandSprite: ICommand
{
	private Game1 game;
	private int currentSprite;
	public CommandSprite(Game1 game, int currentSprite)
	{
		this.game = game;
		this.currentSprite = currentSprite;
	}

	public void Execute()
	{
		game.currentSprite = currentSprite;
	}
}
