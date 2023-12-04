using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Monogame_Part2_assignment
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;
        Texture2D footballTexture;
        Texture2D soccerTexture;
        Rectangle footballRect;
        Rectangle soccerRect;
        int x1 = 0;
        int y1 = 0;
        int x2 = 0;
        int y2 = 0;

        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            // TODO: Add your initialization logic here
            footballRect = new Rectangle(x1, y1, 80, 80);
            soccerRect = new Rectangle((x2 + 81), y2, 80, 80);
            _graphics.PreferredBackBufferHeight = 800;
            _graphics.PreferredBackBufferWidth = 800;
            _graphics.ApplyChanges();
            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);
            footballTexture = Content.Load<Texture2D>("football");
            soccerTexture = Content.Load<Texture2D>("soccerball");
            // TODO: use this.Content to load your game content here
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            // TODO: Add your update logic here

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.MonoGameOrange);

            // TODO: Add your drawing code here
            _spriteBatch.Begin();
            while ()
            {
                _spriteBatch.Draw(footballTexture, footballRect, Color.White);
            }
            _spriteBatch.Draw(soccerTexture, soccerRect, Color.White);
            _spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}