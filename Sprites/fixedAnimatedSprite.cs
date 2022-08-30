using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Threading;

public class fixedAnimatedSprite: ISprite
{

    private int currentFrame;
    private int totalFrames;
    private SpriteBatch spriteBatch;
    private Vector2 position;
    private List<Texture2D> textures;
    public fixedAnimatedSprite(SpriteBatch spriteBatch, Vector2 position, List<Texture2D> textures) 
	{
        this.spriteBatch = spriteBatch;
        this.position = position;
        this.textures = textures;
        currentFrame = 0;
        totalFrames = this.textures.Count;
    }
    public void Update()
    {
        currentFrame++;
        if (currentFrame == totalFrames)
        {
            currentFrame = 0;   
        }
    }

    public void Draw()
    {
        
        spriteBatch.GraphicsDevice.Clear(Color.CornflowerBlue);
        spriteBatch.Begin();
        spriteBatch.Draw(textures[currentFrame], position, Color.White);
        spriteBatch.End();
        Thread.Sleep(15);

    }
}
