using Backend.Entities;
using Backend.GameState;
using GameController.Interfaces;
using GameController.KeyboardController;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace DonkeyKong
{
    /// <summary>
    /// This is the main type for your game.
    /// </summary>
    public class Game1 : Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;
        private ObjectPositionRepository positionRepository;
        private IControllerInput controller;

        //Old stuff
        private Texture2D platform;
        private Color color = Color.Black;

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
            controller = new NonInvertedKeyboardBehaviour();
            positionRepository = ObjectPositionRepository.InitializeRepository();

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

            //TODO Improve this
            Player player = new Player
            {
                Id = 1,
                PlayerLives = 1,
                Texture = Content.Load<Texture2D>("Mario jump"),
                DestinationRectangle = new Rectangle(0, 0, 400, 346),
                SourceRectangle = null,
                Color = Color.White,
                Rotation = 0.0f,
                Origin = new Vector2(),
                Effects = SpriteEffects.None,
                LayerDepth = 0.0f
            };

            positionRepository.AddPlayerPosition(player);

            Platform platform1 = new Platform
            {
                Id = 1,
                ObjectIsSolid = true,
                Texture = Content.Load<Texture2D>("platform"),
                DestinationRectangle = new Rectangle(500, 100, 100, 25),
                SourceRectangle = null,
                Color = Color.White,
                Rotation = 0.0f,
                Origin = new Vector2(),
                Effects = SpriteEffects.None,
                LayerDepth = 0.0f
            };

            positionRepository.AddSolidPosition(platform1);
            
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
            MovementBehaviour.UpdateObjectPositions(positionRepository, controller);
            GameRules.CheckGameRules(positionRepository);
            
            base.Update(gameTime);
        }

        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(color);
            ObjectDrawer.Draw(spriteBatch, positionRepository);

            base.Draw(gameTime);
        }
    }
}
