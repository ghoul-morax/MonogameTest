using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using MonoGameSpaceWar.Classes;

namespace MonoGameSpaceWar.classes
{
    public enum TypePlayer { Beginner, Intermediate, Advanced, Pro, God }

    internal class Player
    {
        private Vector2 position;
        private Texture2D texture;
        private TypePlayer typePlayer;
        private float speed;
        private Rectangle collision;
        private List<Bullet> bulletList = new List<Bullet>();
        private int time = 0;
        private int TimeMax = 30;
        public Rectangle Collision { get { return collision; } }
        public List<Bullet> Bullets { get { return bulletList; } }
        
        public Player()
        {
            position = new Vector2(50, 50);
            texture = null;
            typePlayer = TypePlayer.Beginner;
            speed = 8;
           
        }

        public void LoadContent(ContentManager content)
        {
           texture =  content.Load<Texture2D>("player");
           
        }
        public void Update(ContentManager content)
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

            collision = new Rectangle((int)position.X, (int) position.Y, texture.Width, texture.Height);
            time++;
            if (time>TimeMax)
            {
                Bullet bullet = new Bullet();
                bullet.Position = new Vector2(position.X + texture.Width/2 - bullet.Width/2,position.Y + bullet.Height/2);

                bullet.LoadContent(content);
                bulletList.Add(bullet);
                time = 0;
            }
            for(int i = 0; i<bulletList.Count; i++)
            {
                Bullet bullet = bulletList[i];
                bullet.Update();
            }
            for(int i = 0; i < bulletList.Count;i++)
            {
                if (!bulletList[i].IsAlive)
                {
                    bulletList.RemoveAt(i);
                    i--;
                }
            }
            if(keyboardState.IsKeyDown(Keys.Q))
            {
                int a = 1;
            }

        }

        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(texture, position, Color.White);
            foreach(var bullet in bulletList)
            {
                bullet.Draw(spriteBatch);
            }
          
        }
    }
}
