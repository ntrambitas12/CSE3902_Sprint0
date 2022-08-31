using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Threading;

public class MovingAnimatedSprite : AnimatedSprite

{
    public MovingAnimatedSprite(SpriteBatch spriteBatch, Vector2 position, List<Texture2D> textures): base(spriteBatch, position, textures) { }
    public override void Update()
    {
        currentFrame++;
        if (currentFrame == totalFrames)
        {
            currentFrame = 0;
        }

        if (position.X >= 0 && position.X <= 800)
        {
            position.X++;
        } else
        {
            position.X = 0;
        }
    }

}