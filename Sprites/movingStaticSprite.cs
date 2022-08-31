using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using System;

class MovingStaticSprite: StaticSprite
    {
  

    public MovingStaticSprite(SpriteBatch spriteBatch, Vector2 position, Texture2D texture): base(spriteBatch, position, texture) { }

    public override void Update()
    {
        if (position.Y >= 0 && position.Y <= 480)
        {
            position.Y++;
        }
        else
        {
            position.Y = 0;
        }

    }

}

