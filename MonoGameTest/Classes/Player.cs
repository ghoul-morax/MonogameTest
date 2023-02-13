using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace MonoGameSpaceWar.classes
{
    public enum TypePlayer { Beginner, Intermediate, Advanced, Pro, God }

    internal class Player
    {
        private Vector2 position;
        private Texture2D texture;
        private TypePlayer typePlayer;
        private float speed;
        
        public Player()
        {
            position = new Vector2(50, 50);
            texture = null;
            typePlayer = TypePlayer.Beginner;
            speed = 8;
        }

        public void LoadContent(ContentManager manager)
        {
           texture =  manager.Load<Texture2D>("player");
        }
        public void Update()
        {
            #region Movement
            KeyboardState keyboardState = Keyboard.GetState();
            if (keyboardState.IsKeyDown(Keys.D))
            {
                position.X += speed;
            }
            if (keyboardState.IsKeyDown(Keys.A))
            {
                position.X -= speed;
            }
            if (keyboardState.IsKeyDown(Keys.W))
            {
                position.Y -= speed;
            }
            if (keyboardState.IsKeyDown(Keys.S))
            {
                position.Y += speed;
            }
            #endregion

            #region Bounds
            if (position.X < 0)
            {
                position.X = 0;
            }
            if (position.Y < 0)
            {
                position.Y = 0;

            }
            if (position.X + texture.Width > 800)
            {
                position.X = 800 - texture.Width;
            }
            if (position.Y + texture.Height > 600)
            {
                position.Y  = 600 - texture.Height;
            }
            #endregion



        }

        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(texture, position, Color.White);
        }
    }
}
