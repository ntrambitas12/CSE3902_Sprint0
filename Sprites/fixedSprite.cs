using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;

public class fixedSprite: ISprite
{
	private SpriteBatch spriteBatch;
	private Vector2 position;
	private Texture2D texture;

	public fixedSprite(SpriteBatch spriteBatch, Vector2 position, Texture2D texture)
	{
		this.spriteBatch = spriteBatch;
		this.position = position;
		this.texture = texture;
	}

	public void Update()
	{

	}

	public void Draw()
	{
        spriteBatch.GraphicsDevice.Clear(Color.CornflowerBlue);
        spriteBatch.Begin();
		spriteBatch.Draw(texture, position, Color.White);
		spriteBatch.End();

	}
}
