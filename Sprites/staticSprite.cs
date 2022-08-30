using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    public abstract class staticSprite:ISprite
    {
    public SpriteBatch spriteBatch;
    public Vector2 position;
    public Texture2D texture;

    public staticSprite(SpriteBatch spriteBatch, Vector2 position, Texture2D texture)
    {
        this.spriteBatch = spriteBatch;
        this.position = position;
        this.texture = texture;
    }
    public abstract void Update();
    public void Draw()
    {
        spriteBatch.GraphicsDevice.Clear(Color.CornflowerBlue);
        spriteBatch.Begin();
        spriteBatch.Draw(texture, position, Color.White);
        spriteBatch.End();

    }
}

