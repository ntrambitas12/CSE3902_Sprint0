using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;


     class TextSprite: ISprite, IUpdateable
    {
    private Vector2 position;
    private String text;
    private SpriteBatch spriteBatch;
    private SpriteFont font;
    public TextSprite(String text, Vector2 position, SpriteBatch spriteBatch, SpriteFont font)
    {
        this.text = text;
        this.position = position;
        this.spriteBatch = spriteBatch;
        this.font = font;
    }
    public void Update()
    {
        
    }

    public void Draw()
    {
        spriteBatch.DrawString(font, text, position, Color.Black);
    }
    }

