using GameController;
using GameController.Interfaces;
using GameController.KeyboardController;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;

namespace DonkeyKong
{
    /// <summary>
    /// This is the main type for your game.
    /// </summary>
    public class Game1 : Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;
        private Texture2D mario;
        private Texture2D platform;
        private DateTime lastUpdate = DateTime.Now;
        private Color color = Color.Black;
        private Random rnd = new Random();
        private Vector2 vector;
        private Rectangle marioRec = new Rectangle(0,0,400,346);
        private Rectangle platformRec = new Rectangle(500, 100, 100, 25);
        private IControllerInput controller = new NonInvertedKeyboardBehaviour();

        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
        }

        /// <summary>
        /// Allows the game to perform any initialization it needs to before starting to run.
        /// This is where it can query for any required services and load any non-graphic
        /// related content.  Calling base.Initialize will enumerate through any components
        /// and initialize them as well.
        /// </summary>
        protected override void Initialize()
        {
            // TODO: Add your initialization logic here
            base.Initialize();
        }

        /// <summary>
        /// LoadContent will be called once per game and is the place to load
        /// all of your content.
        /// </summary>
        protected override void LoadContent()
        {
            // Create a new SpriteBatch, which can be used to draw textures.
            spriteBatch = new SpriteBatch(GraphicsDevice);

            // TODO: use this.Content to load your game content here
            mario = Content.Load<Texture2D>("Mario jump");
            platform = Content.Load<Texture2D>("platform");
            
        }

        /// <summary>
        /// UnloadContent will be called once per game and is the place to unload
        /// game-specific content.
        /// </summary>
        protected override void UnloadContent()
        {
            // TODO: Unload any non ContentManager content here
        }

        /// <summary>
        /// Allows the game to run logic such as updating the world,
        /// checking for collisions, gathering input, and playing audio.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();
            if (controller.MoveRight())
            {
                var platVal = platformRec.Left;
                var marioVal = marioRec.Right;
                if (marioRec.Right < platformRec.Left)
                {
                    vector.X += 5;
                    marioRec.X += 5;
                }
                
            }

            if (controller.MoveLeft())
            {
                vector.X -= 5;
                marioRec.X -= 5;
            }
            // TODO: Add your update logic here
            
            base.Update(gameTime);
        }

        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(color);

            // TODO: Add your drawing code here

            spriteBatch.Begin();
            spriteBatch.Draw(platform, platformRec, Color.Red);
            spriteBatch.Draw(mario, vector, null, Color.White, 0.0F, new Vector2(0, 0), 1.0F, SpriteEffects.FlipHorizontally, 0.0F);
            //spriteBatch.Draw(mario, vector, rec, Color.Black);
            spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}
