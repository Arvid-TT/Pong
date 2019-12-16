using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;

namespace Game1
{
    /// <summary>
    /// This is the main type for your game.
    /// </summary>
    public class Game1 : Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;
        Fonster f;
        Texture2D pixel;
        Boll b;
        Rectangle rpad;
        Rectangle lpad;
        Forstagangen y = new Forstagangen();
        Random slump = new Random();
        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            f = new Fonster(Window.ClientBounds.Width, Window.ClientBounds.Height);

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
            pixel = Content.Load<Texture2D>("Stjarna");
            // TODO: use this.Content to load your game content here
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
            if (y.Yaas == true)
            {
                b = new Boll(new Rectangle(f.Bredd / 2 - 10, f.Höjd / 2 - 10, 20, 20));
                lpad = new Rectangle(5, f.Höjd / 2 - 70, 20, 140);
                rpad = new Rectangle(f.Bredd - 25, f.Höjd / 2 - 70, 20, 140);
                b.X = slump.Next(1, 3);
                if (slump.Next(1, 3) == 1)
                {
                    b.X *= -1;
                }
                b.Y = slump.Next(1, 3);
                if (slump.Next(1, 3) == 1)
                {
                    b.Y *= -1;
                }

                y.Yaas = false;
            }
            KeyboardState kstate = Keyboard.GetState();
            if (kstate.IsKeyDown(Keys.Up) == true)
            {
                rpad.Y -= 5;
                if (rpad.Y < 0)
                {
                    rpad.Y = 0;
                }
            }
            if (kstate.IsKeyDown(Keys.Down) == true)
            {
                rpad.Y += 5;
                if (rpad.Y > f.Höjd-140)
                {
                    rpad.Y = f.Höjd-140;
                }
            }
            if (kstate.IsKeyDown(Keys.W) == true)
            {
                lpad.Y -= 5;
                if (lpad.Y < 0)
                {
                    lpad.Y = 0;
                }
            }
            if (kstate.IsKeyDown(Keys.S) == true)
            {
                lpad.Y += 5;
                if (lpad.Y > f.Höjd-140)
                {
                    lpad.Y = f.Höjd-140;
                }
            }
            if (b.Rek.Intersects(lpad) || b.Rek.Intersects(rpad))
            {
                b.X *= -1;
                int s = slump.Next(1, 11);
                if (s < 3)
                {

                }
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
            GraphicsDevice.Clear(Color.Black);

            // TODO: Add your drawing code here
            spriteBatch.Begin();
            spriteBatch.Draw(pixel, boll, Color.White);
            spriteBatch.Draw(pixel, rpad, Color.White);
            spriteBatch.Draw(pixel, lpad, Color.White);
            spriteBatch.End();
            base.Draw(gameTime);
        }
    }
}
