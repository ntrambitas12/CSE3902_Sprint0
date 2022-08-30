using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using System;

class movingStaticSprite: ISprite
    {
    private SpriteBatch spriteBatch;
    private Vector2 position;
    private Texture2D texture;

    public movingStaticSprite(SpriteBatch spriteBatch, Vector2 position, Texture2D texture)
    {
        this.spriteBatch = spriteBatch;
        this.position = position;
        this.texture = texture;
    }

    public void Update()
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

    public void Draw()
    {
        spriteBatch.GraphicsDevice.Clear(Color.CornflowerBlue);
        spriteBatch.Begin();
        spriteBatch.Draw(texture, position, Color.White);
        spriteBatch.End();

    }
}

