using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Content;
using System.ComponentModel;

namespace MonoGameSpaceWar.Classes
{
    public class Bullet
    {
        private Texture2D texture;
        private Rectangle destinationRectangle;
        private bool isAlive = true;

        private int width = 20;
        private int height = 50;
        private int speed = 3;

        private Color color;
        public int Width
        {
            get{return width; }
        }
        public int Height
        {
            get { return height; }
        }
        public bool IsAlive { get { return isAlive; } set { isAlive = value; } }
        public Vector2 Position
        {
            get
            {
                return new Vector2(destinationRectangle.X, destinationRectangle.Y);
            }
            set
            {
                destinationRectangle.X = (int)value.X;
                destinationRectangle.Y = (int)value.Y;
            }
        }
        public Bullet()
        {
            texture = null;
            destinationRectangle= new Rectangle(0,0, width, height);
        }
        public Bullet(Vector2 position)
        {
            texture = null;
            destinationRectangle = new Rectangle((int)position.X, (int)position.Y, width, height);
        }
        public Rectangle Collision
        {
            get
            {
                return destinationRectangle;
            }
        }
        public void LoadContent(ContentManager manager)
        {
            texture = manager.Load<Texture2D>("asteroid");
        }
        public void Update()
        {
            destinationRectangle.Y -= speed;
            if(Position.Y < 0-height)
            {
                isAlive = false;
            }
        }
        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(texture, destinationRectangle,Color.Red);
        }
    }
}
