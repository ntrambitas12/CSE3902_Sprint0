using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

   public abstract class AnimatedSprite:ISprite
    {
    public int currentFrame;
    public int totalFrames;
    public SpriteBatch spriteBatch;
    public Vector2 position;
    public List<Texture2D> textures;
    public AnimatedSprite(SpriteBatch spriteBatch, Vector2 position, List<Texture2D> textures)
    {
        this.spriteBatch = spriteBatch;
        this.position = position;
        this.textures = textures;
        currentFrame = 0;
        totalFrames = this.textures.Count;
    }

    public abstract void Update();

    public void Draw()
    {
       
        spriteBatch.Draw(textures[currentFrame], position, Color.White);
        Thread.Sleep(15);

    }
}

