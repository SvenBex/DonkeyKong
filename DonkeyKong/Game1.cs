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
        private DateTime lastUpdate = DateTime.Now;
        private Color color = Color.Red;
        private Random rnd = new Random();
        private Vector2 vector;
        private Rectangle rec = new Rectangle(0,0,0,0);

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
            if (Keyboard.GetState().IsKeyDown(Keys.Right))
            {
                vector.X += 5;
            }

            if (Keyboard.GetState().IsKeyDown(Keys.Left))
            {
                vector.X -= 5;
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
            //if (lastUpdate.AddMilliseconds(500) < DateTime.Now )
            //{
            //    lastUpdate = DateTime.Now;
            //    color = new Color(rnd.Next(256), rnd.Next(256), rnd.Next(256));
            //    rec = new Rectangle(100, 100, rnd.Next(1, 100), rnd.Next(1, 100));
            //    vector = new Vector2(rnd.Next(100), rnd.Next(100));
            //}
            GraphicsDevice.Clear(color);

            // TODO: Add your drawing code here

            spriteBatch.Begin();
            spriteBatch.Draw(mario, vector);
            //spriteBatch.Draw(mario, vector, rec, Color.Black);
            spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}
