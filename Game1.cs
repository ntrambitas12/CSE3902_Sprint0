using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Sprint0
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;
       private ArrayList controllerList;
        private MouseController mouseController;
        private KeyboardController keyboardController;
        public int currentSprite { get; set; }
        private ISprite fixedSprite;
        private ISprite fixedAnimatedSprite;
        private ISprite movingAnimatedSprite;
        private ISprite movingStaticSprite;
        private ISprite textSprite;
        private ISprite textSprite1;
        private ISprite textSprite2;
        private Texture2D Luigi;
        private List<Texture2D> marioAnimated;
        private SpriteFont font;
        private ArrayList sprites;
        private ArrayList creditsList;
        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            // Intialize Lists
            sprites = new ArrayList();
            controllerList = new ArrayList();
            creditsList = new ArrayList();
            marioAnimated = new List<Texture2D>();

            // Create the controllers
            keyboardController = new KeyboardController();
            mouseController = new MouseController();
           
            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);

            // Load all the sprites into the game, instanciate them, then add their command

            for (int i = 0; i <= 11; i++)
            {
                marioAnimated.Add(Content.Load<Texture2D>("marioAnim/mario" + i));
            }

            Luigi = Content.Load<Texture2D>("luigi");
             font = Content.Load<SpriteFont>("Credits");

            //Create the sprites
            CreateSprites();

            // Create the credit sprits
            CreateTextSprites();

            // Set the input to the game
            SetGameInput();

            // Add all controllers to the controller list
            controllerList.Add(keyboardController);
            controllerList.Add(mouseController);
        }

        protected override void Update(GameTime gameTime)
        {
            foreach (IController controller in controllerList)
            {
             controller.Update();
            }
           
            // Get the current sprite and draw it out to the screen
            ISprite current = (ISprite)sprites[currentSprite];
            current.Update();
            current.Draw();
             
            foreach (ISprite credits in creditsList)
            {
                credits.Draw();
            }
      
            base.Update(gameTime);
        }

        private void SetGameInput()
        {
            //Create Command for when to render the sprites
            ICommand fixedSpriteCom = new CommandSprite(this, 0);
            ICommand fixedAnimatedSpriteCom = new CommandSprite(this, 1);
            ICommand movingAnimatedSpriteCom = new CommandSprite(this, 2);
            ICommand movingStaticSpriteCom = new CommandSprite(this, 3);

            // Create the keyboard key actions
            keyboardController.RegisterCommand(Keys.D1, fixedSpriteCom);
            keyboardController.RegisterCommand(Keys.D2, fixedAnimatedSpriteCom);
            keyboardController.RegisterCommand(Keys.D3, movingAnimatedSpriteCom);
            keyboardController.RegisterCommand(Keys.D4, movingStaticSpriteCom);
            keyboardController.RegisterCommand(Keys.D0, new CommandExit(this));


            // Create the mouse click actions **0 is left mouse click, 1 is right click, rectangle describes postion of cursor**
            mouseController.RegisterCommand(new Rectangle(0, 0, 320, 240), fixedSpriteCom, 0);
            mouseController.RegisterCommand(new Rectangle(320, 0, 640, 240), fixedAnimatedSpriteCom, 0);
            mouseController.RegisterCommand(new Rectangle(0, 240, 400, 240), movingStaticSpriteCom, 0);
            mouseController.RegisterCommand(new Rectangle(400, 240, 640, 240), movingAnimatedSpriteCom, 0);
            mouseController.RegisterCommand(new Rectangle(0, 0, 640, 480), new CommandExit(this), 1);
        }

        private void CreateSprites()
        {
            // Create the sprites
            fixedSprite = new FixedSprite(_spriteBatch, new Vector2(450, 240), Luigi);
            fixedAnimatedSprite = new FixedAnimatedSprite(_spriteBatch, new Vector2(400, 200), marioAnimated);
            movingAnimatedSprite = new MovingAnimatedSprite(_spriteBatch, new Vector2(300, 200), marioAnimated);
            movingStaticSprite = new MovingStaticSprite(_spriteBatch, new Vector2(300, 200), Luigi);

            // Add sprites to the list
            sprites.Add(fixedSprite);
            sprites.Add(fixedAnimatedSprite);
            sprites.Add(movingAnimatedSprite);
            sprites.Add(movingStaticSprite);
        }

        private void CreateTextSprites()
        {
            textSprite = new TextSprite("Credits:", new Vector2(200, 400), _spriteBatch, font);
            textSprite1 = new TextSprite("Program Made By: Nicholas Trambitas", new Vector2(200, 420), _spriteBatch, font);
            textSprite2 = new TextSprite("Sprites from: https://www.mariouniverse.com/wp-content/img/sprites/nes/smb/characters.gif", new Vector2(100, 440), _spriteBatch, font);

            //Add credit to the list
            creditsList.Add(textSprite);
            creditsList.Add(textSprite1);
            creditsList.Add(textSprite2);
        }


    }


}