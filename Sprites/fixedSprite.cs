using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;

public class fixedSprite: staticSprite
{
	

	public fixedSprite(SpriteBatch spriteBatch, Vector2 position, Texture2D texture): base(spriteBatch, position, texture) { }


	public override void Update()
	{
		//No update action
	}

}
