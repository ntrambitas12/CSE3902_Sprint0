using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

public class CommandExit: ICommand
{
	private Game game;
	public CommandExit(Game game)
	{
		this.game = game;
	}

	public void Execute()
	{
		game.Exit();
	}
}
